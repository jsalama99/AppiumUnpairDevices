using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AppiumSample3.PagesObjects
{
    public class PhoneSettings
    {
        private IWebDriver driver;

        public PhoneSettings(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@text='Connections']")]
        private IWebElement Connections;

        public ConnectionSettingsPage GoToConnectionsSettingsPage()
        {
            Connections.Click();
            return new ConnectionSettingsPage(driver);
        }
    }
}
