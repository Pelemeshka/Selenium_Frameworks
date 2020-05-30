using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Test_Homework_5.tests
{
    public class BaseTests
    {
        protected IWebDriver driver;

        [OneTimeSetUp]      //Открытие страницы перед выполнением всех тестов.
        public void BeforeTestSuit()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http:\\localhost:5000");
            driver.Manage().Window.Maximize();
        }

        [OneTimeTearDown]       //Закрытие страницы после выполнения всех тестов.
        public void AfterTestSuit()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
