using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriver_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://ibe.belavia.by";

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts();

            
            driver.FindElement(By.Id("origin")).SendKeys("Минск (MSQ)");
            driver.FindElement(By.Id("destination")).SendKeys("Абакан (ABA)");

            driver.FindElement(By.ClassName("ui-datepicker-left")).Click();
            driver.FindElement(By.XPath("//*[@ui-state-default ui-state-active='28']")).Click();
            driver.FindElement(By.ClassName("ui-datepicker-right")).Click();
            driver.FindElement(By.XPath("//*[@ui-state-default ui-state-active='29']")).Click();
            driver.FindElement(By.ClassName("button btn-large btn btn-b2-green ui-corner-all")).Click();

        }
    }
}
