﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;
using System.Threading.Tasks;
using Bunit;

namespace MASA.Blazor.Test.Timeline
{
    [TestClass]
    public class MTimelineTests:TestBase
    {
        [TestMethod]
        public void RendeMTimelineWithAlignTop()
        {
            //Act
            var cut = RenderComponent<MTimeline>(props =>
            {
                props.Add(timeline => timeline.AlignTop, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasAlignTopClass = classes.Contains("m-timeline--align-top");
            // Assert
            Assert.IsTrue(hasAlignTopClass);
        }

        [TestMethod]
        public void RendeMTimelineWithDense()
        {
            //Act
            var cut = RenderComponent<MTimeline>(props =>
            {
                props.Add(timeline => timeline.Dense, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasDenseClass = classes.Contains("m-timeline--dense");
            // Assert
            Assert.IsTrue(hasDenseClass);
        }

        [TestMethod]
        public void RendeMTimelineWithReverse()
        {
            //Act
            var cut = RenderComponent<MTimeline>(props =>
            {
                props.Add(timeline => timeline.Reverse, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasReverseClass = classes.Contains("m-timeline--reverse");
            // Assert
            Assert.IsTrue(hasReverseClass);
        }

        [TestMethod]
        public void RenderTimelineWithDark()
        {
            //Act
            var cut = RenderComponent<MTimeline>(props =>
            {
                props.Add(timeline => timeline.Dark, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasDarkClass = classes.Contains("theme--dark");

            // Assert
            Assert.IsTrue(hasDarkClass);
        }

        [TestMethod]
        public void RenderTimelineWithLight()
        {
            //Act
            var cut = RenderComponent<MTimeline>(props =>
            {
                props.Add(timeline => timeline.Light, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasLightClass = classes.Contains("theme--light");

            // Assert
            Assert.IsTrue(hasLightClass);
        }
    }
}
