using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.InteractionsPages.Selectable
{
    public partial class SelectablePage :BasePage
    {
        public SelectablePage(IWebDriver driver)
           : base(driver)
        {
        }

        public override string Url => "http://www.demoqa.com/selectable";
    }
}
