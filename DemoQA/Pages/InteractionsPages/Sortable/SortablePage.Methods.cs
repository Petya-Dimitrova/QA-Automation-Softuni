using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.InteractionsPages.Sortable
{
   public partial class SortablePage : BasePage
    {

        public SortablePage(IWebDriver driver)
            : base(driver)
        {
        }

        public override string Url => "http://www.demoqa.com/sortable";


    }
}
