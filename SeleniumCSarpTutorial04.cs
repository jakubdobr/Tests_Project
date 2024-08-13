using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumC_Tutorials
{
    [TestFixture]
    public class SeleniumCSarpTutorial04
    {
        public object ScreenshotImageFormat { get; private set; }

        [Test, Author("Jakub Dobrowolski", "jakub.dobrowolski@microsoft.wsei.edu.pl")]
        [Description("Facebbok login Verify")]
        [TestCaseSource("DataDrivenTesting")]

        public void Test1(string urlName)
        {
            IWebDriver driver = new ChromeDriver(@"C:\Users\pc\Desktop\SeleniumC#Tutorials\bin\Debug\net8.0");

            try
            {
                driver.Manage().Window.Maximize();
                driver.Url = "https://www.facebook.com/";
                IWebElement emailTestField = driver.FindElement(By.XPath(".//*[@id='email']"));
                emailTestField.SendKeys("Selenium C#");
            }
            catch (Exception e)
            {
                if (driver != null) 
                { 
                    ITakesScreenshot ts = driver as ITakesScreenshot;
                    Screenshot screenshot = ts.GetScreenshot();
                    screenshot.SaveAsFile(@"C:\Users\pc\Desktop\as.net\SeleniumC#Tutorials\Screenshot\Image.Jpeg");
                    Console.WriteLine(e.StackTrace);

                }
                Console.WriteLine(e.StackTrace);
                throw;
            }
            finally
            {
                if(driver!= null)
                {
                    driver.Quit();
                }
            }
        }


        [Test] 
        [Author("Jakub Dobrowolski", "jakub.dobrowolski@microsoft.wsei.edu.pl")]
        [Description("Facebbok login Verify")]

        public void Test2()
        {
            IWebDriver driver = new ChromeDriver(@"C:\Users\pc\Desktop\SeleniumC#Tutorials\bin\Debug\net8.0");
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.facebook.com/";
            IWebElement emailTestField = driver.FindElement(By.XPath("//input[@id='email']"));
            emailTestField.SendKeys("Selenium C#");
            driver.Quit();
        }

        static IList DataDrivenTesting()
        {
            ArrayList list = new ArrayList();
            list.Add("Https://www.facebook.com");
            list.Add("Https://www.youtube.com");
            list.Add("Https://www.gmail.com");
            return list;


        }

    }

}
