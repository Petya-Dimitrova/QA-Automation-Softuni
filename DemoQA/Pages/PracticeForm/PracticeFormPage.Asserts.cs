using DemoQA.Models;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using FindsByAttribute = SeleniumExtras.PageObjects.FindsByAttribute;
using How = SeleniumExtras.PageObjects.How;

namespace DemoQA.Pages.PracticeForm
{
    public partial class PracticeFormPage : BasePage
    {
       
        public void  AssertErrorBorderColor(IWebElement element)
        {
            this.WaitForLoad();
            Assert.AreEqual(("rgb(209, 176, 184"),element.GetCssValue("border-color"));
        }

        public void AssertSuccessBorderColor(IWebElement element)
        {
            this.WaitForLoad();
            Assert.AreEqual(("rgb(40, 167, 69"),element.GetCssValue("border-color"));
        }


    }

}
