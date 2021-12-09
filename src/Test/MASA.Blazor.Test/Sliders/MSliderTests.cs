﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bunit;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace MASA.Blazor.Test.Slider
{
    [TestClass]
    public class MSliderTests:TestBase
    {
        [TestMethod]
        public void RenderSliderWithDark()
        {
            //Act
            var cut = RenderComponent<MSlider<double>>(props =>
            {
                props.Add(slider => slider.Dark, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasDarkClass = classes.Contains("theme--dark");

            // Assert
            Assert.IsTrue(hasDarkClass);
        }

        [TestMethod]
        public void RenderSliderWithDense()
        {
            //Act
            var cut = RenderComponent<MSlider<double>>(props =>
            {
                props.Add(slider => slider.Dense, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasDenseClass = classes.Contains("dense");

            // Assert
            Assert.IsTrue(hasDenseClass);
        }

        [TestMethod]
        public void RenderSliderWithDisabled()
        {
            //Act
            var cut = RenderComponent<MSlider<double>>(props =>
            {
                props.Add(slider => slider.Disabled, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasDisabledClass = classes.Contains("m-input--is-disabled");

            // Assert
            Assert.IsTrue(hasDisabledClass);
        }

        [TestMethod]
        public void RenderSliderWithError()
        {
            //Act
            var cut = RenderComponent<MSlider<double>>(props =>
            {
                props.Add(slider => slider.Error, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasErrorClass = classes.Contains("m-input__slider");

            // Assert
            Assert.IsTrue(hasErrorClass);
        }

        [TestMethod]
        public void RenderSliderWithErrorCount()
        {
            //Act
            var cut = RenderComponent<MSlider<double>>(props =>
            {
                props.Add(slider => slider.ErrorCount, 1);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasErrorCountClass = classes.Contains("m-input__slider");

            // Assert
            Assert.IsTrue(hasErrorCountClass);
        }

        [TestMethod]
        public void RenderSliderWithHeight()
        {
            //Act
            var cut = RenderComponent<MSlider<double>>(props =>
            {
                props.Add(slider => slider.Height, 1);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasHeightClass = classes.Contains("m-input__slider");

            // Assert
            Assert.IsTrue(hasHeightClass);
        }

        [TestMethod]
        public void RenderSliderWithHideDetails()
        {
            //Act
            var cut = RenderComponent<MSlider<double>>(props =>
            {
                props.Add(slider => slider.HideDetails, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasHideDetailsClass = classes.Contains("m-input__slider");

            // Assert
            Assert.IsTrue(hasHideDetailsClass);
        }

        [TestMethod]
        public void RenderSliderWithInverseLabel()
        {
            //Act
            var cut = RenderComponent<MSlider<double>>(props =>
            {
                props.Add(slider => slider.InverseLabel, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasInverseLabelClass = classes.Contains("inverse-label");

            // Assert
            Assert.IsTrue(hasInverseLabelClass);
        }

        [TestMethod]
        public void RenderSliderWithLight()
        {
            //Act
            var cut = RenderComponent<MSlider<double>>(props =>
            {
                props.Add(slider => slider.Light, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasLightClass = classes.Contains("theme--light");

            // Assert
            Assert.IsTrue(hasLightClass);
        }

        [TestMethod]
        public void RenderSliderWithLoaderHeight()
        {
            //Act
            var cut = RenderComponent<MSlider<double>>(props =>
            {
                props.Add(slider => slider.LoaderHeight, 2);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasLoaderHeightClass = classes.Contains("m-input__slider");

            // Assert
            Assert.IsTrue(hasLoaderHeightClass);
        }

        [TestMethod]
        public void RenderSliderWithLoading()
        {
            //Act
            var cut = RenderComponent<MSlider<double>>(props =>
            {
                props.Add(slider => slider.Loading, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasLoadingClass = classes.Contains("m-input__slider");

            // Assert
            Assert.IsTrue(hasLoadingClass);
        }

        [TestMethod]
        public void RenderSliderWithMax()
        {
            //Act
            var cut = RenderComponent<MSlider<double>>(props =>
            {
                props.Add(slider => slider.Max, 100);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasMaxClass = classes.Contains("m-input__slider");

            // Assert
            Assert.IsTrue(hasMaxClass);
        }

        [TestMethod]
        public void RenderSliderWithMin()
        {
            //Act
            var cut = RenderComponent<MSlider<double>>(props =>
            {
                props.Add(slider => slider.Min, 100);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasMinClass = classes.Contains("m-input__slider");

            // Assert
            Assert.IsTrue(hasMinClass);
        }

        [TestMethod]
        public void RenderSliderWithPersistentHint()
        {
            //Act
            var cut = RenderComponent<MSlider<double>>(props =>
            {
                props.Add(slider => slider.PersistentHint, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasPersistentHintClass = classes.Contains("m-input__slider");

            // Assert
            Assert.IsTrue(hasPersistentHintClass);
        }

        [TestMethod]
        public void RenderSliderWithReadonly()
        {
            //Act
            var cut = RenderComponent<MSlider<double>>(props =>
            {
                props.Add(slider => slider.Readonly, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasReadonlyClass = classes.Contains("readonly");

            // Assert
            Assert.IsTrue(hasReadonlyClass);
        }

        [TestMethod]
        public void RenderSliderWithStep()
        {
            //Act
            var cut = RenderComponent<MSlider<double>>(props =>
            {
                props.Add(slider => slider.Step, 1);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasStepClass = classes.Contains("m-input__slider");

            // Assert
            Assert.IsTrue(hasStepClass);
        }

        [TestMethod]
        public void RenderSliderWithSuccess()
        {
            //Act
            var cut = RenderComponent<MSlider<double>>(props =>
            {
                props.Add(slider => slider.Success, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasSuccessClass = classes.Contains("m-input__slider");

            // Assert
            Assert.IsTrue(hasSuccessClass);
        }

        [TestMethod]
        public void RenderSliderWithThumbLabel()
        {
            //Act
            var cut = RenderComponent<MSlider<double>>(props =>
            {
                props.Add(slider => slider.ThumbLabel, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasThumbLabelClass = classes.Contains("m-input__slider");

            // Assert
            Assert.IsTrue(hasThumbLabelClass);
        }

        [TestMethod]
        public void RenderSliderWithTickSize()
        {
            //Act
            var cut = RenderComponent<MSlider<double>>(props =>
            {
                props.Add(slider => slider.TickSize, 2);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasTickSizeClass = classes.Contains("m-input__slider");

            // Assert
            Assert.IsTrue(hasTickSizeClass);
        }

        [TestMethod]
        public void RenderSliderWithTicks()
        {
            //Act
            var cut = RenderComponent<MSlider<double>>(props =>
            {
                props.Add(slider => slider.Ticks, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasTicksClass = classes.Contains("m-input__slider");

            // Assert
            Assert.IsTrue(hasTicksClass);
        }

        [TestMethod]
        public void RenderSliderWithValidateOnBlur()
        {
            //Act
            var cut = RenderComponent<MSlider<double>>(props =>
            {
                props.Add(slider => slider.ValidateOnBlur, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasValidateOnBlurClass = classes.Contains("m-input__slider");

            // Assert
            Assert.IsTrue(hasValidateOnBlurClass);
        }

        [TestMethod]
        public void RenderSliderWithVertical()
        {
            //Act
            var cut = RenderComponent<MSlider<double>>(props =>
            {
                props.Add(slider => slider.Vertical, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasVerticalClass = classes.Contains("m-input__slider--vertical");

            // Assert
            Assert.IsTrue(hasVerticalClass);
        }

        [TestMethod]
        public void RenderSliderWithAppendIcon()
        {
            //Act
            JSInterop.Mode = JSRuntimeMode.Loose;
            var cut = RenderComponent<MSlider<double>>(props =>
            {
                string icon = "mdi-star";
                props.Add(slider => slider.AppendIcon, icon);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasAppendIconClass = classes.Contains("m-input__slider");

            // Assert
            Assert.IsTrue(hasAppendIconClass);
        }

        [TestMethod]
        public void RenderSliderWithBackgroundColor()
        {
            //Act
            var cut = RenderComponent<MSlider<double>>(props =>
            {
                string icon = "mdi-star";
                props.Add(slider => slider.BackgroundColor, icon);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasBackgroundColorClass = classes.Contains("m-input__slider");

            // Assert
            Assert.IsTrue(hasBackgroundColorClass);
        }

        [TestMethod]
        public void RenderSliderWithColor()
        {
            //Act
            var cut = RenderComponent<MSlider<double>>(props =>
            {
                string icon = "mdi-star";
                props.Add(slider => slider.Color, icon);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasColorClass = classes.Contains("m-input__slider");

            // Assert
            Assert.IsTrue(hasColorClass);
        }

        [TestMethod]
        public void RenderSliderWithHint()
        {
            //Act
            var cut = RenderComponent<MSlider<double>>(props =>
            {
                string icon = "mdi-star";
                props.Add(slider => slider.Hint, icon);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasHintClass = classes.Contains("m-input__slider");

            // Assert
            Assert.IsTrue(hasHintClass);
        }

        [TestMethod]
        public void RenderSliderWithId()
        {
            //Act
            var cut = RenderComponent<MSlider<double>>(props =>
            {
                string icon = "mdi-star";
                props.Add(slider => slider.Id, icon);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasIdClass = classes.Contains("m-input__slider");

            // Assert
            Assert.IsTrue(hasIdClass);
        }

        [TestMethod]
        public void RenderSliderWithLabel()
        {
            //Act
            var cut = RenderComponent<MSlider<double>>(props =>
            {
                string icon = "mdi-star";
                props.Add(slider => slider.Label, icon);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasLabelClass = classes.Contains("m-input__slider");

            // Assert
            Assert.IsTrue(hasLabelClass);
        }

        [TestMethod]
        public void RenderSliderWithPrependIcon()
        {
            //Act
            JSInterop.Mode = JSRuntimeMode.Loose;
            var cut = RenderComponent<MSlider<double>>(props =>
            {
                string icon = "mdi-star";
                props.Add(slider => slider.PrependIcon, icon);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasPrependIconClass = classes.Contains("m-input__slider");

            // Assert
            Assert.IsTrue(hasPrependIconClass);
        }

        [TestMethod]
        public void RenderSliderWithThumbColor()
        {
            //Act
            var cut = RenderComponent<MSlider<double>>(props =>
            {
                string icon = "mdi-star";
                props.Add(slider => slider.ThumbColor, icon);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasThumbColorClass = classes.Contains("m-input__slider");

            // Assert
            Assert.IsTrue(hasThumbColorClass);
        }

        [TestMethod]
        public void RenderSliderWithThumbSize()
        {
            //Act
            var cut = RenderComponent<MSlider<double>>(props =>
            {
                props.Add(slider => slider.ThumbSize, 32);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasThumbSizeClass = classes.Contains("m-input__slider");

            // Assert
            Assert.IsTrue(hasThumbSizeClass);
        }

        [TestMethod]
        public void RenderSliderWithTrackColor()
        {
            //Act
            var cut = RenderComponent<MSlider<double>>(props =>
            {
                string icon = "mdi-star";
                props.Add(slider => slider.TrackColor, icon);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasTrackColorClass = classes.Contains("m-input__slider");

            // Assert
            Assert.IsTrue(hasTrackColorClass);
        }

        [TestMethod]
        public void RenderSliderWithTrackFillColor()
        {
            //Act
            var cut = RenderComponent<MSlider<double>>(props =>
            {
                string icon = "mdi-star";
                props.Add(slider => slider.TrackFillColor, icon);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasTrackFillColorClass = classes.Contains("m-input__slider");

            // Assert
            Assert.IsTrue(hasTrackFillColorClass);
        }

        [TestMethod]
        public void RenderWithThumbLabelContent()
        {
            // Arrange & Act
            var cut = RenderComponent<MSlider<double>>(props =>
            {
                props.Add(slider => slider.ThumbLabelContent, context => "<span>Hello world</span>");
            });
            var sliderDiv = cut.Find(".m-slider__thumb-label>div");

            // Assert
            sliderDiv.Children.MarkupMatches("<span>Hello world</span>");
        }
    }
}
