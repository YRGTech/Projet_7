using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Projet_7
{
    public class Pokemon
    {

        int _atk;

        int _def;

        int _vit;

        int _acc;

        string _type;



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
            get { return (int)(80 * Math.Log(LVL) + PV); }
            protected set
            {
                _pv = value;
            }
        }

        public int PM
        {
            get { return (int)(80 * Math.Log(LVL) + PM); }
            protected set
            {
                _pm = value;
            }
        }

        public int LVL
        {
            get;
            protected set;
        }

        public int ATK
        {
            get { return (int)(80 * Math.Log(LVL) + _atk); }
            protected set { _atk = value; }
        }
        public int DEF
        {
            get { return (int)(80 * Math.Log(LVL) + _def); }
            protected set { _def = value; }
        }
        public int VIT
        {
            get { return (int)(80 * Math.Log(LVL) + _vit); }
            protected set { _vit = value; }
        }
        public int ACC
        {
            get { return (int)(80 * Math.Log(LVL) + _acc); }
            protected set { _acc = value; }
        }
        public string TYPE { get; protected set; }

        public void Hurt(int damage)
        {
            throw new System.NotImplementedException();
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

        private int _pv;
        private int _pm;
        private int _lvl;
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
            get => 1.5 * _atk;

        }

        private double Skill2
        {
            get => 1.75 * _atk;
        }
    }

}