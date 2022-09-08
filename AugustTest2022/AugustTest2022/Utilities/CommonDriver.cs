using AugustTest2022.Pages;
using AugustTestNunit.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AugustTestNunit.Utilities
{
    public class CommonDriver
    {
        public IWebDriver driver;
        [SetUp]
        public void LoginAction()
        {
            //Open Chrome Browser
            driver = new ChromeDriver();

            // Login page object initialization and definition
            LogInPage LoginPageObj = new LogInPage();
            LoginPageObj.logInSteps(driver);

        }
    }
}