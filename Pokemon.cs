using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Projet_7
{
    public class Pokemon
    {

        private int _atk;
        private int _def;
        private int _vit;
        private int _acc;
        private int _pv;
        private int _pvMax;
        private int _pm;
        private int _lvl;
        private int _xp;
        private Type _type;
        private string _name;
        private string _art;


        public Pokemon()
        {
            PV = 0;
            PM = 0;
            _atk = 0;
            _def = 0;
            _vit = 0;
            _acc = 0;
            _type = Type.NORMAL;
            LVL = 0;
            Name = "Pokemon";

        }

        public int PV
        {
            get { return _pv; }
            protected set {_pv = value;}
        }
        public int PVMax
        {
            get { return _pvMax; }
            protected set { _pvMax = value;}
        }

        public int PM
        {
            get { return _pm; }
            protected set{ _pm = value; }
        }

        public int LVL
        {
            get => _lvl;
            set { _lvl = value; }
        }

        public int ATK
        {
            get { return _atk; }
            init{ _atk = value;}
        }
        public int DEF
        {
            get { return _def; }
            init { _def = value;}
        }
        public int VIT
        {
            get { return _vit; }
            init{ _vit = value;}
        }
        public int ACC
        {
            get { return _acc; }
            init{ _acc = value;}

        }
        public Type TYPE { 
            get => _type; 
            init { _type = value;} 
        }

        public int XP
        {
            get => _xp;
            set{ _xp = value;}
        }

        public string Name
        {
            get => _name;
            protected set { _name = value;}
        }
        public string Art
        {
            get => _art;
            init { _art = value; }
        }
        public virtual void Hurt(int damage,Type type)
        {
            
        }
        public void Attack(Pokemon target, double skill)
        {
            Console.Write("");
            target.Hurt((int)skill,target.TYPE);
        }

        public void Heal(int value)
        {
            PV = PV + value;
            if (PV > PVMax)
                PV = PVMax;
        }

        public bool IsAlive()
        {
            return PV > 0;
        }


        public void Draw()
        {
            Console.Write(_art);
        }
        public void LVLup()
        {
            LVL = LVL + 1;
            Heal(PVMax);
            PV = 25 * LVL / 10 + PV;
            PM = 25 * LVL / 10 + PM;

            PVMax = PV;
        }

    }

    public class Pikachu : Pokemon
    {
        public Pikachu()
        {
            PV = 85;
            PVMax = PV;
            PM = 50;
            ATK = 55;
            DEF = 40;
            VIT = 90;
            ACC = 100;
            TYPE = Type.Electric;
            LVL = 1;
            Name = "Pikachu";
            Art = "quu..__\r\n $$$b  `---.__\r\n  \"$$b        `--.                          ___.---uuudP\r\n   `$$b           `.__.------.__     __.---'      $$$$\"              .\r\n     \"$b          -'            `-.-'            $$$\"              .'|\r\n       \".                                       d$\"             _.'  |\r\n         `.   /                              ...\"             .'     |\r\n           `./                           ..::-'            _.'       |\r\n            /                         .:::-'            .-'         .'\r\n           :                          ::''\\          _.'            |\r\n          .' .-.             .-.           `.      .'               |\r\n          : /'$$|           .@\"$\\           `.   .'              _.-'\r\n         .'|$u$$|          |$$,$$|           |  <            _.-'\r\n         | `:$$:'          :$$$$$:           `.  `.       .-'\r\n         :                  `\"--'             |    `-.     \\\r\n        :##.       ==             .###.       `.      `.    `\\\r\n        |##:                      :###:        |        >     >\r\n        |#'     `..'`..'          `###'        x:      /     /\r\n         \\                                   xXX|     /    ./\r\n          \\                                xXXX'|    /   ./\r\n          /`-.                                  `.  /   /\r\n         :    `-  ...........,                   | /  .'\r\n         |         ``:::::::'       .            |<    `.\r\n         |             ```          |           x| \\ `.:``.\r\n         |                         .'    /'   xXX|  `:`M`M':.\r\n         |    |                    ;    /:' xXXX'|  -'MMMMM:'\r\n         `.  .'                   :    /:'       |-'MMMM.-'\r\n          |  |                   .'   /'        .'MMM.-'\r\n          `'`'                   :  ,'          |MMM<\r\n            |                     `'            |tbap\\\r\n             \\                                  :MM.-'\r\n              \\                 |              .''\r\n               \\.               `.            /\r\n                /     .:::::::.. :           /\r\n               |     .:::::::::::`.         /\r\n               |   .:::------------\\       /\r\n              /   .''               >::'  /\r\n              `',:                 :    .'\r\n                                   `:.:'";
        }

        public double Skill1
        {
            get => 1.5 * ATK;

        }

        public double Skill2
        {
            get => 1.75 * ATK;
        }

        public override void Hurt(int damage, Type type)
        {
            switch (type)
            {
                case Type.Electric:
                    damage = damage * 1/2;
                    Console.WriteLine("{0} degat pas efficace dans ta geule\n",damage);
                    break;
                case Type.Ground:
                    damage = damage * 2;
                    Console.WriteLine("{0} degat efficace dans ta geule\n", damage);
                    break;
                case Type.Flying:
                    damage = damage * 1 / 2;
                    Console.WriteLine("{0} degat pas efficace dans ta geule\n", damage);
                    break;
                case Type.Steel:
                    damage = damage * 1 / 2;
                    Console.WriteLine("{0} degat pas efficace dans ta geule\n", damage);
                    break;
                default:
                    break;
            }
            damage = damage - DEF;

            PV = PV - damage;
            if(PV <0) { PV= 0; }
        }
        
    }


}