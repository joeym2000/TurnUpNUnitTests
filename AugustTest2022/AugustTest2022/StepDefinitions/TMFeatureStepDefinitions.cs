using AugustTest2022.Pages;
using AugustTestNunit.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace AugustTestNunit.StepDefinitions
{
    [Binding]
    public class TMFeatureStepDefinitions : CommonDriver
    {
        LogInPage LoginPageObj = new LogInPage();
        HomePage HomePageObj = new HomePage();
        TMPage TMPageObj = new TMPage();

        [Given(@"the user log in to turn up potal succcessfully")]
        public void GivenTheUserLogInToTurnUpPotalSucccessfully()
        {
            driver = new ChromeDriver();
            LoginPageObj.logInSteps(driver);
        }

        [When(@"user navigate to time and material page")]
        public void AndUserNavigateToTimeAndMaterialPage()
        {
            HomePageObj.GoToTMPage(driver);
        }

        [When(@"user create a new time and material record")]
        public void WhenUserCreateANewTimeAndMaterialRecord()
        {
            TMPageObj.CreateTM(driver);
        }

        [Then(@"the record should be created successfully")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
            string newCode = TMPageObj.GetCode(driver);
            string newDescription = TMPageObj.GetDescription(driver);
            string newPriceperunit = TMPageObj.GetPrice(driver);

            Assert.That(newCode == "Marcos", "Can't Find Record");
            Assert.That(newDescription == "Magnanakaw", "Can't find record");
            Assert.That(newPriceperunit == "$203.00", "Can't find record");
        }
        [When(@"user update '([^']*)' existing record")]
        public void WhenUserUpdateExistingRecord(string description)
        {
            TMPageObj.EditTM(driver, description);
        }

        [Then(@"the record should have the updated '([^']*)'")]
        public void ThenTheRecordShouldHaveTheUpdated(string description)
        {
            
        }

    }
}
