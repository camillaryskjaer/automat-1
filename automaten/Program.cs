using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics; //,makes it possible to call the Admin project

namespace Automaten.Products
{
    public class Program //Admin and Customer: same solution but different projects
    {

        static void Main(string[] args)



        {
            /*Methods: The customer can see the selection
             The customer gets instructions regarding if he/she has paid the right amount
            The customer has 15 seconds to regret */

            ViewForCustomer.DisplayCustomerSelection();
            CustomerPayment.MoneyCustomer();
            CustomerPayment.Regret();

        }
    }
}
 
