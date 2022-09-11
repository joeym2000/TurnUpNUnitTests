using AugustTest2022.Utilities;
using AugustTestNunit.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AugustTest2022.Pages
{
    public class TMPage :CommonDriver
    {
        public void CreateTM(IWebDriver driver)
        {
            //click on create new
            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\'container\']/p/a"));
            createNewButton.Click();

            //Click on the drop down button and select time 
            IWebElement dropDownButton = driver.FindElement(By.XPath("//*[@id=\'TimeMaterialEditForm\']/div/div[1]/div/span[1]/span/span[2]"));
            dropDownButton.Click();
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]", 3);
            IWebElement timeText = driver.FindElement(By.XPath("//*[@id=\'TypeCode_listbox\']/li[2]"));
            timeText.Click();

            //input code
            IWebElement newCode = driver.FindElement(By.Id("Code"));
            newCode.SendKeys("Marcos");
            Thread.Sleep(2000);

            //input description
            IWebElement newDescription = driver.FindElement(By.Id("Description"));
            newDescription.SendKeys("Magnanakaw");

            //input price
            IWebElement newPricePerUnit = driver.FindElement(By.XPath("//*[@id=\'TimeMaterialEditForm\']/div/div[4]/div/span[1]/span/input[1]"));
            newPricePerUnit.SendKeys("203");

            //Save time and material
            IWebElement saveTimeAndMaterial = driver.FindElement(By.Id("SaveButton"));
            saveTimeAndMaterial.Click();
            Thread.Sleep(1000);

            //check if record is created successfully
            IWebElement lastPageButton = driver.FindElement(By.XPath("//*[@id=\'tmsGrid\']/div[4]/a[4]"));
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//*[@id=\'tmsGrid\']/div[4]/a[4]", 3);
            lastPageButton.Click();
            IWebElement newCodeName = driver.FindElement(By.XPath("//*[@id=\'tmsGrid\']/div[3]/table/tbody/tr[last()]/td[1]"));
            Assert.That(newCodeName.Text == "Marcos", "Can't Find Record");

        }

        public void EditTM(IWebDriver driver)
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//*[@id=\'tmsGrid\']/div[4]/a[4]", 3);
            IWebElement lastPageButton = driver.FindElement(By.XPath("//*[@id=\'tmsGrid\']/div[4]/a[4]"));
            lastPageButton.Click();
            // Click on edit button
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]", 3);
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            editButton.Click();
            IWebElement dropDownButton = driver.FindElement(By.XPath("//*[@id=\'TimeMaterialEditForm\']/div/div[1]/div/span[1]/span/span[2]"));
            dropDownButton.Click();
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]", 3);
            IWebElement timeText = driver.FindElement(By.XPath("//*[@id=\'TypeCode_listbox\']/li[2]"));
            timeText.Click();
            
            // Edit Code

            IWebElement editedCode = driver.FindElement(By.Id("Code"));
            editedCode.Clear();
            editedCode.SendKeys("Miso");


            // Edit Description
            IWebElement editedDescription = driver.FindElement(By.Id("Description"));
            editedDescription.Clear();
            editedDescription.SendKeys("Charlie");

            //Edit Price per unit
            IWebElement editedPrice = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            editedPrice.SendKeys("14");

            // Save edited TM Page

            //Save time and material
            IWebElement saveEditedTimeAndMaterial = driver.FindElement(By.Id("SaveButton"));
            saveEditedTimeAndMaterial.Click();
            Thread.Sleep(3000);

            // Check if record is edited
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//*[@id=\'tmsGrid\']/div[4]/a[4]", 5);
            IWebElement lastPageButton2 = driver.FindElement(By.XPath("//*[@id=\'tmsGrid\']/div[4]/a[4]"));
            lastPageButton2.Click();
            IWebElement newEditedCode = driver.FindElement(By.XPath("//*[@id=\'tmsGrid\']/div[3]/table/tbody/tr[last()]/td[1]"));
            if (newEditedCode.Text == "Miso")
            {
                Console.WriteLine("Record Successfully Edited");
            }
            else
            {

            }
            {
                Console.WriteLine("Can't Find Record");
            }

        }

        public void DeleteTM(IWebDriver driver)
        {

            // Delete time record
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]", 3);
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            deleteButton.Click();
            driver.SwitchTo().Alert().Accept();
        }
    }
}
