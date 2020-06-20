using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.InteractionsPages.Selectable
{
    public partial class SelectablePage :BasePage
    {
        public void AssertChangedColor(string colorBefore, string colorAfter)
        {
            Assert.IsFalse(colorBefore == colorAfter);
        }

        public void AssertExactColor(string exactColor, string color)
        {
            Assert.AreEqual(exactColor, color);
        }
    }
}
