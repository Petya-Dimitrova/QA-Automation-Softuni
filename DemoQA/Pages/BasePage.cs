using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

namespace DemoQA.Pages
{
    public class BasePage
    {
        public BasePage(IWebDriver driver)
        {
            Driver = driver;

            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            Builder = new Actions(Driver);
          //  Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
        }
        

        public void NavigateTo()
        {
            Driver.Navigate().GoToUrl(Url);
        }


        public IWebDriver Driver { get;}

        public WebDriverWait Wait { get; }

        public Actions Builder { get; }

        public virtual string Url { get; }


        public IWebElement ScrollTo(IWebElement element)
        {
            ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
            return element;
        }

        public void WaitForLoad(int timeoutSec = 15)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            WebDriverWait wait = new WebDriverWait(Driver, new TimeSpan(0, 0, timeoutSec));
            wait.Until(wd => js.ExecuteScript("return document.readyState").ToString() == "complete");
        }

    }
}
