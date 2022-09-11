using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//VIEW

namespace Automaten.Products.Admin //Admin and Customer: same solution but different projects
{
   public class ViewForAdmin
    {
        

       public static void DisplayAdminSelection()
        {
            string admin = "";
            string adminChoice = "";
            Console.WriteLine("Vil du først se hvor mange penge der er i automaten=");
            admin = Console.ReadLine().ToUpper();
            // Validation for admin input.
            while (admin != "JA" && admin != "NEJ")
            {
                Console.Write("Du skal skrive Ja eller Nej ");
                admin = Console.ReadLine().ToUpper();
            }


            /*Console.WriteLine(Chips.Count);
            Console.WriteLine(Soda.Count);
            Console.WriteLine(Water.Count);
            Console.WriteLine(Candy.Count); */
          

        }

      
          
          






        }











    }
}
