using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Automaten.Products //Admin and Customer: same solution but different projects
{
    internal abstract class Product 
    {
        //property - SNack and beverage share : productName and price - therefore a superclass; Product
        private string productName;
        private int price;

        //encapsulation
        protected internal string ProductName { get { return productName; } set { productName = value; } }
        protected internal int Price { get { return price; } set { price = value; } }

        //constructor
        public Product(string productName, int price)
        {
            this.productName = productName;
            this.price = price;
        }

        //override tostring
        public override string ToString()
        {
            return productName;
        }

        //makes a abstract method that the subclasses can initiate and override the method
        protected internal abstract void GetProperties();
    }
}