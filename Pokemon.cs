using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projet_7
{
    public class Pokemon
    {
        private int _pv;
        private int _pm;
        private int _atk;
        private int _def;
        private int _vit;
        private int _acc;
        private string _type;
        private int _niv;

        public Pokemon(int pv, int pm, int atk, int def, int vit, int acc, string type, int niv)
        {
            _pv = pv;
            _pm = pm;
            _atk = atk;
            _def = def;
            _vit = vit;
            _acc = acc;
            _type = type;
            _niv = niv;
           
        }

        public int PV
        {
            get => _pv;
            set => _pv = value;
            
        }

        public int PM
        {
            get => _pm;
            set => _pm = value;
        }

        public int NIV
        {
            get => _niv;
            set => _niv = value;
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
    }
}