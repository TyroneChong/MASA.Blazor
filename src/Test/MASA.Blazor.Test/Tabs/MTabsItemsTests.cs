﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bunit;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MASA.Blazor.Test.Tabs
{
    [TestClass]
    public class MTabsItemsTests:TestBase
    {
        [TestMethod]
        public void RenderTabsItemsWithContinuous()
        {
            //Act
            var cut = RenderComponent<MTabsItems>(props =>
            {
                props.Add(tabsitems => tabsitems.Continuous, false);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasContinuousClass = classes.Contains("m-tabs-items");

            // Assert
            Assert.IsTrue(hasContinuousClass);
        }

        [TestMethod]
        public void RenderTabsItemsWithDark()
        {
            //Act
            var cut = RenderComponent<MTabsItems>(props =>
            {
                props.Add(tabsitems => tabsitems.Dark, false);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasDarkClass = classes.Contains("theme--dark");

            // Assert
            Assert.IsTrue(hasDarkClass);
        }

        [TestMethod]
        public void RenderTabsItemsWithLight()
        {
            //Act
            var cut = RenderComponent<MTabsItems>(props =>
            {
                props.Add(tabsitems => tabsitems.Light, false);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasLightClass = classes.Contains("theme--light");

            // Assert
            Assert.IsTrue(hasLightClass);
        }

        [TestMethod]
        public void RenderTabsItemsWithMandatory()
        {
            //Act
            var cut = RenderComponent<MTabsItems>(props =>
            {
                props.Add(tabsitems => tabsitems.Mandatory, false);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasMandatoryClass = classes.Contains("m-tabs-items");

            // Assert
            Assert.IsTrue(hasMandatoryClass);
        }

        [TestMethod]
        public void RenderTabsItemsWithMultiple()
        {
            //Act
            var cut = RenderComponent<MTabsItems>(props =>
            {
                props.Add(tabsitems => tabsitems.Multiple, false);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasMultipleClass = classes.Contains("m-tabs-items");

            // Assert
            Assert.IsTrue(hasMultipleClass);
        }

        [TestMethod]
        public void RenderTabsItemsWithMax()
        {
            //Act
            var cut = RenderComponent<MTabsItems>(props =>
            {
                props.Add(tabsitems => tabsitems.Max, 24);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasMaxClass = classes.Contains("m-tabs-items");

            // Assert
            Assert.IsTrue(hasMaxClass);
        }

        //[TestMethod]
        //public void RenderTabsItemsWithMultiple()
        //{
        //    //Act
        //    var cut = RenderComponent<MTabsItems>(props =>
        //    {
        //        props.Add(tabsitems => tabsitems.Reverse, false);
        //    });
        //    var classes = cut.Instance.CssProvider.GetClass();
        //    var hasMultipleClass = classes.Contains("m-tabs-items");

        //    // Assert
        //    Assert.IsTrue(hasMultipleClass);
        //}
    }
}