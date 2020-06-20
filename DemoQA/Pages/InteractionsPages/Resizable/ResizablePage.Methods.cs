using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.InteractionsPages.Resizable
{
    public partial class ResizablePage :BasePage
    {
        public ResizablePage(IWebDriver driver)
           : base(driver)
        {
        }

        public override string Url => "http://www.demoqa.com/resizable";

     
    }
}
