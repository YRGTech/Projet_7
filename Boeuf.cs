using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projet_7
{
    public class Boeuf : Bouf
    {
        public Boeuf(string name, int amount, string description, int percentage)
             : base(name, amount, description, percentage)
        {

        }
        public override void UseItem()
        {
            //int nb = (30 * Pikachu.atk) / 100; 
            //Pikachu.atk += nb;
            //amount--;
            Console.WriteLine($"{Amount} Boeuf left");

        }

    }
}