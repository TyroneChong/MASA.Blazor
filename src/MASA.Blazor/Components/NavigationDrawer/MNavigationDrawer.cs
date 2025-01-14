﻿using System.ComponentModel;
using BlazorComponent;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System.Threading.Tasks;
using OneOf;

namespace MASA.Blazor
{
    public partial class MNavigationDrawer : BNavigationDrawer, INavigationDrawer
    {
        [Parameter]
        public bool Bottom { get; set; }

        [Parameter]
        public bool Clipped { get; set; }

        [Parameter]
        public bool DisableResizeWatcher { get; set; }

        [Parameter]
        public bool DisableRouteWatcher { get; set; }

        [Parameter]
        public bool Floating { get; set; }

        [Parameter]
        public StringNumber Height
        {
            get
            {
                return GetValue<StringNumber>(App ? "100vh" : "100%");
            }
            set
            {
                SetValue(value);
            }
        }

        [Parameter]
        public StringNumber MiniVariantWidth { get; set; } = 56;

        [Parameter]
        public bool Right { get; set; }

        [Parameter]
        public bool Touchless { get; set; }

        [Parameter]
        public StringNumber Width { get; set; } = "256px";

        [Parameter]
        public string Color { get; set; }

        [Parameter]
        public OneOf<Breakpoints, double> MobileBreakpoint
        {
            get
            {
                return GetValue(MasaBlazor.Breakpoint.MobileBreakpoint);
            }
            set
            {
                SetValue(value);
            }
        }

        [Parameter]
        public string OverlayColor { get; set; }

        [Parameter]
        public StringNumber OverlayOpacity { get; set; }

        [Parameter]
        public bool Dark { get; set; }

        [Parameter]
        public bool Light { get; set; }

        [CascadingParameter]
        public IThemeable Themeable { get; set; }

        public bool IsDark
        {
            get
            {
                if (Dark)
                {
                    return true;
                }

                if (Light)
                {
                    return false;
                }

                return Themeable != null && Themeable.IsDark;
            }
        }

        [Parameter]
        public bool Absolute { get; set; }

        [Parameter]
        public bool Fixed { get; set; }

        [Parameter]
        public RenderFragment AppendContent { get; set; }

        [Parameter]
        public RenderFragment PrependContent { get; set; }

        [Inject]
        public MasaBlazor MasaBlazor { get; set; }

        protected StringNumber ComputedMaxHeight
        {
            get
            {
                if (!HasApp) return null;

                var computedMaxHeight = MasaBlazor.Application.Bottom + MasaBlazor.Application.Footer + MasaBlazor.Application.Bar;

                if (!Clipped) return computedMaxHeight;

                return computedMaxHeight + MasaBlazor.Application.Top;
            }
        }

        protected StringNumber ComputedTop
        {
            get
            {
                if (!HasApp)
                {
                    return 0;
                }

                var computedTop = MasaBlazor.Application.Bar;
                computedTop += Clipped ? MasaBlazor.Application.Top : 0;

                return computedTop;
            }
        }

        protected StringNumber ComputedTransform
        {
            get
            {
                if (IsActive)
                {
                    return 0;
                }

                if (IsBottom)
                {
                    return 100;
                }

                return Right ? 100 : -100;
            }
        }

        protected StringNumber ComputedWidth
        {
            get
            {
                return IsMiniVariant ? MiniVariantWidth : Width;
            }
        }

        protected bool HasApp => App && (!IsMobile && !Temporary);

        protected bool IsBottom => Bottom && IsMobile;

        protected bool IsMiniVariant => (!ExpandOnHover && MiniVariant) || (ExpandOnHover && !IsMouseover);

        //TODO: reactsToClick,reactsToMobile,reactsToResize,reactsToResize

        protected int ZIndex { get; set; }

        protected override bool IsMobileBreakpoint
        {
            get
            {
                var mobile = MasaBlazor.Breakpoint.Mobile;
                var width = MasaBlazor.Breakpoint.Width;
                var name = MasaBlazor.Breakpoint.Name;
                var mobileBreakpoint = MasaBlazor.Breakpoint.MobileBreakpoint;

                if (mobileBreakpoint.Value == MobileBreakpoint.Value)
                {
                    return mobile;
                }

                return mobileBreakpoint.IsT1 ? width < mobileBreakpoint.AsT1 : name == mobileBreakpoint.AsT0;
            }
        }

        protected override void OnInitialized()
        {
            base.OnInitialized();

            Watcher
                .Watch<bool>(nameof(Value), val =>
                {
                    if (Permanent)
                    {
                        return;
                    }

                    if (val != IsActive)
                    {
                        IsActive = val;
                    }
                })
                .Watch<bool>(nameof(ExpandOnHover), UpdateMiniVariant)
                .Watch<bool>(nameof(IsMouseover), val =>
                {
                    UpdateMiniVariant(!val);
                });

            Init();

            MasaBlazor.Breakpoint.OnUpdate += OnBreakpointOnUpdate;
        }

        private async Task OnBreakpointOnUpdate()
        {
            await InvokeAsync(async () =>
            {
                //We will change this when watcher finished
                IsActive = !IsMobile;
                if (ValueChanged.HasDelegate)
                {
                    await ValueChanged.InvokeAsync(IsActive);
                }
                else
                {
                    StateHasChanged();
                }
            });
        }

        private void UpdateMiniVariant(bool val)
        {
            if (MiniVariant != val)
            {
                MiniVariant = val;
                if (MiniVariantChanged.HasDelegate)
                {
                    MiniVariantChanged.InvokeAsync(val);
                }
            }
        }

