using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;
using System.Reflection;

namespace SeleniumParallelTest
{
    //Enum for browserType
    public enum BrowerType
    {
        Chrome,
        Firefox,
        IE
    }


    //Fixture for class
    [TestFixture]
    public class Hooks : Base
    {
        private BrowerType _browserType;


        public Hooks(BrowerType browser)
        {
            _browserType = browser;
        }


        [SetUp]
        public void InitializeTest()
        {
            ChooseDriverInstance(_browserType);            
        }

        private void ChooseDriverInstance(BrowerType browserType)
        {
            //var driverDir = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembl‌​y().Location);

            if (browserType == BrowerType.Chrome) {
                DesiredCapabilities cap = DesiredCapabilities.Chrome();
                cap.SetCapability("version", "");
                cap.SetCapability("platform", "LINUX");
                Driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), cap);
                Driver.Manage().Window.Maximize();
      

            } 
            else if (browserType == BrowerType.Firefox)
            {
                DesiredCapabilities cap = DesiredCapabilities.Firefox();
                cap.SetCapability("version", "");
                cap.SetCapability("platform", "LINUX");
                Driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), cap);
                Driver.Manage().Window.Maximize();
            }
        }

        [TearDown]
        public void CloseBrowser()
        {
            System.Threading.Thread.Sleep(8000);
            Driver.Quit();
        }


    }
}
