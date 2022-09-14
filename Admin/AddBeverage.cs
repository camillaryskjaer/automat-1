using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//It's only the admin who is allowed to add beverages ans snacks to the vending machine

namespace Automaten.Products.Admin  //Admin and Customer: same solution but different projects
{
    internal class AddBeverage 
    {
        //Lists are Queue due to FIFO.
        // coca cola, 22 kr , original taste
        
        //HVorfor gør du ikke dette i en løkke---- = Redundans og det vil vi ikke
        Product cola1 = new Beverage("Coca Cola", 22, "Original");
        Product cola2 = new Beverage("Coca Cola", 22, "Original");
        Product cola3 = new Beverage("Coca Cola", 22, "Original");
        Product cola4 = new Beverage("Coca Cola", 22, "Original");
        Product cola5 = new Beverage("Coca Cola", 22, "Original");
        Product cola6 = new Beverage("Coca Cola", 22, "Original");
        Product cola7 = new Beverage("Coca Cola", 22, "Original");
        Product cola8 = new Beverage("Coca Cola", 22, "Original");
        Product cola9 = new Beverage("Coca Cola", 22, "Original");
        Product cola10 = new Beverage("Coca Cola", 22, "Original");

        // water, 20 kr , spaarkling.
        Product water1 = new Beverage("Kildevand", 20, "Sparkling");
        Product water2 = new Beverage("Kildevand", 20, "Sparkling");
        Product water3 = new Beverage("Kildevand", 20, "Sparkling");
        Product water4 = new Beverage("Kildevand", 20, "Sparkling");
        Product water5 = new Beverage("Kildevand", 20, "Sparkling");
        Product water6 = new Beverage("Kildevand", 20, "Sparkling");
        Product water7 = new Beverage("Kildevand", 20, "Sparkling");
        Product water8 = new Beverage("Kildevand", 20, "Sparkling");
        Product water9 = new Beverage("Kildevand", 20, "Sparkling");
        Product water10 = new Beverage("Kildevand", 20, "Sparkling");


        Queue<Product> Soda = new Queue<Product>();
        Queue<Product> Water = new Queue<Product>();

        protected internal void SodaQueue()
        {
            Soda.Enqueue(cola1);
            Soda.Enqueue(cola2);
            Soda.Enqueue(cola3);
            Soda.Enqueue(cola4);
            Soda.Enqueue(cola5);
            Soda.Enqueue(cola6);
            Soda.Enqueue(cola7);
            Soda.Enqueue(cola8);
            Soda.Enqueue(cola9);
            Soda.Enqueue(cola10);
        }

        protected internal void WaterQueue()
        {
            Water.Enqueue(water1);
            Water.Enqueue(water2);
            Water.Enqueue(water3);
            Water.Enqueue(water4);
            Water.Enqueue(water5);
            Water.Enqueue(water6);
            Water.Enqueue(water7);
            Water.Enqueue(water8);
            Water.Enqueue(water9);
            Water.Enqueue(water10);

        }


       




    }
}
