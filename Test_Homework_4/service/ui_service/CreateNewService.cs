using OpenQA.Selenium;
using Test_Homework_5.business_object;

namespace Test_Homework_5.service.ui_service
{
    class CreateNewService
    {
        public static CreateNewPage InputProduct (NewProduct product, IWebDriver driver)// Метод ввода нового продукта.
        {
            HomePage homePage = new HomePage(driver);
            AllProductsPage allProductsPage = homePage.HomePageToAllProductsPage(); // Открываем страницу All Products
            CreateNewPage InputProduct = allProductsPage.createNewPage();    // Открываем страницу Create New
            return InputProduct.CreateNewProduct(product);
        }
    }
}
