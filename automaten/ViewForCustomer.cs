using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Automaten.Products //Admin and Customer: same solution but different projects
{
   public class ViewForCustomer
    {

        //VIEW
        public static void DisplayCustomerSelection()
        {
            //ask the customer about which product the customer wanna buy
            string purchase = "";
            string purchaseChoice = "";
            Console.WriteLine("Ønsker du at købe en vare fra automaten?, Skriv ja eller nej");
            purchase = Console.ReadLine().ToUpper();
            // Validation for user input.
            while (purchase != "JA" && purchase != "NEJ")
            {
                Console.Write("Du skal skrive Ja eller Nej ");
                purchase = Console.ReadLine().ToUpper();
            }
            Console.WriteLine("Vil du købe en 'Coca Cola', 'Matadormix', 'Chips' eller 'Kildevand'?");
            purchaseChoice = Console.ReadLine().ToUpper();
            while (purchaseChoice != "COCA COLA" && purchaseChoice != "MATADORMIX" && purchaseChoice != "CHIPS" && purchaseChoice != "KILDEVAND")
            {
                Console.Write("Du skal skrive 'Coca Cola', 'Matadormix', 'Chips' eller 'Kildevand'");
                purchaseChoice = Console.ReadLine().ToUpper();
            }
            Console.WriteLine("Du har valgt " + purchaseChoice);
            switch (purchaseChoice)
            {
                case "COCA COLA":
                    Console.WriteLine("En coca cola koster 22 kr");




                    //method to remove product from the queue, and add it to new list
                    foreach (Soda p in SodaQueue)
                    {
                        sodadelivered.Add(p);
                        break;
                    }
                    Soda.Dequeue();

                    break;
                case "MATADORMIX":
                    Console.WriteLine("En pose matadormix koster 16 kr");

                    //method to remove product from the queue, and add it to new list
                  
                  //HVoir kommer CandyQueue fra?
                    foreach (Candy p in CandyQueue)
                    {
                        candydelivered.Add(p);
                        break;
                    }
                    Candy.Dequeue();
                    break;
                case "CHIPS":
                    Console.WriteLine("En pose chips koster 18 kr");
                    //method to remove product from the queue, and add it to new list
                    foreach (Chips p in ChupsQueue)
                    {
                        chipsdelivered.Add(p);
                        break;
                    }
                    Chips.Dequeue();
                    break;
                default:
                    Console.WriteLine("En kildevand koster 20 kr");

                    //method to remove product from the queue, and add it to new list
                    foreach (Watwe p in WaterQueue)
                    {
                        waterdelivered.Add(p);
                        break;
                    }
                    Water.Dequeue();
                    break;


                    static void SoldOut()
                    {
                        Console.WriteLine("Der er udsolgt");
                    }

                  //HVad er det du laver her?
                     static void Change() => Console.WriteLine("Du får penge tilbage");
            }


        }
           





        






}
}
