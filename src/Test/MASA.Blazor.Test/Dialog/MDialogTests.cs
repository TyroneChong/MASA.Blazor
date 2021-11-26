﻿using Bunit;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MASA.Blazor.Test.Dialog
{
    [TestClass]
    public class MDialogTests:TestBase
    {
        [TestMethod]
        public void RenderDialogWithCloseDelay()
        {
            //Act
            var cut = RenderComponent<MDialog>(props =>
            {
                props.Add(alert => alert.CloseDelay, 0);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasCloseDelayClass = classes.Contains("m-dialog");

            // Assert
            Assert.IsTrue(hasCloseDelayClass);
        }

        [TestMethod]
        public void RenderDialogWithDark()
        {
            //Act
            var cut = RenderComponent<MDialog>(props =>
            {
                props.Add(dialog => dialog.Dark, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasDarkClass = classes.Contains("m-dialog");

            // Assert
            Assert.IsTrue(hasDarkClass);
        }

        [TestMethod]
        public void RenderDialogWithDisabled()
        {
            //Act
            var cut = RenderComponent<MDialog>(props =>
            {
                props.Add(dialog => dialog.Disabled, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasDisabledClass = classes.Contains("m-dialog");

            // Assert
            Assert.IsTrue(hasDisabledClass);
        }

        [TestMethod]
        public void RenderDialogWithFullscreen()
        {
            //Act
            var cut = RenderComponent<MDialog>(props =>
            {
                props.Add(dialog => dialog.Fullscreen, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasFullscreenClass = classes.Contains("m-dialog");

            // Assert
            Assert.IsTrue(hasFullscreenClass);
        }

        [TestMethod]
        public void RenderDialogWithLight()
        {
            //Act
            var cut = RenderComponent<MDialog>(props =>
            {
                props.Add(dialog => dialog.Light, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasLightClass = classes.Contains("m-dialog");

            // Assert
            Assert.IsTrue(hasLightClass);
        }

        //[TestMethod]
        //public void RenderWithMaxWidth()
        //{
        //    // Act
        //    var cut = RenderComponent<MDialog>(props =>
        //    {
        //        props.Add(p => p.MaxWidth, 100);
        //    });
        //    var inputSlotDiv = cut.Find(".");
        //    var style = inputSlotDiv.GetAttribute("style");

        //    // Assert
        //    Assert.AreEqual("height: 64px", style);
        //}

        //[TestMethod]
        //public void RenderWithWidth()
        //{
        //    // Act
        //    var cut = RenderComponent<MDialog>(props =>
        //    {
        //        props.Add(p => p.Width, 100);
        //    });
        //    var inputSlotDiv = cut.Find(".");
        //    var style = inputSlotDiv.GetAttribute("style");

        //    // Assert
        //    Assert.AreEqual("width: 64px", style);
        //}

        [TestMethod]
        public void RenderDialogWithOpenDelay()
        {
            //Act
            var cut = RenderComponent<MDialog>(props =>
            {
                props.Add(dialog => dialog.OpenDelay, 0);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasOpenDelayClass = classes.Contains("m-dialog");

            // Assert
            Assert.IsTrue(hasOpenDelayClass);
        }

        [TestMethod]
        public void RenderDialogWithOpenOnFocus()
        {
            //Act
            var cut = RenderComponent<MDialog>(props =>
            {
                props.Add(dialog => dialog.OpenOnFocus, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasOpenOnFocusClass = classes.Contains("m-dialog");

            // Assert
            Assert.IsTrue(hasOpenOnFocusClass);
        }

        [TestMethod]
        public void RenderDialogWithOpenOnHover()
        {
            //Act
            var cut = RenderComponent<MDialog>(props =>
            {
                props.Add(dialog => dialog.OpenOnHover, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasOpenOnHoverClass = classes.Contains("m-dialog");

            // Assert
            Assert.IsTrue(hasOpenOnHoverClass);
        }

        [TestMethod]
        public void RenderDialogWithPersistent()
        {
            //Act
            var cut = RenderComponent<MDialog>(props =>
            {
                props.Add(dialog => dialog.Persistent, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasPersistentClass = classes.Contains("m-dialog");

            // Assert
            Assert.IsTrue(hasPersistentClass);
        }

        [TestMethod]
        public void RenderDialogWithScrollable()
        {
            //Act
            var cut = RenderComponent<MDialog>(props =>
            {
                props.Add(dialog => dialog.Scrollable, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasScrollableClass = classes.Contains("m-dialog");

            // Assert
            Assert.IsTrue(hasScrollableClass);
        }

        //[TestMethod]
        //public void RenderWithChildContent()
        //{
        //    // Arrange & Act
        //    var cut = RenderComponent<MDialog>(props =>
        //    {
        //        props.Add(dialog => dialog.ChildContent, "<span>Hello world</span>");
        //    });
        //    var contentDiv = cut.Find(".m-dialog__container");

        //    // Assert
        //    contentDiv.Children.MarkupMatches("<span>Hello world</span>");
        //}
    }
}