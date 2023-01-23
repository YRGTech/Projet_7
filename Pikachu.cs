using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projet_7
{
    public class Pikachu : Pokemon
    {
        public Pikachu(int pv, int pm, int atk, int def, int vit, int acc, string type, int niv) : base(pv, pm, atk, def, vit, acc, type, niv)
        {

        }

        public int Skill1
        {
            get => default;
            set
            {
            }
        }

        public int Skill2
        {
            get => default;
            set
            {
            }
        }
    }
}