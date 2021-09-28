using NUnit.Framework;

namespace CombinatorTesting
{
    public class Tests : Base.BaseClass
    {
        [Test]
        public void NewsHeadLines()
        {
            Pages.Display display = new Pages.Display();
            display.DisplayTitle();
            display.DisplayPoints();
            display.DisplayTitlesAndPoints();
            display.DisplaySortPoints();
        }
    }
}