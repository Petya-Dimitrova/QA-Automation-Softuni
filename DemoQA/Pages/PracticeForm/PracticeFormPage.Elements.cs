using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.PracticeForm
{
    public partial class PracticeFormPage : BasePage
    {

        public PracticeFormSection Popup => new PracticeFormSection(Driver);

        public IWebElement FirstName => Driver.FindElement(By.Id("firstName"));

        public IWebElement LastName => Driver.FindElement(By.Id("lastName"));

        public IWebElement Email => Driver.FindElement(By.CssSelector("#userEmail"));

        public IWebElement PhoneNumber => Driver.FindElement(By.CssSelector("#userNumber"));

        public IWebElement SportCheckBox => Driver.FindElement(By.XPath("//*[@id='hobbiesWrapper']/div[2]/div[1]/label"));

        public IWebElement Submit => Driver.FindElement(By.Id("submit"));

        public IWebElement Gender(string labelText) =>
            Driver.FindElement(By.XPath($"//*[@id='genterWrapper']//label[text()='{labelText}']"));


    }
}
