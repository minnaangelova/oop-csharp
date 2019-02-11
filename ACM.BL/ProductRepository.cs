using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ACM.BL
{
    public class ProductRepository
    {
        //Retrieve one product
        public Product Retrieve (int productId)
        {
            //Create the instance of the Product class
            //Pass in the requaested Id
            Product product = new Product(productId);

            Object myObject = new Object();
            Console.WriteLine("Object: " + myObject.ToString());
            Console.WriteLine("Product: " + product.ToString());


            //Code that retrieves the defined product

            //Temporary hard coded values
            //to return a populated product
            if (productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Assorted size";
                product.CurrentPrice = 15.96m;
            }
            return product;
        }
        //saves the current product
        public bool Save(Product product)
        {
            var success = true;

            if (product.HasChanges && product.IsValid)
            {
                if (product.IsNew)
                {
                    //Call an insert stored procedure
                }
                else
                {
                    //Call an update store procedure
                }
            }
            return success;
        }
    }
}
