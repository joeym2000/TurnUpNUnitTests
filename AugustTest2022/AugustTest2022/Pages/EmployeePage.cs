using AugustTest2022.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AugustTestNunit.Pages
{
    public class EmployeePage
    {
        public void CreateEmployee(IWebDriver driver)
        {
            //Click on create new
            IWebElement createNewEmployee = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createNewEmployee.Click();

            //Input Name
            IWebElement newName = driver.FindElement(By.Id("Name"));
            newName.SendKeys("Miso");

            //Input Username
            IWebElement newUserName = driver.FindElement(By.Id("Username"));
            newUserName.SendKeys("Charliemiso");

            //Input Contact
            IWebElement newContact = driver.FindElement(By.Id("ContactDisplay"));
            newContact.SendKeys("charliemiso");

            // Enter password
            IWebElement passwordTextBox = driver.FindElement(By.Id("Password"));
            passwordTextBox.SendKeys("CharlieMisocharlie66!");
            WaitHelpers.WaitToExist(driver, "XPath", "//*[@id=\'RetypePassword\']", 5);
            IWebElement typePassword = driver.FindElement(By.XPath("//*[@id=\'RetypePassword\']"));
            typePassword.SendKeys("CharlieMisocharlie66!");

            // Enter save button
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//*[@id=\"SaveButton\"]", 5);
            IWebElement saveButton = driver.FindElement(By.XPath("//*[@id=\"SaveButton\"]"));
            saveButton.Click();

            // Check if record is created successfully
            IWebElement backToListButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/div/a"));
            backToListButton.Click();
            IWebElement lastPageButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            lastPageButton.Click();
        }

        public void EditEmployee(IWebDriver driver)
        {
            //Edit employee
            IWebElement lastPageButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            lastPageButton.Click();
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\'usersGrid\']/div[3]/table/tbody/tr[last()]/td[3]/a[1]"));
            editButton.Click();
            //Input Edited Name
            IWebElement editedName = driver.FindElement(By.Id("Name"));
            editedName.Clear();
            editedName.SendKeys("Charlie");

            //Input edited username
            IWebElement editedUserName = driver.FindElement(By.Id("Username"));
            editedUserName.Clear();
            editedUserName.SendKeys("Misocharlie");

            //Save new edited employee
            WaitHelpers.WaitToBeClickable(driver, "Id", "SaveButton", 3);
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();

            // Check if edited record is created successfully
            IWebElement backToListButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/div/a"));
            backToListButton.Click();
            IWebElement editlastpageButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            editlastpageButton.Click();
            
        }

        public void Delete(IWebDriver driver)
        {
            //Delete employee file
        }
    }
}
