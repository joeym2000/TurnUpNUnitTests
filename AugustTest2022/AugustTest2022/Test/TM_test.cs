using AugustTest2022.Pages;
using AugustTestNunit.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace AugustTestNunit.Test
{
    [TestFixture]
    public class TM_test : CommonDriver
    {
        [SetUp]
        public void LoginAction()
        {
            //Open Chrome Browser
            driver = new ChromeDriver();

            // Login page object initialization and definition
            LogInPage LoginPageObj = new LogInPage();
            LoginPageObj.logInSteps(driver);

            //Home page object initialization and definition
            HomePage HomePageObj = new HomePage();
            HomePageObj.GoToHomePage(driver);

        }

        [Test,Order(1)]
        public void CreateTMTest()
        {
            //Time And Material 
            TMPage TMPageObj = new TMPage();
            TMPageObj.CreateTM(driver);
        }
      
        [Test,Order(2)]
        public void EditTMTest()
        {
            //Edit TM
            TMPage TMPageObj = new TMPage();
            TMPageObj.EditTM(driver);

        }
        [Test,Order(3)]
        public void DeleteTMTest()
        {
            //Delete TM
            TMPage TMPageObj = new TMPage();
            TMPageObj.DeleteTM(driver);
        }
       
        [TearDown]
        public void CloseTest()
        {
            driver.Quit();
        }
        
        
    }
}
