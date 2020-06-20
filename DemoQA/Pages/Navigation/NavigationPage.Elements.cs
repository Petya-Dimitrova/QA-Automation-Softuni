using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.Navigation
{
    public partial class NavigationPage :BasePage
    {
        public IWebElement InteractionButton => Driver.FindElement(By.XPath("//*[normalize-space(text())='Interactions']/ancestor::div[contains(@class, 'top-card')]"));

        public IWebElement InteractionSideBarMenu(string sectionName) =>
            Driver.FindElement(By.XPath($"//*[normalize-space(text())='{sectionName}']"));

        public IWebElement PageHeader => Driver.FindElement(By.ClassName("main-header"));
    }
}
