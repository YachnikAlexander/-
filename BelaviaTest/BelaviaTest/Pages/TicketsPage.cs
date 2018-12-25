using AirlinesTestingApp.BaseEntities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace AirlinesTestingApp.Pages
{
    public class TicketsPage
    {
        private IWebDriver driver;
        private const string Url = "https://ibe.belavia.by/?culture=ru";
        private By passengersInput = By.XPath("//*[@id='home']/div[2]/form/div[3]/div[2]/div/div");
        private By adultsButtonIncrement = By.XPath("//*[@id='home']/div[2]/form/div[3]/div[2]/div/div[2]/div[1]/div[3]");
        By adultsButtonDecrement = By.XPath("//*[@id='home']/div[2]/form/div[3]/div[2]/div/div[2]/div[1]/div[1]");
        By childrenButtonIncrement = By.XPath("//*[@id='home']/div[2]/form/div[3]/div[2]/div/div[2]/div[2]/div[3]");
        By errorFormContainer = By.XPath("//*[@id='edit-passengers']/div[2]");

        public By errorFormMessage = By.XPath("//*[@id='edit-passengers']/div[2]/ul/li");

        public string errorPassengersTooManyText = "5 - максимум взрослых";
        public string errorChildrenWithoutAdultsText = "4 ребенка и 1 взрослый максимум";

        public void ClickPassengersInput()
        {
            driver.FindElement(passengersInput).Click();
        }

        public IWebElement GetAdultsInput()
        {
            return driver.FindElement(adultsAmountInput);
        }

        public void ClickAdultsIncreasingButton()
        {
            driver.FindElement(adultsButtonIncrement).Click();
        }

        public void ClickAdultsIncreasingButton(int times)
        {
            for (int i = 0; i < times; i++)
            {
                driver.FindElement(adultsButtonIncrement).Click();
            }
        }

        public void ClickAdultsDecreasingButton()
        {
            driver.FindElement(adultsButtonDecrement).Click();
        }

        public void ClickAdultsDecreasingButton(int times)
        {
            for (int i = 0; i < times; i++)
            {
                driver.FindElement(adultsButtonDecrement).Click();
            }
        }

        public void ClickChildrenIncreasingButton()
        {
            driver.FindElement(childrenButtonIncrement).Click();
        }

        public void ClickChildrenIncreasingButton(int times)
        {
            for (int i = 0; i < times; i++)
            {
                driver.FindElement(childrenButtonIncrement).Click();
            }
        }

        public void InputInFieldData(int num, IWebElement element)
        {
            element.SendKeys(num.ToString());
        }

        public TicketsPage()
        {
            this.driver = Driver.GetDriverInstance();
        }

        public void OpenTicketsPage()
        {
            GoToUrl(Url);
        }

        public void GoToUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public IWebElement GetErorrsContainer()
        {
            return driver.FindElement(errorFormContainer);
        }

        public IWebElement GetElement(By selector)
        {
            return driver.FindElement(selector);
        }

        public bool Exists(By selector)
        {
            return (driver.FindElements(selector).Count != 0);
        }
    }
}   