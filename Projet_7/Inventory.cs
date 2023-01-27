using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projet_7
{
    public class Inventory : Menu
    {
        public Inventory() { }

        public void openInventory()
        {
            Console.Clear();
            Console.WriteLine("This is the inventory");
        }
    }
}