using DemoQA.Pages.InteractionsPages.Selectable;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Tests.InteractionsTests
{
    [TestFixture]
    public class Selectable :BaseTest
    {
        private SelectablePage _selectablePage;

        [SetUp]
        public void Setup()
        {
            Initialize();
            _selectablePage = new SelectablePage(Driver);
            _selectablePage.NavigateTo();
        }

        [Test]
        public void SelectItemColorChange_When_SelectItem([Range(0, 3)] int index)
        {
            _selectablePage.ListOptions[index].Click();

            var listColor = _selectablePage.ListOptions[index].GetCssValue("background-color");

            _selectablePage.AssertExactColor("rgba(0, 123, 255, 1)", listColor);
        }

        [Test]
        public void CheckExactColor_When_ClickOnListItem()
        {
            _selectablePage.LastBox.Click();

            var colorAfter = _selectablePage.LastBox.GetCssValue("background-color");

            _selectablePage.AssertExactColor("rgba(0, 123, 255, 1)", colorAfter);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
