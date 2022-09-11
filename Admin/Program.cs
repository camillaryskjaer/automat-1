using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten.Products.Admin //Admin and Customer: same solution but different projects
{
    public class Program
    {


        static void Main(string[] args)

        {//Display admin selection for money
            ViewForAdmin.DisplayAdminSelection();
            //let the admin empty the vendingmachine for money
            Money.EmptyVendingMachine();
            //Let the admin see the amount of each product on stack + let the admin push new products to the lists
            ListAdmin.Amounts();
        }

    }
}

