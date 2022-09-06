using OpenQA.Selenium;

namespace AugustTest2022.Pages
{
    public class LogInPage
    {
        public void logInSteps(IWebDriver driver)
        {
            // launch turnup portal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            driver.Manage().Window.Maximize();

            // identify username and enter valid username
            IWebElement userNameTextBox = driver.FindElement(By.Id("UserName"));
            userNameTextBox.SendKeys("Hari");

            // identify passsword and enter valid password
            IWebElement passwordTextBox = driver.FindElement(By.Id("Password"));
            passwordTextBox.SendKeys("123123");

            //identify log in button and click on it
            IWebElement logInButton = driver.FindElement(By.XPath("//*[@id=\'loginForm\']/form/div[3]/input[1]"));
            logInButton.Click();
        }
    }
}
