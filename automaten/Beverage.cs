using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Automaten.Products //Admin and Customer: same solution but different projects
{
    internal class Beverage : Product
    {
        //property
        private string flavor;

        //encapsulation
        protected internal string Flavor;

        //constructor - new added: flavor
        public Beverage(string productName, int price, string flavor) : base(productName, price)
        {
            this.flavor = flavor;
        }

        //overrides
        protected internal override void GetProperties()
        {
            Console.WriteLine(this.ProductName);
            Console.WriteLine(this.Price);
            Console.WriteLine(this.Flavor);
            Console.WriteLine("");


        }

  

    }
}
