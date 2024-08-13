using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumC_Tutorials.BaseClass;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using SeleniumC_Tutorials.BaseClass.Utilities; // Dodaj tê liniê


namespace SeleniumC_Tutorials
{

    public class ParallelTesting
    {


        IWebDriver driver;

        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod1()
        {

            var Driver = new BrowerUtility().Init(driver);
            IWebElement emailTestField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTestField.SendKeys("Selenium C#");
            Driver.Quit();
        }
        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod2()
        {

            var Driver = new BrowerUtility().Init(driver);
            IWebElement emailTestField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTestField.SendKeys("Selenium C#");
            Driver.Quit();
        }
        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod3()
        {

            var Driver = new BrowerUtility().Init(driver);
            IWebElement emailTestField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTestField.SendKeys("Selenium C#");
            Driver.Quit();
        }
        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod4()
        {

            var Driver = new BrowerUtility().Init(driver);
            IWebElement emailTestField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTestField.SendKeys("Selenium C#");
            Driver.Quit();
        }
        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod5()
        {

            var Driver = new BrowerUtility().Init(driver);
            IWebElement emailTestField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTestField.SendKeys("Selenium C#");
            Driver.Quit();
        }
        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod6()
        {

            var Driver = new BrowerUtility().Init(driver);
            IWebElement emailTestField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTestField.SendKeys("Selenium C#");
            Driver.Quit();
        }
        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod7()
        {

            var Driver = new BrowerUtility().Init(driver);
            IWebElement emailTestField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTestField.SendKeys("Selenium C#");
            Driver.Quit();
        }
        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod8()
        {

            var Driver = new BrowerUtility().Init(driver);
            IWebElement emailTestField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTestField.SendKeys("Selenium C#");
            Driver.Quit();
        }
        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod9()
        {

            var Driver = new BrowerUtility().Init(driver);
            IWebElement emailTestField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTestField.SendKeys("Selenium C#");
            Driver.Quit();
        }
        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod10()
        {

            var Driver = new BrowerUtility().Init(driver);
            IWebElement emailTestField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTestField.SendKeys("Selenium C#");
            Driver.Quit();
        }


    }
}