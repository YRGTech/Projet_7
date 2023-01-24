using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Projet_7
{
    public class Pokemon
    {
        
        public int _atk 
        { 
            get { return (int)(80 * Math.Log(NIV) + _atk); }  
            set { _atk = value; }
        }
        public int _def { 
            get{ return (int)(80 * Math.Log(NIV) + _def); }
            set { _def = value; }
        }
        public int _vit
        {
            get { return (int)(80 * Math.Log(NIV) + _vit); }
            set { _vit = value; }
        }
        public int _acc
        {
            get { return (int)(80 * Math.Log(NIV) + _acc); }
            set { _acc = value; }
        }
        public string _type { get; set; }


        public Pokemon()
        {
            PV = 0;
            PM = 0;
            _atk = 0;
            _def = 0;
            _vit = 0;
            _acc = 0;
            _type = "NULL";
            NIV = 0;
           
        }

        public int PV
        {
            get { return (int)(80 * Math.Log(NIV) + PV); }
            set { PV = value; }
        }

        public int PM
        {
            get { return (int)(80 * Math.Log(NIV) + PM); }
            set { PM = value; }
        }

        public int NIV
        {
            get;
            set;
        }

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
    }

    public class Pikachu : Pokemon
    {
        public Pikachu() 
        {
            PV = 35;
            PM = 50;
            _atk = 55;
            _def = 40;
            _vit = 90;
            _acc = 100;
            _type = "electric";
            NIV = 1;
        }

        public int Skill1
        {
            get => 50;

        }

        public int Skill2
        {
            get => 75;
        }
    }

}