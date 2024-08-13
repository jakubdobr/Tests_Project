using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumC_Tutorials.BaseClass;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager;


namespace SeleniumC_Tutorials
{
    public class Tests : BaseTest
    {

        [Test, Category("Smoke Testing")]
        public void Test1()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            IWebElement createAccountButton = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("[data-testid='open-registration-form-button']")));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", createAccountButton);
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", createAccountButton);

            IWebElement emailTestField = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//*[@id='email']")));
            emailTestField.SendKeys("Selenium C#");

            IWebElement monthDropdownList = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//*[@id='month']")));
            SelectElement element = new SelectElement(monthDropdownList);

            element.SelectByIndex(0);
            element.SelectByValue("1"); 
            element.SelectByText("mar");
        }

        [Test, Category("Regression Testing")]
        public void Test2()
        {
            IWebElement emailTestField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTestField.SendKeys("Selenium C#");
        }

        [Test, Category("Smoke Testing")]
        public void Test3()
        {
            IWebElement emailTestField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTestField.SendKeys("Selenium C#");
            Thread.Sleep(5000);
        }
    }
}
