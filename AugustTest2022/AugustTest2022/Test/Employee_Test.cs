using AugustTest2022.Pages;
using AugustTestNunit.Pages;
using AugustTestNunit.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AugustTestNunit.Test
{
    [TestFixture]
    [Parallelizable]
    public class Employee_Test : CommonDriver
    {
        [SetUp]
        public void LoginActions()
        {
            //Open Chrome Browser
            driver = new ChromeDriver();

            // Login page object initialization and definition
            LogInPage LoginPageObj = new LogInPage();
            LoginPageObj.logInSteps(driver);

            //Home page object initialization and definition
            HomePage HomePageObj = new HomePage();
            HomePageObj.GoToEmlpoyeePage(driver);

        }
        [Test, Order(1)]
        public void CreateEmployee()
        {
            EmployeePage EmployeePageObj = new EmployeePage();
            EmployeePageObj.CreateEmployee(driver);
        }
        
        [Test, Order(2)]
        public void EditEmployee()
        {
            EmployeePage EmployeePageobj = new EmployeePage();
            EmployeePageobj.EditEmployee(driver);
        }
        
        [Test, Order(3)]
        public void DeleteEmployee()
        {
            EmployeePage employeePageobj = new EmployeePage();
            employeePageobj.Delete(driver);
        }
       
        [TearDown]
        public void CloseTest()
        {
            driver.Quit();
        }

        
    }
}
