using System;
using AppiumSample3.PagesObjects;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;

namespace AppiumSample3
{
    class Program
    {
        public static AppiumDriver<AndroidElement> driver;

        static void Main(string[] args)
        {
            DesiredCapabilities capabilities = new DesiredCapabilities();
            capabilities.SetCapability("deviceName", "QAappsS7");
            capabilities.SetCapability("platformName", "Android");
            capabilities.SetCapability("platformVersion", "7.0");
            capabilities.SetCapability("automationName", "uiautomator2");
            capabilities.SetCapability("appPackage", "com.android.settings");
            capabilities.SetCapability("appActivity", "com.android.settings.Settings");


            driver = new AndroidDriver<AndroidElement>(new Uri("http://localhost:4723/wd/hub"), capabilities);
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(15));

            // AndroidElement element = driver.FindElementsById("android:id/title").First(iw => iw.Text.Equals("Notifications"));

            PhoneSettings phoneSettings = new PhoneSettings(driver);
            phoneSettings.GoToConnectionsSettingsPage();

            ConnectionSettingsPage connectionSettingsPage = new ConnectionSettingsPage(driver);
            connectionSettingsPage.GotoBluetoothSettings();

            BluetoothSettingsPage bluetoothSettingsPage = new BluetoothSettingsPage(driver);
            bluetoothSettingsPage.UnpairAllDevices();

            Console.ReadLine();
        }
    }
}
