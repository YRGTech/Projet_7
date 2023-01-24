using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Projet_7
{
    public class Pokemon
    {

        protected int _atk;
        protected int _def;
        protected int _vit;
        protected int _acc;
        protected string _type;

        private int _pv;
        private int _pm;
        private int _lvl;
        private int _xp;


        public Pokemon()
        {
            PV = 0;
            PM = 0;
            _atk = 0;
            _def = 0;
            _vit = 0;
            _acc = 0;
            _type = "NULL";
            LVL = 0;

        }

        public int PV
        {
            get { return _pv; }
            protected set
            {
                _pv = value;
            }
        }

        public int PM
        {
            get { return (int)(25 * LVL / 10 + _pm); }
            protected set
            {
                _pm = value;
            }
        }

        public int LVL
        {
            get;
            set;
        }

        public int ATK
        {
            get { return (int)(25 * LVL / 10 + _atk); }
            init
            {
                _atk = value;
            }
        }
        public int DEF
        {
            get { return (int)(25 * LVL / 10 + _def); }
            init
            {
                _def = value;
            }
        }
        public int VIT
        {
            get { return (int)(25 * LVL / 10 + _vit); }
            init
            {
                _vit = value;
            }
        }
        public int ACC
        {
            get { return (int)(25 * LVL / 10 + _acc); }
            init
            {
                _acc = value;
            }
            
        }
        public string TYPE { get; protected set; }

        public void Hurt(int damage)
        {
            PV = 25 * LVL / 10 + PV - damage;
        }

        public void Heal()
        {
            throw new System.NotImplementedException();
        }

        public void IsAlive()
        {
            throw new System.NotImplementedException();
        }

        public void Attack()
        {
            throw new System.NotImplementedException();
        }

        public void Draw(string art)
        {
            Console.Write(art);
        }

       

        public int XP
        {
            get => default;
            set
            {
            }
        }
    }

    public class Pikachu : Pokemon
    {
        public Pikachu()
        {
            PV = 85;
            PM = 50;
            ATK = 55;
            DEF = 40;
            VIT = 90;
            ACC = 100;
            TYPE = "electric";
            LVL = 1;
        }

        private double Skill1
        {
            get => 1.5 * ATK;

        }

        private double Skill2
        {
            get => 1.75 * ATK;
        }


    }

    public class Griknot : Pokemon
    {
        public Griknot()
        {
            PV = 85;
            PM = 50;
            ATK = 55;
            DEF = 40;
            VIT = 90;
            ACC = 100;
            TYPE = "ground";
            LVL = 1;
        }

        private double Skill1
        {
            get => 1.5 * ATK;

        }

        private double Skill2
        {
            get => 1.75 * ATK;
        }


    }

}