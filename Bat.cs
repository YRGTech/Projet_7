using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projet_7
{
    public class Bat : Debouf
    {
        public Bat(string name, int amount, string description, int percentage, int duration)
             : base(name, amount, description, percentage, duration)
        {

        }
        public override void UseItem()
        {
            //int nb = (30 * Pokemon.atk) / 100; 
            //Pokemon.atk -= nb;
            //amount--;
            Console.WriteLine($"{Amount} Bat left");

        }
    }
}