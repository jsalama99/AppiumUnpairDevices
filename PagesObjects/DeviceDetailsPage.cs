using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AppiumSample3.PagesObjects
{
    public class DeviceDetailsPage
    {
        private IWebDriver driver;

        public DeviceDetailsPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }


        [FindsBy(How = How.XPath, Using = "//*[@text='Unpair']")]
        private IWebElement UnpairButton;

        public void UnpairDevice()
        {
            UnpairButton.Click();
        }
    }
}
