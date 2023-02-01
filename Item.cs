﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static Projet_7.Inventory;

namespace Projet_7
{
    public class Item
    {
        public string Name { get; set; }
        public string Description { get; } 
        public int Amount { get;  set; }
        public int Percentage { get; }
        public virtual string Used => $"Il vous reste {Amount} objets";

        public Item(string name, int amount, string description, int percentage)
        {
            Name = name;
            Amount = amount;
            Description = description;
            Percentage = percentage;
        }

        public int usePotion(int amount, string describe, Pokemon pikachu, int percent, string name)
        {
            if (amount > 0)
            {
                amount--;
                int nb = percent * pikachu.PVMax / 100;
                pikachu.Heal(nb);
                Console.SetCursorPosition(30, 8);
                Console.Write(describe + "\nVous avez " + pikachu.PV+ "PV");
                Console.SetCursorPosition(30, 9);
                Console.Write(amount + " Potionnette left");
                System.Threading.Thread.Sleep(2500);
                Console.Clear();
                
            }
            else if (amount == 0)
            {
                Console.SetCursorPosition(30, 8);
                Console.Write("You don't have any " + name);
                System.Threading.Thread.Sleep(2500);
                Console.Clear();
                Console.SetCursorPosition(30, 8);
                Console.Write(" You idiot");
                System.Threading.Thread.Sleep(800);
                Console.Clear();

            }
            return amount;
        }
        public int useMage(int amount, string describe, Pokemon pikachu, int percent, string name)
        {
            if (amount > 0)
            {
                amount--;
                int nb = percent * pikachu.PMMax / 100;
                pikachu.PM += nb;
                Console.SetCursorPosition(30, 8);
                Console.Write(describe + "\nVous avez " + pikachu.PM + "PM");
                Console.SetCursorPosition(30, 9);
                Console.Write(amount + " " + name + " left");
                System.Threading.Thread.Sleep(2500);
                Console.Clear();

            }
            else if (amount == 0)
            {
                Console.SetCursorPosition(30, 8);
                Console.Write("You don't have any " + name);
                System.Threading.Thread.Sleep(2500);
                Console.Clear();
                Console.SetCursorPosition(30, 8);
                Console.Write(" You idiot");
                System.Threading.Thread.Sleep(800);
                Console.Clear();

            }
            return amount;
        }
        public int useBoeuf(int amount, string describe, Pokemon pikachu, int percent, string name)
        {
            if (amount > 0)
            {
                amount--;
                int nb = percent * pikachu.ATK / 100;
                pikachu.ATK += nb;
                Console.SetCursorPosition(30, 8);
                Console.Write(describe + "\nVous avez " + pikachu.ATK + "PM");
                Console.SetCursorPosition(30, 9);
                Console.Write(amount + " " + name + " left");
                System.Threading.Thread.Sleep(2500);
                Console.Clear();

            }
            else if (amount == 0)
            {
                Console.SetCursorPosition(30, 8);
                Console.Write("You don't have any " + name);
                System.Threading.Thread.Sleep(2500);
                Console.Clear();
                Console.SetCursorPosition(30, 8);
                Console.Write(" You idiot");
                System.Threading.Thread.Sleep(800);
                Console.Clear();

            }
            return amount;

            
        }
        public int useTortoise(int amount, string describe, Pokemon pikachu, int percent, string name)
        {
            if (amount > 0)
            {
                amount--;
                int nb = percent * pikachu.DEF / 100;
                pikachu.DEF += nb;
                Console.SetCursorPosition(30, 8);
                Console.Write(describe + "\nVous avez " + pikachu.DEF + "PM");
                Console.SetCursorPosition(30, 9);
                Console.Write(amount + " " + name + " left");
                System.Threading.Thread.Sleep(2500);
                Console.Clear();

            }
            else if (amount == 0)
            {
                Console.SetCursorPosition(30, 8);
                Console.Write("You don't have any " + name);
                System.Threading.Thread.Sleep(2500);
                Console.Clear();
                Console.SetCursorPosition(30, 8);
                Console.Write(" You idiot");
                System.Threading.Thread.Sleep(800);
                Console.Clear();

            }
            return amount;


        }
        public int useBat(int amount, string describe, Pokemon pikachu, int percent, string name)
        {
            if (amount > 0)
            {
                amount--;
                int nb = percent * pikachu.DEF / 100;
                pikachu.DEF += nb;
                Console.SetCursorPosition(30, 8);
                Console.Write(describe + "\nVous avez " + pikachu.DEF + "PM");
                Console.SetCursorPosition(30, 9);
                Console.Write(amount + " " + name + " left");
                System.Threading.Thread.Sleep(2500);
                Console.Clear();

            }
            else if (amount == 0)
            {
                Console.SetCursorPosition(30, 8);
                Console.Write("You don't have any " + name);
                System.Threading.Thread.Sleep(2500);
                Console.Clear();
                Console.SetCursorPosition(30, 8);
                Console.Write(" You idiot");
                System.Threading.Thread.Sleep(800);
                Console.Clear();

            }
            return amount;


        }
        public int usePangolin(int amount, string describe, Pokemon pikachu, int percent, string name)
        {
            if (amount > 0)
            {
                amount--;
                int nb = percent * pikachu.ATK / 100;
                pikachu.ATK += nb;
                Console.SetCursorPosition(30, 8);
                Console.Write(describe + "\nVous avez " + pikachu.ATK + "PM");
                Console.SetCursorPosition(30, 9);
                Console.Write(amount + " " + name + " left");
                System.Threading.Thread.Sleep(2500);
                Console.Clear();

            }
            else if (amount == 0)
            {
                Console.SetCursorPosition(30, 8);
                Console.Write("You don't have any " + name);
                System.Threading.Thread.Sleep(2500);
                Console.Clear();
                Console.SetCursorPosition(30, 8);
                Console.Write(" You idiot");
                System.Threading.Thread.Sleep(800);
                Console.Clear();

            }
            return amount;


        }



    }
}
