using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_7
{
    public class Potion : Item
    {
        public int Amount { get; set; }
        public string Name { get; set; }
        public string Description { get; }
        public int Percentage { get; }

        public Potion(string name, int amount, string description, int percentage) 
            : base(name, amount, description, percentage)
        {
            Amount= amount;
            Name= name;
            Description= description;
            Percentage= percentage;
        }
    }
}
