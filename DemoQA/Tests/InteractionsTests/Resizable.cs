using DemoQA.Pages.InteractionsPages.Resizable;
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
    public partial class Resizable : BaseTest
    {
        private ResizablePage _resizablePage;

        [SetUp]
        public void Setup()
        {
            Initialize();
            _resizablePage = new ResizablePage(Driver);
            _resizablePage.NavigateTo();
        }

        [Test]
        public void ElemetSizeIsMaximum_When_ResizeMoreThanMaximum()
        { 
            _resizablePage.ResizeBox.Click();

            Builder.DragAndDropToOffset(_resizablePage.ResizeArrow, 300, 100).Perform();

            _resizablePage.AssertPosition(_resizablePage.Container.Size.Height, _resizablePage.ResizeBox.Size.Height);
            _resizablePage.AssertPosition(_resizablePage.Container.Size.Width, _resizablePage.ResizeBox.Size.Width);
        }

        [Test]
        public void ElementSizeIsMinimum_When_ResizeToMinimum()
        {
            _resizablePage.ResizeBox.Click();

            Builder.DragAndDropToOffset(_resizablePage.ResizeArrow, -50, -50).Perform();

            Assert.AreEqual(150, _resizablePage.ResizeBox.Size.Height);
            Assert.AreEqual(150, _resizablePage.ResizeBox.Size.Width);

        }

        [Test]
        public void ElementHaveCorrectSize_When_ResizeWithAnyNumber([Range(99, 100)] double x, [Range(99, 100)] double y)
        {
            _resizablePage.ResizeBox.Click();

            var heightBefore = _resizablePage.Resizable.Size.Height;
            var widthBefore = _resizablePage.Resizable.Size.Width;

            Builder.DragAndDropToOffset(_resizablePage.ResizeArrow, (int)x, (int)y).Perform();

            Assert.AreEqual(heightBefore + y, _resizablePage.Resizable.Size.Height);
            Assert.AreEqual(widthBefore + x, _resizablePage.Resizable.Size.Width);

        }

        [Test]
        public void ResizeBoxSizeIsMaximum_When_ResizeMoreThanMaximum()
        {
            _resizablePage.ResizeBox.Click();

           Builder.DragAndDropToOffset(_resizablePage.ResizeArrow, 350, 150).Perform();

            _resizablePage.AssertExactPosition(899d, _resizablePage.ResizeArrow.Location.X, 5);
            _resizablePage.AssertExactPosition(516d, _resizablePage.ResizeArrow.Location.Y, 5);
        }

       
        [TearDown]
        public void TearDown()
        {
          

            Driver.Quit();
        }
    }
}
