using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.PracticeForm
{
    public class PracticeFormSection :BasePage
    {
        public PracticeFormSection(IWebDriver driver)
            :base(driver)
        {

        }


        public IWebElement Message =>Driver.FindElement(By.Id("example-modal-sizes-title-lg"));
    }
}
