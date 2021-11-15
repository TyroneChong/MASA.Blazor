﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bunit;
using BlazorComponent;
using Moq;
using Microsoft.AspNetCore.Components;

namespace MASA.Blazor.Test.App
{
    [TestClass]
    public class MAppTests : TestBase
    {
        [TestMethod]
        public void RenderWithChildContentt()
        {
            // Arrange & Act
            JSInterop.Mode = JSRuntimeMode.Loose;
            var cut = RenderComponent<MApp>(props =>
            {
                props.Add(app => app.ChildContent, "<span>Hello world</span>");
            });
            var contentDiv = cut.Find(".m-application--wrap");

            // Assert
            contentDiv.Children.MarkupMatches("<span>Hello world</span>");
        }

        //[TestMethod]
        //public void RendeListWithDark()
        //{
        //    //Act
        //    var cut = RenderComponent<MApp>(props =>
        //    {
        //        props.Add(listgroup => listgroup.Dark, true);
        //    });
        //    var classes = cut.Instance.CssProvider.GetClass();
        //    var hasDarkClass = classes.Contains("theme--dark");

        //    // Assert
        //    Assert.IsTrue(hasDarkClass);
        //}
    }

}