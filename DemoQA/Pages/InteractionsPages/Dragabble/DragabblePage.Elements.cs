using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.InteractionsPages.Dragabble
{
    public partial class DragabblePage : BasePage
    {
        public IWebElement TheSlowestElementOnPage => Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class='Advertisement-Section']")));

        public IWebElement AxisRestrictedTab => Wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("draggableExample-tab-axisRestriction")));

        public IWebElement DraggebleBox => Wait.Until(ExpectedConditions.ElementExists(By.Id("dragBox")));

        public IWebElement onlyXBox => Wait.Until(ExpectedConditions.ElementExists(By.Id("restrictedX")));

        public IWebElement onlyYBox => Wait.Until(ExpectedConditions.ElementExists(By.Id("restrictedY")));
    }
}
