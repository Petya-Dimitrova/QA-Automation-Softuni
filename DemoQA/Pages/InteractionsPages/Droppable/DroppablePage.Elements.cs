using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.InteractionsPages.Droppable
{
    public partial class DroppablePage :BasePage
    {
        public IWebElement TheSlowestElementOnPage => Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class='Advertisement-Section']")));

        public IWebElement SourceBox => Wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("draggable")));

        public IWebElement TargetBox => Wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("droppable")));

        

       
    }
}
