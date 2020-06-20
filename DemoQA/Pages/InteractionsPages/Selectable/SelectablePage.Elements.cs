using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoQA.Pages.InteractionsPages.Selectable
{
    public partial class SelectablePage : BasePage
    {
        public IWebElement TheSlowestElementOnPage => Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class='Advertisement-Section']")));

        public IWebElement LastBox => Wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div/div/div/div[2]/div[2]/div[1]/div/div[1]/ul/li[4]")));

        public IWebElement List => Wait.Until(ExpectedConditions.ElementExists(By.Id("verticalListContainer")));

        public List<IWebElement> ListOptions => Driver.FindElements(By.XPath("//ul[@id='verticalListContainer']//li")).ToList();
    }
}
