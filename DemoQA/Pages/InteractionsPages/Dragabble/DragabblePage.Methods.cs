using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.InteractionsPages.Dragabble
{
    public partial class DragabblePage :BasePage
    {
        public DragabblePage(IWebDriver driver)
            : base(driver)
        {
        }

        public override string Url => "http://www.demoqa.com/dragabble";
     
    }
}
