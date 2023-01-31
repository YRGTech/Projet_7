using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projet_7
{
    public class Pangolin : Debouf
    {
        public Pangolin(string name, int amount, string description, int percentage, int duration)
             : base(name, amount, description, percentage, duration)
        {

        }
        public override void UseItem()
        {
            //int nb = (30 * Pokemon.def) / 100; 
            //Pokemon.def -= nb;
            //amount--;
            Console.WriteLine($"{Amount} Pangolin left");

        }
    }
}