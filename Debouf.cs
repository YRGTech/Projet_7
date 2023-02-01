using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_7
{
    public class Debouf : Item
    {
        int Duration { get; set; }
        public Debouf(string name, int amount, string description, int percentage, int duration)
            : base(name, amount, description, percentage)
        {
            Duration = duration;
        }

        
    }
}
