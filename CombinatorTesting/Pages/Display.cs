using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CombinatorTesting.Pages
{
    public class Display : Base.BaseClass
    {

        List<int> list1;
        public Display()
        {
            list1 = new List<int>();
        }
        public void DisplayTitle()
        {
            IList<IWebElement> titles = driver.FindElements(By.CssSelector("a.storylink"));

            foreach (IWebElement i in titles)
            {
                string headLines = i.Text;
                Console.WriteLine(headLines);
            }
        }
        public void DisplayPoints()
        {
            IList<IWebElement> score = driver.FindElements(By.XPath("//span[@class='score']"));

            foreach (IWebElement topic in score)
            {
                string points = topic.Text;
                string input = points;
                string[] numbers = Regex.Split(input, @"\D+");

                foreach (string value in numbers)
                {

                    if (!string.IsNullOrEmpty(value))
                    {
                        int i = int.Parse(value);
                        List<int> list1 = new List<int>();
                        list1.Add(i);
                        list1.Reverse();

                        foreach (int b in list1)
                        {
                            Console.WriteLine(b);
                        }
                    }
                }
            }
        }
        public  void DisplayTitlesAndPoints()
        {
            IList<IWebElement> titleAndPoints = driver.FindElements(By.XPath("//span[@class='score']|//td[@class='title']"));

            foreach (IWebElement i in titleAndPoints)
            {
                string headlinescore = i.Text;
                Console.WriteLine(headlinescore);
            }
        }
        public void DisplaySortPoints()
        {

            foreach (var score in driver.FindElements(By.XPath("//*[@class='score']")))
            {
                string records = score.Text;
                string input = records;
                string[] numbers = Regex.Split(records, @"\D+");
                foreach (string value in numbers)
                {
                    if (!string.IsNullOrEmpty(value))
                    {
                        int i = int.Parse(value);
                        list1.Add(i);
                        Console.WriteLine("Points: {0}", i);
                    }
                }
            }
            HighestPoint();
        }
        public void HighestPoint()
        {
            var res = list1.OrderByDescending(g => g).Take(1);
            foreach (var g in res)
            {
                Console.WriteLine("Highest Point:{0}", g);
            }
        }
    }
}
