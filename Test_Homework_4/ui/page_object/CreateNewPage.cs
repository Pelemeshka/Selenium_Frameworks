using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using Test_Homework_5.business_object;

namespace Test_Homework_5
{
    class CreateNewPage
    {
        private IWebDriver driver;

        public CreateNewPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement productNameField => driver.FindElement(By.Id("ProductName"));
        private IWebElement categoryIDField => driver.FindElement(By.Id("CategoryId"));
        private IWebElement supplierIDField => driver.FindElement(By.Id("SupplierId"));
        private IWebElement unitPriceField => driver.FindElement(By.Id("UnitPrice"));
        private IWebElement quantityPerUnitField => driver.FindElement(By.Id("QuantityPerUnit"));
        private IWebElement unitsInStockField => driver.FindElement(By.Id("UnitsInStock"));
        private IWebElement unitsOnOrderField => driver.FindElement(By.Id("UnitsOnOrder"));
        private IWebElement reorderLevelField => driver.FindElement(By.Id("ReorderLevel"));
        private IWebElement sendCreateNewButton => driver.FindElement(By.CssSelector(".btn"));

        // Метод заполняет поля нового продукта на странице Create New и нажимает кнопку "Отправить"
        public CreateNewPage CreateNewProduct(NewProduct product)
        {
            new Actions(driver).Click(productNameField).SendKeys(product.productName).Build().Perform();
            var selectElement = new SelectElement(categoryIDField);
            selectElement.SelectByText(product.categoryId);
            selectElement = new SelectElement(supplierIDField);
            selectElement.SelectByText(product.supplierId);
            new Actions(driver).Click(unitPriceField).SendKeys(product.unitPrice).Build().Perform();
            new Actions(driver).Click(quantityPerUnitField).SendKeys(product.quantityPerUnit).Build().Perform();
            new Actions(driver).Click(unitsInStockField).SendKeys(product.unitsInStock).Build().Perform();
            new Actions(driver).Click(unitsOnOrderField).SendKeys(product.unitsOnOrder).Build().Perform();
            new Actions(driver).Click(reorderLevelField).SendKeys(product.reorderLevel).Build().Perform();
            new Actions(driver).Click(sendCreateNewButton).Build().Perform();
            return new CreateNewPage(driver);
        }
    }
}
