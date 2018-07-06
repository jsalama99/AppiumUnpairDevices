using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace AppiumSample3.PagesObjects
{
    public class ConnectionSettingsPage
    {
        private IWebDriver _driver;

        public ConnectionSettingsPage(IWebDriver driver)
        {
            this._driver = driver;

            WebDriverWait wait = new WebDriverWait(_driver, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@text='Bluetooth']")));

            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@text='Bluetooth']")]
        private IWebElement BluetoothSettings;

        public BluetoothSettingsPage GotoBluetoothSettings()
        {
            try
            {
                BluetoothSettings.Click();
            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine(e);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return new BluetoothSettingsPage(_driver);
        }

    }
}
