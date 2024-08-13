using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumC_Tutorials.BaseClass.Utilities
{
    public class BrowerUtility
    {
        public IWebDriver Init(IWebDriver driver)
        {
            driver = new ChromeDriver(@"C:\Users\pc\Desktop\as.net\SeleniumC#Tutorials");
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.facebook.com/";
            return driver;
        }

    } 
}
