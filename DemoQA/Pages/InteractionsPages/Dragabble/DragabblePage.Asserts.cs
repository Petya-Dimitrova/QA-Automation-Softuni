using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.InteractionsPages.Dragabble
{
    public partial class DragabblePage :BasePage
    {
        public void AssertPositionChanged(int offsetX, int offsetY)
        {
            Assert.IsFalse(offsetX == offsetY);
        }

        public void AssertPositionIsNotChanged(int offsetX, int offsetY)
        {
            Assert.AreEqual(offsetX, offsetY);
        }

        public void AssertExactPosition(double position, int sourse, int delta)
        {
            Assert.AreEqual(position, sourse, delta);
        }
    }
}
