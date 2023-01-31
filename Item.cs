using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static Projet_7.Inventory;

namespace Projet_7
{
    public class Item
    {
        public string Name { get; }
        public string Description { get; } 
        public int Amount { get; protected set; }
        public int Percentage { get; }
        public virtual string Used => $"Il vous reste {Amount} objets";

        public Item(string name, int amount, string description, int percentage)
        {
            Name = name;
            Amount = amount;
            Description = description;
            Percentage = percentage;
        }

        void useItem(int pos) 
        {
            switch (pos)
            {

                /*case Pos.SPotion: // ---------------------  Potion ----------------------------
                    if (Potionnette > 0)
                    {
                        Potionnette--;
                        // Pokemon.Heal
                        Console.SetCursorPosition(30, 8);
                        Console.Write("You regain 25Hp");
                        Console.SetCursorPosition(30, 9);
                        Console.Write(Potionnette + " Potionnette left");
                        System.Threading.Thread.Sleep(2500);
                        Console.Clear();
                    }
                    else if (Potionnette == 0)
                    {
                        Console.SetCursorPosition(30, 8);
                        Console.Write("You don't have any Potionette");
                        System.Threading.Thread.Sleep(2500);
                        Console.Clear();
                        Console.SetCursorPosition(30, 8);
                        Console.Write(" You idiot");
                        System.Threading.Thread.Sleep(800);
                        Console.Clear();

                    }
                    break;

                case Pos.MPotion:
                    if (Potion > 0)
                    {
                        Potion--;
                        // Pokemon.Heal
                        Console.SetCursorPosition(30, 8);
                        Console.Write("You regain 50Hp");
                        Console.SetCursorPosition(30, 9);
                        Console.Write(Potion + " Potion left");
                        System.Threading.Thread.Sleep(2500);
                        Console.Clear();
                    }
                    else if (Potion == 0)
                    {
                        Console.SetCursorPosition(30, 8);
                        Console.Write("You don't have any Potion");
                        System.Threading.Thread.Sleep(2500);
                        Console.Clear();
                        Console.SetCursorPosition(30, 8);
                        Console.Write(" You idiot");
                        System.Threading.Thread.Sleep(800);
                        Console.Clear();

                    }
                    break;
                case Pos.BPotion:
                    if (MaximaPocion > 0)
                    {
                        MaximaPocion--;
                        // Pokemon.Heal
                        Console.SetCursorPosition(30, 8);
                        Console.Write("You regain 150Hp");
                        Console.SetCursorPosition(30, 9);
                        Console.Write(MaximaPocion + " Maxima Pocion left");
                        System.Threading.Thread.Sleep(2500);
                        Console.Clear();
                    }
                    else if (MaximaPocion == 0)
                    {
                        Console.SetCursorPosition(30, 8);
                        Console.Write("You don't have any Maxima Pocion");
                        System.Threading.Thread.Sleep(2500);
                        Console.Clear();
                        Console.SetCursorPosition(30, 8);
                        Console.Write(" You idiot");
                        System.Threading.Thread.Sleep(800);
                        Console.Clear();

                    }
                    break;


                case Pos.Boeuf:  // ---------------------  Bouf ----------------------------
                    if (Boeuf > 0)
                    {
                        Boeuf--;
                        // Pokemon.atk increase
                        Console.SetCursorPosition(30, 8);
                        Console.Write("You're attack increase by 50%");
                        Console.SetCursorPosition(30, 9);
                        Console.Write(Boeuf + " Boeuf left");
                        System.Threading.Thread.Sleep(2500);
                        Console.Clear();
                    }
                    else if (Boeuf == 0)
                    {
                        Console.SetCursorPosition(30, 8);
                        Console.Write("You don't have any Boeuf");
                        System.Threading.Thread.Sleep(2500);
                        Console.Clear();
                        Console.SetCursorPosition(30, 8);
                        Console.Write(" You idiot");
                        System.Threading.Thread.Sleep(800);
                        Console.Clear();

                    }
                    break;

                case Pos.Cheetah:
                    if (Cheetah > 0)
                    {
                        Cheetah--;
                        // Pokemon.dodge increase
                        Console.SetCursorPosition(30, 8);
                        Console.Write("You're chance of dodge increase by 40%");
                        Console.SetCursorPosition(30, 9);
                        Console.Write(Cheetah + " Cheetah left");
                        System.Threading.Thread.Sleep(2500);
                        Console.Clear();
                    }
                    else if (Cheetah == 0)
                    {
                        Console.SetCursorPosition(30, 8);
                        Console.Write("You don't have any Cheetah");
                        System.Threading.Thread.Sleep(2500);
                        Console.Clear();
                        Console.SetCursorPosition(30, 8);
                        Console.Write(" You idiot");
                        System.Threading.Thread.Sleep(800);
                        Console.Clear();

                    }
                    break;

                case Pos.Tortoise:
                    if (Tortoise > 0)
                    {
                        Tortoise--;
                        // Pokemon.shield increase
                        Console.SetCursorPosition(30, 8);
                        Console.Write("You're shield increase by 30%");
                        Console.SetCursorPosition(30, 9);
                        Console.Write(Tortoise + " Tortoise left");
                        System.Threading.Thread.Sleep(2500);
                        Console.Clear();
                    }
                    else if (Tortoise == 0)
                    {
                        Console.SetCursorPosition(30, 8);
                        Console.Write("You don't have any Tortoise");
                        System.Threading.Thread.Sleep(2500);
                        Console.Clear();
                        Console.SetCursorPosition(30, 8);
                        Console.Write(" You idiot");
                        System.Threading.Thread.Sleep(800);
                        Console.Clear();

                    }
                    break;

                case Pos.Glue:  // ---------------------  Debouf ----------------------------
                    if (Glue > 0)
                    {
                        Glue--;
                        // Pokemon.atk increase
                        Console.SetCursorPosition(30, 8);
                        Console.Write("You're opponent can't dodge or escape");
                        Console.SetCursorPosition(30, 9);
                        Console.Write(Glue + " Glue left");
                        System.Threading.Thread.Sleep(2500);
                        Console.Clear();
                    }
                    else if (Glue == 0)
                    {
                        Console.SetCursorPosition(30, 8);
                        Console.Write("You don't have any Glue");
                        System.Threading.Thread.Sleep(2500);
                        Console.Clear();
                        Console.SetCursorPosition(30, 8);
                        Console.Write(" You idiot");
                        System.Threading.Thread.Sleep(800);
                        Console.Clear();

                    }
                    break;

                case Pos.Mirror:
                    if (Mirror > 0)
                    {
                        Mirror--;
                        // Pokemon.dodge increase
                        Console.SetCursorPosition(30, 8);
                        Console.Write("You're opponent have 50% of attacking himself");
                        Console.SetCursorPosition(30, 9);
                        Console.Write(Mirror + " Mirror left");
                        System.Threading.Thread.Sleep(2500);
                        Console.Clear();
                    }
                    else if (Mirror == 0)
                    {
                        Console.SetCursorPosition(30, 8);
                        Console.Write("You don't have any Mirror");
                        System.Threading.Thread.Sleep(2500);
                        Console.Clear();
                        Console.SetCursorPosition(30, 8);
                        Console.Write(" You idiot");
                        System.Threading.Thread.Sleep(800);
                        Console.Clear();


                    }
                    break;


                case Pos.Pangolin:
                    if (Pangolin > 0)
                    {
                        Pangolin--;
                        // opponent.shield decrease
                        Console.SetCursorPosition(30, 8);
                        Console.Write("Opponent shild decrease by 30%");
                        Console.SetCursorPosition(30, 9);
                        Console.Write(Pangolin + " Pangolin left");
                        System.Threading.Thread.Sleep(2500);
                        Console.Clear();
                    }
                    else if (Pangolin == 0)
                    {
                        Console.SetCursorPosition(30, 8);
                        Console.Write("You don't have any Pangolin");
                        System.Threading.Thread.Sleep(2500);
                        Console.Clear();
                        Console.SetCursorPosition(30, 8);
                        Console.Write(" You idiot");
                        System.Threading.Thread.Sleep(800);
                        Console.Clear();

                    }
                    break;*/

                default:
                    break;
            }


        }
    
        public virtual void UseItem()
        {

        }
    }
}
