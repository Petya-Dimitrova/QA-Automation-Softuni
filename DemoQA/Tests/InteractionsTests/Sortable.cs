using DemoQA.Pages.InteractionsPages.Sortable;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DemoQA.Tests.InteractionsTests
{
    [TestFixture]
    public class Sortable :BaseTest
    {
        private SortablePage _sortablePage;

        [SetUp]
        public void Setup()
        {
            Initialize();
            _sortablePage = new SortablePage(Driver);
            _sortablePage.NavigateTo();

        }

        [Test]
        public void OptionPlaceIsSwitch_When_DragAndDropUnderOtherOption()
        {
            var index = 1;

            Builder.DragAndDropToOffset(_sortablePage.ListOfOption[index], 0, 50).Perform();

            _sortablePage.AsserChangedElements("Two", _sortablePage.ListOfOption[index + 1].Text);
        }

        [Test]
        public void OptionPlaceIsSwitch_When_DragAndDropOverOtherOption()
        {
            var index = 4;

            Builder.DragAndDropToOffset(_sortablePage.ListOfOption[index], 100, 50).Perform();

            _sortablePage.AsserChangedElements("Five", _sortablePage.ListOfOption[index + 1].Text);
        }

        [Test]
        public void AllOptionsAreOrdered_When_DragAndDropSingleOption()
        {
            Builder.DragAndDropToOffset(_sortablePage.ListOfOption[3], 150, 100).Perform();

            Assert.IsTrue(_sortablePage.ListOfOption.All(o => o.Location.X == _sortablePage.Container.Location.X));
        }

        [TearDown]
        public void TearDown()
        {
             if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                string path = Path.GetFullPath(@"..\..\..\", Directory.GetCurrentDirectory());
                var screenshot = ((ITakesScreenshot)Driver).GetScreenshot();
                screenshot.SaveAsFile($@"{path}jpeg",ScreenshotImageFormat.Jpeg);
            }

            Driver.Quit();
        }
    }
}