        private void Init()
        {
            if (Permanent)
            {
                IsActive = true;
            }
            else if (Stateless)
            {
                IsActive = Value;
            }
            else if (!Temporary)
            {
                IsActive = !IsMobile;
            }

            if (ExpandOnHover)
            {
                UpdateMiniVariant(true);
            }
        }

        protected override void SetComponentClass()
        {
            var prefix = "m-navigation-drawer";

            CssProvider
                .Apply(cssBuilder =>
                {
                    cssBuilder
                        .Add("m-navigation-drawer")
                        .AddIf($"{prefix}--absolute", () => Absolute)
                        .AddIf($"{prefix}--bottom", () => Bottom)
                        .AddIf($"{prefix}--clipped", () => Clipped)
                        .AddIf($"{prefix}--close", () => !IsActive)
                        .AddIf($"{prefix}--fixed", () => !Absolute && (App || Fixed))
                        .AddIf($"{prefix}--floating", () => Floating)
                        .AddIf($"{prefix}--is-mobile", () => IsMobile)
                        .AddIf($"{prefix}--is-mouseover", () => IsMouseover)
                        .AddIf($"{prefix}--mini-variant", () => IsMiniVariant)
                        .AddIf($"{prefix}--custom-mini-variant", () => MiniVariantWidth.ToDouble() != 56)
                        .AddIf($"{prefix}--open", () => IsActive)
                        .AddIf($"{prefix}--open-on-hover", () => ExpandOnHover)
                        .AddIf($"{prefix}--right", () => Right)
                        .AddIf($"{prefix}--temporary", () => Temporary) //
                        .AddTheme(IsDark)
                        .AddBackgroundColor(Color);
                }, styleBuilder =>
                {
                    var translate = IsBottom ? "translateY" : "translateX";
                    styleBuilder
                        .AddHeight(Height)
                        .Add(() => $"top:{(!IsBottom ? ComputedTop.ToUnit() : "auto")}")
                        .AddIf(() => $"max-height:calc(100% - {ComputedMaxHeight.ToUnit()})", () => ComputedMaxHeight != null)
                        .AddIf(() => $"transform:{translate}({ComputedTransform.ToUnit("%")})", () => ComputedTransform != null)
                        .AddWidth(ComputedWidth)
                        .AddBackgroundColor(Color);
                })
                .Apply("content", cssBuilder =>
                {
                    cssBuilder
                        .Add($"{prefix}__content");
                })
                .Apply("border", cssBuilder =>
                {
                    cssBuilder
                        .Add($"{prefix}__border");
                })
                .Apply("prepend", cssBuilder =>
                {
                    cssBuilder
                        .Add($"{prefix}__prepend");
                })
                .Apply("append", cssBuilder =>
                {
                    cssBuilder
                        .Add($"{prefix}__append");
                })
                .Apply("image", cssBuilder =>
                {
                    cssBuilder
                        .Add($"{prefix}__image");
                });

            Attributes.Add("data-booted", "true");

            AbstractProvider
                .ApplyNavigationDrawerDefault()
                .Apply(typeof(IImage), typeof(MImage), attrs =>
                {
                    attrs[nameof(MImage.Src)] = Src;
                    attrs[nameof(MImage.Height)] = (StringNumber)"100%";
                    attrs[nameof(MImage.Width)] = (StringNumber)"100%";
                })
                .Apply<BOverlay, MOverlay>(attrs =>
                {
                    attrs[nameof(MOverlay.ZIndex)] = ZIndex;
                    attrs[nameof(MOverlay.Absolute)] = !Fixed;
                    attrs[nameof(MOverlay.Value)] = ShowOverlay;
                });
        }

        protected override async Task OnParametersSetAsync()
        {
            await UpdateApplicationAsync();
        }

        protected async Task UpdateApplicationAsync()
        {
            if (!App)
            {
                return;
            }

            var val = (!IsActive || IsMobile || Temporary || Ref.Id == null)
                ? 0
                : (ComputedWidth.ToDouble() <= 0 ? await GetClientWidthAsync() : ComputedWidth.ToDouble());

            if (Right)
                MasaBlazor.Application.Right = val;
            else
                MasaBlazor.Application.Left = val;
        }

        private async Task<double> GetClientWidthAsync()
        {
            if (Ref.Id == null)
            {
                return 0;
            }

            var element = await JsInvokeAsync<BlazorComponent.Web.Element>(
                   JsInteropConstants.GetDomInfo, Ref);
            return element.ClientWidth;
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await base.OnAfterRenderAsync(firstRender);

            if (firstRender)
            {
                ZIndex = await GetActiveZIndexAsync();
            }
        }

        private Task<int> GetActiveZIndexAsync() => JsInvokeAsync<int>(JsInteropConstants.GetZIndex, Ref);

        public override async Task HandleOnClickAsync(MouseEventArgs e)
        {
            if (MiniVariant)
            {
                MiniVariant = false;
                if (MiniVariantChanged.HasDelegate)
                {
                    await MiniVariantChanged.InvokeAsync(MiniVariant);
                }
            }
        }

        protected override void Dispose(bool disposing)
        {
            RemoveApplication();
            MasaBlazor.Breakpoint.OnUpdate -= OnBreakpointOnUpdate;
        }

        private void RemoveApplication()
        {
            if (Right)
                MasaBlazor.Application.Right = 0;
            else
                MasaBlazor.Application.Left = 0;
        }
    }
}