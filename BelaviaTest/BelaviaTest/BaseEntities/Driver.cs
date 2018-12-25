using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AirlinesTestingApp.BaseEntities
{
    public class Driver
    {
        private static IWebDriver driver;

        public static IWebDriver GetDriverInstance()
        {
            if(driver == null)
            {
                SetupChromeDriver();
            }
            return driver;
        }

        public static void SetupChromeDriver()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        public static void QuitDriver()
        {
            driver.Quit();
        }
    }
}