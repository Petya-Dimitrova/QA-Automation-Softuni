using DemoQA.Pages.InteractionsPages.Droppable;
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
    public class Droppable : BaseTest
    {
        private DroppablePage _droppablePage;

        [SetUp]
        public void Setup()
        {
            Initialize();
            _droppablePage = new DroppablePage(Driver);
            _droppablePage.NavigateTo();

        }

        [Test]
        public void DropElementChangeColorOfTarget_When_DragAndDropDragMe()
        {
            var colorBefore = _droppablePage.TargetBox.GetCssValue("background-color");

            Builder.DragAndDrop(_droppablePage.SourceBox, _droppablePage.TargetBox).Perform();
            var colorAfter = _droppablePage.TargetBox.GetCssValue("background-color");

            _droppablePage.AssertColorChanged(colorBefore, colorAfter);
        }


        [Test]
        public void ElementChengedColor_When_MoveElementToTarget()
        {
            _droppablePage.SourceBox.Click();

            Builder.DragAndDrop(_droppablePage.SourceBox, _droppablePage.TargetBox).Perform();
            var colorAfter = _droppablePage.TargetBox.GetCssValue("background-color");

            _droppablePage.AssertExactColor("rgba(70, 130, 180, 1)", colorAfter);
        }

        [Test]
        public void SourseBoxPositionChanged_When_MoveSourseBoxToTargetBox()
        {
            var sourcePosXBefore = _droppablePage.SourceBox.Location.X;
            var sourcePosYBefore = _droppablePage.SourceBox.Location.Y;

            Builder.DragAndDrop(_droppablePage.SourceBox, _droppablePage.TargetBox).Perform();
            var sourcePosXAfter = _droppablePage.SourceBox.Location.X;
            var sourcePosYAfter = _droppablePage.SourceBox.Location.Y;

            _droppablePage.AssertPositionChanged(sourcePosXBefore, sourcePosXAfter);
            _droppablePage.AssertPositionChanged(sourcePosYBefore, sourcePosYAfter);
        }

        [Test]
        public void SourseBoxPositionChanged_When_MoveSourseBoxToOffset()
        {
            _droppablePage.SourceBox.Click();

            Builder.DragAndDropToOffset(_droppablePage.SourceBox, 301, 47).Perform();
            var sourcePosXAfter = _droppablePage.SourceBox.Location.Y;
            var sourcePosYAfter = _droppablePage.SourceBox.Location.Y;

            _droppablePage.AssertExactPosition(880d, sourcePosXAfter, 5);
            _droppablePage.AssertExactPosition(349d, sourcePosYAfter, 5);
        }

        [TearDown]
        public void TearDown()
        {

            Driver.Quit();
        }
    }
}
