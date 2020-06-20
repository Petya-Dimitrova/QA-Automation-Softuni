using DemoQA.Pages.InteractionsPages.Dragabble;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DemoQA.Tests.InteractionsTests
{
    [TestFixture]
    public class Dragabble : BaseTest
    {
        private DragabblePage _dragabblePage;

        [SetUp]
        public void Setup()
        {
            Initialize();
            _dragabblePage = new DragabblePage(Driver);
            _dragabblePage.NavigateTo();
        }

        [Test]
        public void ElementYIsSame_When_DragAndDropOnlyXDiagonally()
        {
            _dragabblePage.AxisRestrictedTab.Click();

            var yBefore = _dragabblePage.onlyXBox.Location.Y;
            Builder.DragAndDropToOffset(_dragabblePage.onlyXBox, 100, 100).Perform();
            var yAfter = _dragabblePage.onlyXBox.Location.Y;

            _dragabblePage.AssertPositionIsNotChanged(yBefore, yAfter);
        }

        [Test]
        public void ElementXIsSame_When_DragAndDropOnlyYDiagonally()
        {
            _dragabblePage.AxisRestrictedTab.Click();

            var xBefore = _dragabblePage.onlyXBox.Location.Y;
            Builder.DragAndDropToOffset(_dragabblePage.onlyYBox, 100, 100).Perform();
            var xAfter = _dragabblePage.onlyXBox.Location.Y;

            _dragabblePage.AssertPositionIsNotChanged(xBefore, xAfter);
        }

        [Test]
        public void ElementYIsNotSame_When_DragAndDropToOffset()
        {
            _dragabblePage.DraggebleBox.Click();

            var yBefore = _dragabblePage.DraggebleBox.Location.Y;
            Builder.DragAndDropToOffset(_dragabblePage.DraggebleBox, 300, 100).Perform();
            var yAfter = _dragabblePage.DraggebleBox.Location.Y;

            _dragabblePage.AssertPositionChanged(yBefore, yAfter);

        }

        [Test]
        public void ElementMovedToRightAndCheckExactPosition_When_DragAndDropToOffset()
        {
            _dragabblePage.DraggebleBox.Click();

            Builder.DragAndDropToOffset(_dragabblePage.DraggebleBox, 200, 100).Perform();

            _dragabblePage.AssertExactPosition(635d, _dragabblePage.DraggebleBox.Location.X, 5);
        }

        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                string dirPath = Path.GetFullPath(@"..\..\..\", Directory.GetCurrentDirectory());
                var screenshot = ((ITakesScreenshot)Driver).GetScreenshot();
                screenshot.SaveAsFile($"{dirPath}\\Screenshots\\{TestContext.CurrentContext.Test.FullName}.png", ScreenshotImageFormat.Png);
            }

            Driver.Quit();
        }
    }
}
