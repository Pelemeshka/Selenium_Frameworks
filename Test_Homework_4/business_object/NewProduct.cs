using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Homework_5.business_object
{
    class NewProduct
    {
        public string productName { get; set; }
        public string categoryId { get; set; }
        public string supplierId { get; set; }
        public string unitPrice { get; set; }
        public string quantityPerUnit { get; set; }
        public string unitsInStock { get; set; }
        public string unitsOnOrder { get; set; }
        public string reorderLevel { get; set; }
        public NewProduct (string productName, string categoryId, string supplierId, string unitPrice,
                                 string quantityPerUnit, string unitsInStock, string unitsOnOrder, string reorderLevel)
        {
            this.productName = productName;
            this.categoryId = categoryId;
            this.supplierId = supplierId;
            this.unitPrice = unitPrice;
            this.quantityPerUnit = quantityPerUnit;
            this.unitsInStock = unitsInStock;
            this.unitsOnOrder = unitsOnOrder;
            this.reorderLevel = reorderLevel;
        }


    }
}
