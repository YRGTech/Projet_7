using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_7
{
    public class Potion : Item
    {
        public Potion(string name, int amount, string description, int percentage) 
            : base(name, amount, description, percentage)
        {

        }
    }
}
