using AirlinesTestingApp.BaseEntities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Threading;

namespace AirlinesTestingApp.Pages
{
    public class HomePage
    {
        private IWebDriver driver;
        private const string Url = "https://belavia.by";
        By cookiesSet = By.Id("set_cookies");
        By oneWayTicketCheckbox = By.Id("JourneySpan_Ow");
        By leavingTicketDate = By.Id("DepartureDate_Datepicker");
        By returnTicketDate = By.Id("ReturnDate_Datepicker");
        By departure = By.Id("OriginLocation_Combobox");
        By arrival = By.Id("DestinationLocation_Combobox");
        By bookingFormSubmitButton = By.XPath("//*[@id='step - 2']/div[4]/div/button");
        By errorsMessages = By.ClassName("messages");

        private void SelectDeparture()
        {
            var placeToLeave = new SelectElement(driver.FindElement(departure));
            placeToLeave.SelectByIndex(1);//Because "zero" value is default
        }

        private void ChooseValueOfSelectTag(By selector, int index)
        {
            var selectElement = new SelectElement(driver.FindElement(selector));
            selectElement.SelectByIndex(index);//Because "zero" value is default
        }

        public HomePage()
        {
            this.driver = Driver.GetDriverInstance();
        }   

        public void OpenHomePage()
        {
            GoToUrl(Url);
        }

        public void GoToUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void CloseAds()
        {
            driver.FindElement(cookiesSet).Click();
            Thread.Sleep(1000);
        }

        public void SelectOneWayTicket()
        {
            driver.FindElement(oneWayTicketCheckbox).Click();
        }

        public IWebElement GetReturnTicketDate()
        {
            return driver.FindElement(returnTicketDate);
        }

        public IWebElement GetLeavingTicketDate()
        {
            return driver.FindElement(leavingTicketDate);
        }


        public void FillInBookingForm()
        {
            ChooseValueOfSelectTag(departure, 1);
            ChooseValueOfSelectTag(arrival, 12);

            SetDateTime(driver.FindElement(leavingTicketDate), DateTime.Now.ToString("dd'/'MM'/'yyyy"));
            SetDateTime(GetReturnTicketDate(), DateTime.Now.ToString("dd'/'MM'/'yyyy"));
        }

        public IWebElement SetDepartureAndReturnElement()
        {
            var selectElement = new SelectElement(driver.FindElement(departure));
            selectElement.SelectByIndex(1);//Because "zero" value is default
            return selectElement.SelectedOption;
        }

        public SelectElement GetArrivalAirportOptions()
        {
            return new SelectElement(driver.FindElement(arrival));
        }

        public void SetDateTime(IWebElement el, string value)
        {
            el.SendKeys(value);
            CloseDatePicker();
        }

        public IWebElement GetElement(By selector)
        {
            return driver.FindElement(selector);
        }

        public void SubmitBookingForm()
        {
            driver.FindElement(bookingFormSubmitButton).Click();
        }

        public IWebElement GetErrorMessages()
        {
            return driver.FindElement(errorsMessages);
        }
    }
}   