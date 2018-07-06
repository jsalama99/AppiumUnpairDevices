using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AppiumSample3.PagesObjects
{
    public class BluetoothSettingsPage
    {
        private IWebDriver driver;

        private const string PairedDevicesId = "com.android.settings:id/deviceDetails";

        public BluetoothSettingsPage(IWebDriver driver)
        {
            this.driver = driver;

            //WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
            //wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@text='Bluetooth']")));

            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = PairedDevicesId)]
        public IList<IWebElement> PairedDevices;

        public void UnpairAllDevices()
        {
            foreach (var pairedDeviceDetail in PairedDevices)
            {
                try
                {
                    pairedDeviceDetail.Click();
                    DeviceDetailsPage deviceDetailsPage = new DeviceDetailsPage(driver);
                    deviceDetailsPage.UnpairDevice();
                }
                catch (InvalidElementStateException ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }
    }
}
