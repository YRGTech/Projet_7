using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projet_7
{
    public class MPotion : Potion
    {
        public MPotion(string name, int amount, string description, int percentage)
             : base(name, amount, description, percentage)
        {

        }
        public override void UseItem()
        {
            //int nb = (50 * Pikachu.PVMax) / 100; 
            //Pikachu.Heal(nb)
            //amount--;
            Console.WriteLine($"{Amount} potions left");
    }
    }
}