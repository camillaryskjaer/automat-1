using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Automaten.Products //Admin and Customer: same solution but different projects

    //inheriage from the Product class
internal class Snack : Product
    {

        //property - new thing added in Snack: Type. To describe type of chips and type of candy
        private string type;

        //encapsulation 
        protected internal string Type;

        //constructor
        public Snack(string productName, int price, string type) : base(productName, price)
        {
            this.type = type;
        }

    //override from superclass

        protected internal override void GetProperties()
        {
            Console.WriteLine(this.ProductName);
            Console.WriteLine(this.Price);
            Console.WriteLine(this.Type);
            Console.WriteLine("");


        }
    }
}