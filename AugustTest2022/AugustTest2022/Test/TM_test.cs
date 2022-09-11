using AugustTest2022.Pages;
using AugustTestNunit.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace AugustTestNunit.Test
{
    
    [TestFixture]
    [Parallelizable]

    public class TM_test : CommonDriver
    {
        HomePage HomePageObj = new HomePage(); TMPage TMPageObj = new TMPage();

        [Test,Order(1)]
        public void CreateTMTest()
        {
            //Home page object initialization and definition
          
            HomePageObj.GoToHomePage(driver);
            
            //Time And Material 
            TMPage TMPageObj = new TMPage();
            TMPageObj.CreateTM(driver);
        }
      
        [Test,Order(2)]
        public void EditTMTest()
        {
            
            HomePageObj.GoToHomePage(driver);
            //Edit TM
            
            //TMPageObj.EditTM(driver);

        }
        [Test,Order(3)]
        public void DeleteTMTest()
        {
            HomePageObj.GoToHomePage(driver);
            //Delete TM
            TMPageObj.DeleteTM(driver);
        }
       
        [TearDown]
        public void CloseTest()
        {
            driver.Quit();
        }
        
        
    }
}
