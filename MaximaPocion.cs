using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projet_7
{
    public class MaximaPocion : Potion
    {
        public MaximaPocion(string name, int amount, string description, int percentage)
             : base(name, amount, description, percentage)
        {

        }
        public override void UseItem()
        {
            //Pikachu.Heal(Pikachu.PVMax)
            //amount--;
            Console.WriteLine($"{Amount} Maxima Pocion left");

        }
    }
}