using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projet_7
{
    public class Mage : Bouf
    {

        public Mage(string name, int amount, string description, int percentage)
             : base(name, amount, description, percentage)
        {

        }
        public override void UseItem()
        {
            //int nb = (50 * Pikachu.PMMax) / 100; 
            //Pikachu.PM += nb;
            //amount--;
            Console.WriteLine($"{Amount} Mage left");

        }

    }
}