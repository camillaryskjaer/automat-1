using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Automaten.Products.Admin //Admin and Customer: same solution but different projects
{
    internal class AddSnack 

        //it's only the admin who is allowed to add snacks and beverages. among other thins, so the customers can't determine the price.
    {     
        Product chips1 = new Snack("Chips", 18, "Salt N Pepper");
        Product chips2 = new Snack("Chips", 18, "Salt N Pepper");
        Product chips3 = new Snack("Chips", 18, "Salt N Pepper");
        Product chips4 = new Snack("Chips", 18, "Salt N Pepper");
        Product chips5 = new Snack("Chips", 18, "Salt N Pepper");
        Product chips6 = new Snack("Chips", 18, "Salt N Pepper");
        Product chips7 = new Snack("Chips", 18, "Salt N Pepper");
        Product chips8 = new Snack("Chips", 18, "Salt N Pepper");
        Product chips9 = new Snack("Chips", 18, "Salt N Pepper");
        Product chips0 = new Snack("Chips", 18, "Salt N Pepper");

        Product candy1 = new Snack("Candy", 16, "Matadormix");
        Product candy2 = new Snack("Candy", 16, "Matadormix");
        Product candy3 = new Snack("Candy", 16, "Matadormix");
        Product candy4 = new Snack("Candy", 16, "Matadormix");
        Product candy5 = new Snack("Candy", 16, "Matadormix");
        Product candy6 = new Snack("Candy", 16, "Matadormix");
        Product candy7 = new Snack("Candy", 16, "Matadormix");
        Product candy8 = new Snack("Candy", 16, "Matadormix");
        Product candy9 = new Snack("Candy", 16, "Matadormix");
        Product candy10 = new Snack("Candy", 16, "Matadormix");


        Queue<Product> Chips = new Queue<Product>();
        Queue<Product> Candy = new Queue<Product>();

        protected internal void ChipsQueue()
        {

           
            Chips.Enqueue(chips1);
            Chips.Enqueue(chips2);
            Chips.Enqueue(chips3);
            Chips.Enqueue(chips5);
            Chips.Enqueue(chips5);
            Chips.Enqueue(chips6);
            Chips.Enqueue(chips7);
            Chips.Enqueue(chips8);
            Chips.Enqueue(chips9);
            Chips.Enqueue(chips9);


        }

        protected internal void CandyQueue()
        {


            Candy.Enqueue(candy1);
            Candy.Enqueue(candy2);
            Candy.Enqueue(candy3);
            Candy.Enqueue(candy4);
            Candy.Enqueue(candy5);
            Candy.Enqueue(candy6);
            Candy.Enqueue(candy7);
            Candy.Enqueue(candy8);
            Candy.Enqueue(candy9);
            Candy.Enqueue(candy10);

        
        }

     


    }
    
}
