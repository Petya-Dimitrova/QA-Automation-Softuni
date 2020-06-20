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

        public PracticeFormPage(IWebDriver driver)
            : base(driver)
        {
        }

        public void FillForm(PracticeFormModel user)
        {
            FirstName.SendKeys(user.FirstName);
            LastName.SendKeys(user.LastName);
            Email.SendKeys(user.Email);
            Gender(user.Gender).Click();
            PhoneNumber.SendKeys(user.PhoneNumber);
            SportCheckBox.Click();

            ScrollTo(Submit);
            Submit.Click();

        }


    }

}
