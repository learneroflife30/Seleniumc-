using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using WebDriverManager.DriverConfigs.Impl;


namespace Selenium_Automation
{
  public class SeleniumFirst
    {

        IWebDriver driver;

        [SetUp]
        public void startbrowser()
        {

           Console.WriteLine("How to invoke browser explained below");
           new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
           driver = new ChromeDriver();
        }

        [Test]
        public void test()
        { 

            driver.Url = "https://www.google.com/";


        }

        [Test]
        public void test2()
        {
            driver.Url = "https://stackoverflow.com/";
            String url = driver.Url;
            String pagetitle = driver.Title;
            Console.WriteLine(url);
            Console.WriteLine(pagetitle);
        

        }

        [TearDown]
        public void stopbrowser()
        {

            driver.Close();

        }
    }
}
