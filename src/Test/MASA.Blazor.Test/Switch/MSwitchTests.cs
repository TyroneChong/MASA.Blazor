﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using Bunit;

namespace MASA.Blazor.Test.Switch
{
    [TestClass]
    public class MSwitchTests:TestBase
    {
        [TestMethod]
        public void RenderSwitchWithDark()
        {
            //Act
            var cut = RenderComponent<MSwitch>(props =>
            {
                props.Add(Switch => Switch.Dark, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasDarkClass = classes.Contains("theme--dark");
            // Assert
            Assert.IsTrue(hasDarkClass);
        }

        [TestMethod]
        public void RenderSwitchWithDense()
        {
            //Act
            var cut = RenderComponent<MSwitch>(props =>
            {
                props.Add(Switch => Switch.Dense, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasDenseClass = classes.Contains("m-input--switch");
            // Assert
            Assert.IsTrue(hasDenseClass);
        }

        [TestMethod]
        public void RenderSwitchWithDisabled()
        {
            //Act
            var cut = RenderComponent<MSwitch>(props =>
            {
                props.Add(Switch => Switch.Disabled, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasDisabledClass = classes.Contains("m-input--switch");
            // Assert
            Assert.IsTrue(hasDisabledClass);
        }

        [TestMethod]
        public void RenderSwitchWithError()
        {
            //Act
            var cut = RenderComponent<MSwitch>(props =>
            {
                props.Add(Switch => Switch.Error, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasErrorClass = classes.Contains("m-input--switch");
            // Assert
            Assert.IsTrue(hasErrorClass);
        }

        [TestMethod]
        public void RenderSwitchWithErrorCount()
        {
            //Act
            var cut = RenderComponent<MSwitch>(props =>
            {
                props.Add(Switch => Switch.ErrorCount, 1);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasErrorCountClass = classes.Contains("m-input--switch");

            // Assert
            Assert.IsTrue(hasErrorCountClass);
        }

        [TestMethod]
        public void RenderSwitchWithFlat()
        {
            //Act
            var cut = RenderComponent<MSwitch>(props =>
            {
                props.Add(Switch => Switch.Flat, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasFlatClass = classes.Contains("m-input--switch--flat");
            // Assert
            Assert.IsTrue(hasFlatClass);
        }

        [TestMethod]
        public void RenderSwitchWithHideDetails()
        {
            //Act
            var cut = RenderComponent<MSwitch>(props =>
            {
                props.Add(Switch => Switch.HideDetails, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasHideDetailsClass = classes.Contains("m-input--switch");
            // Assert
            Assert.IsTrue(hasHideDetailsClass);
        }

        [TestMethod]
        public void RenderSwitchWithInset()
        {
            //Act
            var cut = RenderComponent<MSwitch>(props =>
            {
                props.Add(Switch => Switch.Inset, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasInsetClass = classes.Contains("m-input--switch");
            // Assert
            Assert.IsTrue(hasInsetClass);
        }

        [TestMethod]
        public void RenderSwitchWithLight()
        {
            //Act
            var cut = RenderComponent<MSwitch>(props =>
            {
                props.Add(Switch => Switch.Light, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasLightClass = classes.Contains("theme--light");
            // Assert
            Assert.IsTrue(hasLightClass);
        }

        [TestMethod]
        public void RenderSwitchWithLoading()
        {
            //Act
            var cut = RenderComponent<MSwitch>(props =>
            {
                props.Add(Switch => Switch.Loading, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasLoadingClass = classes.Contains("m-input--switch");
            // Assert
            Assert.IsTrue(hasLoadingClass);
        }

        [TestMethod]
        public void RenderSwitchWithPersistentHint()
        {
            //Act
            var cut = RenderComponent<MSwitch>(props =>
            {
                props.Add(Switch => Switch.PersistentHint, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasPersistentHintClass = classes.Contains("m-input--switch");
            // Assert
            Assert.IsTrue(hasPersistentHintClass);
        }

        [TestMethod]
        public void RenderSwitchWithReadonly()
        {
            //Act
            var cut = RenderComponent<MSwitch>(props =>
            {
                props.Add(Switch => Switch.Readonly, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasReadonlyClass = classes.Contains("m-input--switch");
            // Assert
            Assert.IsTrue(hasReadonlyClass);
        }

        [TestMethod]
        public void RenderSwitchWithSuccess()
        {
            //Act
            var cut = RenderComponent<MSwitch>(props =>
            {
                props.Add(Switch => Switch.Success, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasSuccessClass = classes.Contains("m-input--switch");
            // Assert
            Assert.IsTrue(hasSuccessClass);
        }

        [TestMethod]
        public void RenderSwitchWithValidateOnBlur()
        {
            //Act
            var cut = RenderComponent<MSwitch>(props =>
            {
                props.Add(Switch => Switch.ValidateOnBlur, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasValidateOnBlurClass = classes.Contains("m-input--switch");
            // Assert
            Assert.IsTrue(hasValidateOnBlurClass);
        }

        [TestMethod]
        public void RenderSwitchWithValue()
        {
            //Act
            var cut = RenderComponent<MSwitch>(props =>
            {
                props.Add(Switch => Switch.Value, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasValueClass = classes.Contains("m-input--switch");
            // Assert
            Assert.IsTrue(hasValueClass);
        }

        [TestMethod]
        public void RenderSwitchWithAppendIcon()
        {
            //Act
            JSInterop.Mode = JSRuntimeMode.Loose;
            var cut = RenderComponent<MSwitch>(props =>
            {
                string icon = "mdi-star";
                props.Add(Switch => Switch.AppendIcon, icon);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasAppendIconClass = classes.Contains("m-input--switch");
            // Assert
            Assert.IsTrue(hasAppendIconClass);
        }

        [TestMethod]
        public void RenderSwitchWithBackgroundColor()
        {
            //Act
            JSInterop.Mode = JSRuntimeMode.Loose;
            var cut = RenderComponent<MSwitch>(props =>
            {
                string icon = "mdi-star";
                props.Add(Switch => Switch.BackgroundColor, icon);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasBackgroundColorClass = classes.Contains("m-input--switch");
            // Assert
            Assert.IsTrue(hasBackgroundColorClass);
        }

        [TestMethod]
        public void RenderSwitchWithColor()
        {
            //Act
            JSInterop.Mode = JSRuntimeMode.Loose;
            var cut = RenderComponent<MSwitch>(props =>
            {
                string icon = "mdi-star";
                props.Add(Switch => Switch.Color, icon);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasColorClass = classes.Contains("m-input--switch");
            // Assert
            Assert.IsTrue(hasColorClass);
        }

        [TestMethod]
        public void RenderSwitchWithHint()
        {
            //Act
            JSInterop.Mode = JSRuntimeMode.Loose;
            var cut = RenderComponent<MSwitch>(props =>
            {
                string icon = "mdi-star";
                props.Add(Switch => Switch.Hint, icon);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasHintClass = classes.Contains("m-input--switch");
            // Assert
            Assert.IsTrue(hasHintClass);
        }

        [TestMethod]
        public void RenderSwitchWithId()
        {
            //Act
            JSInterop.Mode = JSRuntimeMode.Loose;
            var cut = RenderComponent<MSwitch>(props =>
            {
                string icon = "mdi-star";
                props.Add(Switch => Switch.Id, icon);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasIdClass = classes.Contains("m-input--switch");
            // Assert
            Assert.IsTrue(hasIdClass);
        }

        [TestMethod]
        public void RenderSwitchWithLabel()
        {
            //Act
            JSInterop.Mode = JSRuntimeMode.Loose;
            var cut = RenderComponent<MSwitch>(props =>
            {
                string icon = "mdi-star";
                props.Add(Switch => Switch.Label, icon);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasLabelClass = classes.Contains("m-input--switch");
            // Assert
            Assert.IsTrue(hasLabelClass);
        }

        [TestMethod]
        public void RenderSwitchWithPrependIcon()
        {
            //Act
            JSInterop.Mode = JSRuntimeMode.Loose;
            var cut = RenderComponent<MSwitch>(props =>
            {
                string icon = "mdi-star";
                props.Add(Switch => Switch.PrependIcon, icon);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasPrependIconClass = classes.Contains("m-input--switch");
            // Assert
            Assert.IsTrue(hasPrependIconClass);
        }
    }
}
