using System;
using System.Reflection;

namespace Projet_7
{
    public class Combat
    {
        private bool _turn;
        private bool _fight;
        private bool _atkInProgress;


        public bool lose { get; set; }
        public bool win { get; set; }

        private static List<Option>? options;
        private static List<Option>? attackOptions;
        public Combat(Pokemon player)
        {
            options = new List<Option>
            {
                new Option("Attack",() => Attack() ),
                new Option("Flee", () => Flee()),
                //new Option("Object", () => ),
            };
            attackOptions = new List<Option>
            {
                new Option("light attack",() => LightAttack(Player,Enemy)),
                new Option("heavy attack", () => HeavyAttack(Player,Enemy)),
            };

            Random randPoke = new Random();
            int enemyLVL = (player.LVL - 2) + randPoke.Next(5);
            switch (randPoke.Next(10))
            {
                case 0:
                    Enemy = new Pikachu(enemyLVL);
                    break;
                case 1:
                    Enemy = new Flabebe(enemyLVL);
                    break;
                case 2:
                    Enemy = new Abo(enemyLVL);
                    break;
                case 3:
                    Enemy = new Boustiflor(enemyLVL);
                    break;
                case 4:
                    Enemy = new Farfuret(enemyLVL);
                    break;
                case 5:
                    Enemy = new Chuchmur(enemyLVL);
                    break;
                case 6:
                    Enemy = new Picassault(enemyLVL);
                    break;
                case 7:
                    Enemy = new Insolourdo(enemyLVL);
                    break;
                case 8:
                    Enemy = new Funecire(enemyLVL);
                    break;
                case 9:
                    Enemy = new Giselle(100);
                    break;
                default:
                    break;
            }
            Player = player;
        }

        public Pokemon Player
        {
            get;
            set;
        }

        public Pokemon Enemy
        {
            get;
            set;
        }

        public void PlayerTurn()
        {
            int index = 0;
            WriteMenu(options, options[index]);
            _turn = true;
            while (_turn)
            {
                ConsoleKey key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.DownArrow:
                        if (index + 1 < options.Count)
                        {
                            index++;
                            WriteMenu(options, options[index]);
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if (index - 1 >= 0)
                        {
                            index--;
                            WriteMenu(options, options[index]);
                        }
                        break;
                    case ConsoleKey.Spacebar:
                        {
                            options[index].Selected.Invoke();
                            _turn = false;
                        }
                        break;
                    default:
                        {
                            break;
                        }
                }
            }
        }

        public void EnemyTurn()
        {
            var rand = new Random();
            switch (rand.Next(5))
            {
                case 0:
                    if (Enemy.TYPE == Type.Giselle) HeavyAttack(Enemy, Enemy);
                    break;
                case 1:
                case 2:
                case 3:
                    LightAttack(Enemy, Player);
                    break;
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                    HeavyAttack(Enemy, Player);
                    break;
                default:
                    break;
            }

        }

        public void UseItem()
        {
            throw new System.NotImplementedException();
        }
        public void Attack()
        {
            int index = 0;
            WriteMenu(attackOptions, attackOptions[index]);
            _atkInProgress = true;
            while (_atkInProgress)
            {
                ConsoleKey key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.DownArrow:
                        if (index + 1 < attackOptions.Count)
                        {
                            index++;
                            WriteMenu(attackOptions, attackOptions[index]);
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if (index - 1 >= 0)
                        {
                            index--;
                            WriteMenu(attackOptions, attackOptions[index]);
                        }
                        break;
                    case ConsoleKey.Spacebar:
                        {
                            attackOptions[index].Selected.Invoke();
                            _atkInProgress = false;
                        }
                        break;
                    default:
                        {
                            break;
                        }

                }
            }

        }
        public void Flee()
        {
            _fight = false;
            Player.Heal(Player.PVMax);
            win = false;
        }
        public void LightAttack(Pokemon poke, Pokemon target)
        {
            poke.Attack(target, poke.Skill1);
        }
        public void HeavyAttack(Pokemon poke, Pokemon target)
        {
            if (poke == Player) poke.PM -= 10;
            poke.Attack(target, poke.Skill2);
        }

        public void Fight()
        {
            _fight = true;



            while (_fight)
            {

                if (Player.PV == 0)
                {
                    lose = true;
                    _fight = false;
                    Player.Heal(Player.PVMax);

                }
                else PlayerTurn();

                if (Enemy.PV == 0)
                {
                    win = true;
                    _fight = false;
                    Player.Heal(Player.PVMax);
                    Player.XP += (60 * Enemy.LVL) / 7;
                    while (Player.XP >= Player.XPMax)
                    {
                        Console.WriteLine("XP nxt LVL: {0}      XP: {1}", Player.XPMax, Player.XP);
                        Player.XP -= Player.XPMax;
                        Player.LVLup();
                    }
                }
                else EnemyTurn();

            }
        }
        public void WriteMenu(List<Option> options, Option selectedOption)
        {
            Console.Clear();
             Enemy.Draw();
            Player.Draw();
            foreach (Option option in options)
            {
                if (option == selectedOption)
                {
                    Console.Write("> ");
                }
                else
                {
                    Console.Write(" ");
                }
                Console.WriteLine(option.Name);

            }
            Console.SetCursorPosition(10, 10);
            Console.Write(Player.Name);
            Console.WriteLine(Player.PV);
            Console.WriteLine(Player.LVL);
            Console.SetCursorPosition(10, 11);
            Console.Write(Enemy.Name);
            Console.WriteLine(Enemy.PV);
        }
    }
}