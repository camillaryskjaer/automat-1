using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten.Products.Admin //Admin and Customer: same solution but different projects
{
    //VIEW
    internal class Money
    {
        //Private Variables - the amount of coins in the vending machine
        private int vendingmachineMoney;
     
        //a method where the admin can empty the vendingmachine beside from 100 kr. 
        protected void EmptyVendingMachine()
        {
            Console.WriteLine($"Du har fjernet alle mønter bortset fra 100 kr. ");
           
          
        }
    }
}
