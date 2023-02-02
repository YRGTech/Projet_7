using System;
using System.IO;

namespace Projet_7
{

    public class SerializeTheObject
    {
        /*public int PV { get; set; }
        public int LVL{ get; set; }
        public double XP { get; set; }
        public int ATK { get; set; }
        public int DEF { get; set; }
        public int PM { get; set; }*/
        public Pikachu Pika { get; set; }
        public int PosX { get; set; }
        public int PosY { get; set; }

        public int Potionnette { get; set; }
        public int Potion { get; set; }
        public int MaximaPocion { get; set; }


        public int Tortoise { get; set; }
        public int Boeuf { get; set; }
        public int Mage { get; set; }

        public int Pangolin { get; set; }
        public int Bat { get; set; }
        public Inventory Inventory { get; set; }

        public SerializeTheObject(/*int pv, int lvl, int xp, int atk, int def, int pm,*/Pikachu pika, int posX, int posY,
            int potionnette, int potion, int maximapocion, int tortoise, int boeuf, int mage, int pangolin, int bat)
        
        {
            /*PV= pv;
            LVL= lvl;
            XP= xp;
            ATK= atk;
            DEF= def;
            PM= pm;*/
            Pika = pika;
            PosX = posX;
            PosY = posY;
            Potionnette = potionnette;
            Potion = potion;
            MaximaPocion = maximapocion;
            Tortoise = tortoise;
            Boeuf = boeuf;
            Mage = mage;
            Pangolin = pangolin;
            Bat = bat;

        }



        

    }
}