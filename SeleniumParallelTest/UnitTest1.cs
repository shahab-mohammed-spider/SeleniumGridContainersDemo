using NUnit.Framework;
using OpenQA.Selenium;

namespace SeleniumParallelTest
{
    [TestFixture]
    [Parallelizable]
    public class FirefoxTesting : Hooks
    {
        public FirefoxTesting() : base(BrowerType.Firefox)
        {

        }

        [Test]
        public void FirefoxGoogleTest()
        {
            Driver.Navigate().GoToUrl("http://www.google.com");
            IWebElement a = Driver.FindElement(By.Name("q"));
                a.SendKeys("SpiderLogic");
            a.SendKeys(Keys.Enter);
            System.Threading.Thread.Sleep(5000);
            //Driver.FindElement(By.Name("btnK")).Click();
           //Assert.That(Driver.PageSource.Contains("spiderlogic"), Is.EqualTo(true),
           //                                 "The text spiderlogic doest not exist");

        }
    }


    [TestFixture]
    [Parallelizable]
    public class ChromeTesting : Hooks
    {
        public ChromeTesting() : base(BrowerType.Chrome)
        {
        }

        [Test]
        public void ChromeGoogleTest()
        {

            Driver.Navigate().GoToUrl("http://www.google.com");
            Driver.FindElement(By.Name("q")).SendKeys("SpiderLogic");
            Driver.FindElement(By.Name("btnK")).Click();
            //Assert.That(Driver.PageSource.Contains("spiderlogic"), Is.EqualTo(true),
            //                                "The text spiderlogic doest not exist");

        }
    }
    [TestFixture]
    [Parallelizable]
    public class FirefoxTesting2 : Hooks
    {
        public FirefoxTesting2() : base(BrowerType.Firefox)
        {

        }

        [Test]
        public void FirefoxGoogleTest2()
        {
            Driver.Navigate().GoToUrl("http://www.google.com");
            IWebElement a = Driver.FindElement(By.Name("q"));
            a.SendKeys("Wipfli");
            a.SendKeys(Keys.Enter);
            System.Threading.Thread.Sleep(5000);
            //Driver.FindElement(By.Name("btnK")).Click();
            //Assert.That(Driver.PageSource.Contains("spiderlogic"), Is.EqualTo(true),
            //                                 "The text spiderlogic doest not exist");

        }
    }


    [TestFixture]
    [Parallelizable]
    public class ChromeTesting2 : Hooks
    {
        public ChromeTesting2() : base(BrowerType.Chrome)
        {
        }

        [Test]
        public void ChromeGoogleTest2()
        {

            Driver.Navigate().GoToUrl("http://www.google.com");
            Driver.FindElement(By.Name("q")).SendKeys("Wipfli");
            Driver.FindElement(By.Name("btnK")).Click();
            //Assert.That(Driver.PageSource.Contains("spiderlogic"), Is.EqualTo(true),
            //                                "The text spiderlogic doest not exist");

        }
    }
}
