using NUnit.Framework;

namespace DemoQA.Pages.InteractionsPages.Droppable
{
    public partial class DroppablePage :BasePage
    {
        public void AssertColorChanged(string colorBefore, string colorAfter)
        {
            Assert.AreNotEqual(colorBefore, colorAfter);
        }

        public void AssertExactColor(string exactColor, string colorAfter)
        {
            Assert.AreEqual(exactColor, colorAfter);
        }

        public void AssertPositionChanged(double positionBefore, double positionAfter)
        {
            Assert.AreNotEqual(positionBefore, positionAfter);
        }

        public void AssertExactPosition(double exactPosition, double position, int delta)
        {
            Assert.AreEqual(exactPosition, position, delta);
        }
    }
}
