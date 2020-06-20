using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.InteractionsPages.Sortable
{
    public partial class SortablePage :BasePage
    {
        public void AsserChangedElements(string firstElement, string secondElement)
        {
            Assert.AreEqual(firstElement, secondElement);
        }
    }
}
