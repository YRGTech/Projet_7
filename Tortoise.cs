using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projet_7
{
    public class Tortoise : Bouf
    {
        public Tortoise(string name, int amount, string description, int percentage)
             : base(name, amount, description, percentage)
        {

        }
        public override void UseItem()
        {
            //int nb = (30 * Pikachu.def) / 100; 
            //Pikachu.def += nb;
            //amount--;
            Console.WriteLine($"{Amount} Tortoise left");

        }
    }
}