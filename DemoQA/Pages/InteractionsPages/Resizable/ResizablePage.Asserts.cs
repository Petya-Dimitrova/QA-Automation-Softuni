using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.InteractionsPages.Resizable
{
    public partial class ResizablePage :BasePage
    {
        public void AssertExactPosition(double exactPosition, double element, int delta)
        {
            Assert.AreEqual(exactPosition, element, 3);
            Assert.AreEqual(exactPosition, element, 3);
        }

        public void AssertPosition(double container, double resizeBox)
        {
            Assert.AreEqual(container, resizeBox);
            Assert.AreEqual(container, resizeBox);
        }

    }
}
