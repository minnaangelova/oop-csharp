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
        public bool Save()
        {
            //code that saves the defined product\
            return true;
        }

    }
}
