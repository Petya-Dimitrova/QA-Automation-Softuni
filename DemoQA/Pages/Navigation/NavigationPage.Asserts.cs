using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.Navigation
{
    public partial class NavigationPage :BasePage
    {
        public void AssertCorrectTitleSection(string sectionName, IWebElement element)
        {
            Assert.AreEqual(sectionName, element.Text);
        }
    }
}
