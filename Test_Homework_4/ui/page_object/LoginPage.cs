using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using Test_Homework_5.business_object;

namespace Test_Homework_5
{
    class LoginPage
    {
        private IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        
        private IWebElement loginField => driver.FindElement(By.Id("Name"));
        private IWebElement passwordField => driver.FindElement(By.Id("Password"));
        //Метод вводит логин и пароль на странице Login.
        public HomePage ResultLoginPage (User userData)
        {
            new Actions(driver).Click(loginField).SendKeys(userData.userName).Build().Perform();
            new Actions(driver).SendKeys(Keys.Enter).Build().Perform();
            new Actions(driver).Click(passwordField).SendKeys(userData.userPassword).Build().Perform();
            new Actions(driver).SendKeys(Keys.Enter).Build().Perform();
            return new HomePage(driver);
        }
        private IWebElement nameLoginPage => driver.FindElement(By.XPath("/html/body/div[1]/h2"));
        public string GetNameLoginPage()  //Метод  возвращает название страницы Login.
        {
            return nameLoginPage.Text;
        }

    }
}
