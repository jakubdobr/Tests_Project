using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumC_Tutorials
{
    [TestFixture]
    public class OrderSkipAttribute
    {
        [Test,Order(2), Category("OrderSkipAttribute")]
        public void TestMethod1()
        {
            Assert.Ignore("Defect 12345");
            new DriverManager().SetUpDriver(new ChromeConfig());
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.facebook.com";
            IWebElement emailTestField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTestField.SendKeys("Selenium C#");
            driver.Quit();
        }

        [Test,Order(1), Category("OrderSkipAttribute")]
        public void TestMethod2()
        {
            new DriverManager().SetUpDriver(new FirefoxConfig());
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://www.facebook.com";
            IWebElement emailTestField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTestField.SendKeys("Selenium C#");
            driver.Quit();
        }

        [Test,Order(0), Category("OrderSkipAttribute")]
        public void TestMethod3()
        {
            new DriverManager().SetUpDriver(new EdgeConfig());
            IWebDriver driver = new EdgeDriver();
            driver.Url = "https://www.facebook.com";
            IWebElement emailTestField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTestField.SendKeys("Selenium C#");
            driver.Quit();
        }
    }
}
