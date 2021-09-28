using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Configuration;

namespace CombinatorTesting.Base
{
    public class BaseClass
    {
        public static IWebDriver driver;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Url = "https://news.ycombinator.com/news";
        }
        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}
