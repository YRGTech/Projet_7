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
        private int _xpMax;

        public Pokemon()
        {
            PV = 0;
            PM = 0;
            _atk = 0;
            _def = 0;
            _vit = 0;
            _acc = 0;
            _type = Type.Normal;
            LVL = 0;
            Name = "Pokemon";

        }

        public int PV
        {
            get { return _pv; }
            protected set { _pv = value; }
        }
        public int PVMax
        {
            get { return _pvMax; }
            protected set { _pvMax = value; }
        }

        public int PM
        {
            get { return _pm; }
            protected set { _pm = value; }
        }

        public int LVL
        {
            get => _lvl;
            set { _lvl = value; }
        }

        public int ATK
        {
            get { return (int)(25 * Math.Log2(LVL) + _atk); }
            init { _atk = value; }
        }
        public int DEF
        {
            get { return (int)(25 * Math.Log2(LVL) + _def); }
            init { _def = value; }
        }
        public int VIT
        {
            get { return (int)(25 * Math.Log2(LVL) + _vit); }
            init { _vit = value; }
        }
        public int ACC
        {
            get { return (int)(25 * Math.Log2(LVL) + _acc); }
            init { _acc = value; }

        }
        public Type TYPE
        {
            get => _type;
            init { _type = value; }
        }

        public int XP
        {
            get => _xp;
            set { _xp = value; }
        }
        public int XPMax
        {
            get => (int)(25 * Math.Log2(LVL) + _xpMax);
            set { _xpMax = value; }
        }

        public string Name
        {
            get => _name;
            protected set { _name = value; }
        }
        public string Art
        {
            get => _art;
            init { _art = value; }
        }
        public virtual void Hurt(int damage, Type type)
        {

        }
        public void Attack(Pokemon target, double skill)
        {
            Console.Write("");
            target.Hurt((int)skill, target.TYPE);
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
            PV = (int)(5 * Math.Log2(LVL) + PV);
            PM = (int)(5 * Math.Log2(LVL) + PM);
            

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
            Art = "`;-.          ___,\r\n  `.`\\_...._/`.-\"`\r\n    \\        /      ,\r\n    /()   () \\    .' `-._\r\n   |)  .    ()\\  /   _.'\r\n   \\  -'-     ,; '. <\r\n    ;.__     ,;|   > \\\r\n   / ,    / ,  |.-'.-'\r\n  (_/    (_/ ,;|.<`\r\n    \\    ,     ;-`\r\n     >   \\    /\r\n    (_,-'`> .'\r\n         (_,'";
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
                    damage = damage * 1 / 2;
                    Console.WriteLine("{0} degat pas efficace dans ta geule\n", damage);
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
                case Type.Giselle:
                    damage = damage * 2;
                    Console.WriteLine("{0} degat efficace dans ta geule\n", damage);
                    break;
                default:
                    break;
            }
            damage = damage - DEF;
            if (damage < 0)
                damage = LVL;
            PV = PV - damage;
            if (PV < 0) { PV = 0; }
        }

    }


}