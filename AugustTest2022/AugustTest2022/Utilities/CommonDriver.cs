using AugustTestNunit.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AugustTestNunit.Utilities
{
    public class CommonDriver
    {
        public static IWebDriver driver;
        public void CreateEmployee()
        {
            EmployeePage EmployeePageObj = new EmployeePage();
            EmployeePageObj.CreateEmployee(driver);
        }
    }
}
