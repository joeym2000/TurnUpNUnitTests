using AugustTest2022.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AugustTest2022.Pages
{
    public class HomePage
    {
        public void GoToHomePage(IWebDriver driver)
        {
            //Create new time and material
            IWebElement administrationButton = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrationButton.Click();
            WaitHelpers.WaitToBeClickable(driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a", 3);

            // Click on time and material text
            IWebElement timeAndMaterialText = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            timeAndMaterialText.Click();
        }
        public void GoToEmlpoyeePage(IWebDriver driver)
        {
            // Create New Employee
            IWebElement administrationButton = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrationButton.Click();

            // Click on Employee Text
            IWebElement employeeText = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a"));
            employeeText.Click();
        }

        public void GoToTMPage(IWebDriver driver)
        {
            // Open Administratio Tab
            IWebElement administrationButton = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrationButton.Click();

            // Click on TM
            IWebElement TMButton = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            TMButton.Click();
        }
    }
}
