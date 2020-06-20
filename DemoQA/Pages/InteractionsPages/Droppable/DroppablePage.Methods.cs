using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.InteractionsPages.Droppable
{
    public partial class DroppablePage :BasePage
    {
        public DroppablePage(IWebDriver driver)
           : base(driver)
        {
        }

        public override string Url => "http://www.demoqa.com/droppable";

        
    }
}
