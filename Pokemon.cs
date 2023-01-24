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
        private int _pvMax;
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
        public int PVMax
        {
            get { return _pvMax; }
            protected set
            {
                _pvMax = value;
            }
        }

        public int PM
        {
            get { return _pm; }
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
            get { return _atk; }
            init
            {
                _atk = value;
            }
        }
        public int DEF
        {
            get { return _def; }
            init
            {
                _def = value;
            }
        }
        public int VIT
        {
            get { return _vit; }
            init
            {
                _vit = value;
            }
        }
        public int ACC
        {
            get { return  _acc; }
            init
            {
                _acc = value;
            }
            
        }
        public string TYPE { get; protected set; }

        public void Hurt(int damage)
        {
            PV = PV - damage;
        }

        public int XP
        {
            get => _xp;
            set
            {
                _xp = value;
            }
        }
        public void Heal(int value)
        {
            PV = PV + value;
            if (PV > PVMax)
                PV = PVMax;
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


}