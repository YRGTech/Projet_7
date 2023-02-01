namespace Projet_7
{
    public class Pokemon
    {

        private int _atk;
        private int _def;
        private int _pv;
        private int _pvMax;
        private int _pm;
        private int _pmMax;
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
            set { _pm = value; }
        }
        public int PMMax
        {
            get { return _pmMax; }
            protected set { _pmMax = value; }
        }

        public int LVL
        {
            get => _lvl;
            set { _lvl = value; }
        }

        public int ATK
        {
            get { return _atk; }
            set { _atk = value; }
            
        }
        public int DEF
        {
            get { return _def; }
            set { _def = value; }
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
            get => _xpMax + _xpMax / 4;
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
        public double Skill1
        {
            get; set;

        }

        public double Skill2
        {
            get; set;
        }
        public virtual void Hurt(int damage, Type type)
        {

        }
        public void Attack(Pokemon target, double skill)
        {

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
            Random randstat = new Random();
            _atk = _def + randstat.Next(3) + 1;
            _def = _def + randstat.Next(3) + 1;

            PVMax = PV;
        }

    }

    public class Pikachu : Pokemon
    {
        public Pikachu()
        {
            PV = 10;
            PVMax = 95;
            PM = 50;
            PMMax = 50;
            ATK = 80;
            DEF = 50;
            LVL = 1;
            XPMax = 60;
            Name = "Pikachu";
            Art = "`;-.          ___,\r\n  `.`\\_...._/`.-\"`\r\n    \\        /      ,\r\n    /()   () \\    .' `-._\r\n   |)  .    ()\\  /   _.'\r\n   \\  -'-     ,; '. <\r\n    ;.__     ,;|   > \\\r\n   / ,    / ,  |.-'.-'\r\n  (_/    (_/ ,;|.<`\r\n    \\    ,     ;-`\r\n     >   \\    /\r\n    (_,-'`> .'\r\n         (_,'";
            Skill1 = 1.5 * ATK;
            Skill2 = 2 * ATK;
        }
        public Pikachu(int lvl)
        {
            PV = 95;
            PVMax = PV;
            PM = 50;
            ATK = 80;
            DEF = 50;
            LVL = 1;
            XPMax = 60;
            Name = "Pikachu";
            Art = "`;-.          ___,\r\n  `.`\\_...._/`.-\"`\r\n    \\        /      ,\r\n    /()   () \\    .' `-._\r\n   |)  .    ()\\  /   _.'\r\n   \\  -'-     ,; '. <\r\n    ;.__     ,;|   > \\\r\n   / ,    / ,  |.-'.-'\r\n  (_/    (_/ ,;|.<`\r\n    \\    ,     ;-`\r\n     >   \\    /\r\n    (_,-'`> .'\r\n         (_,'";
            Skill1 = 1.5 * ATK;
            Skill2 = 2 * ATK;

            for (int i = 0; i < lvl; i++)
            {
                LVLup();
            }

        }


    }
}

    
   

