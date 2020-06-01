using NUnit.Framework;
using Test_Homework_5.business_object;
using Test_Homework_5.service.ui_service;
using Test_Homework_5.tests;

namespace Test_Homework_5
{
    public class Tests : BaseTests
    {
        private LoginPage loginPage;
        private HomePage homePage;
        private AllProductsPage allProductsPage;
        private CreateNewPage createNewProduct; //Для инициализации метода создания нового продукта.
        private User tester = new User("user", "user");
        private NewProduct cakePops = new NewProduct("Cake pops", "Confections", "Specialty Biscuits, Ltd.",
                               "15", "2 boxes x 7 pieces", "20", "0", "10");

        [Test]
        public void Test1_Login()   //Тест на Логин.
        {
            loginPage = new LoginPage(driver);
            homePage = loginPage.ResultLoginPage(tester);
            // Проверка на открытие страницы Home page после Логина.
            Assert.AreEqual("Home page", homePage.GetNameHomePage());   // Открыта страница Home page.
        }

        [Test]
        public void Test2_CreateProduct()   // Созданиие нового продукта.
        {
            createNewProduct = CreateNewService.InputProduct(cakePops, driver);// Создаем новый продукт.
            allProductsPage = new AllProductsPage(driver);// Инициализация новой страницы All products.
            // Проверка наличия продукта Cake pops на странице All Products
            Assert.AreEqual("Cake pops", allProductsPage.GetNameNewProduct("Cake pops"));
        }

        [Test]
        public void Test5_Logout()      // Проверка на Логаут.
        {
            loginPage = allProductsPage.AllProductsPageToLogin();
            // Проверка на открытие страницы Login  после нажатия кнопки Logout
            Assert.AreEqual("Login", loginPage.GetNameLoginPage());
        }
    }
}