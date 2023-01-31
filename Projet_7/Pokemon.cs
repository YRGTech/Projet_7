namespace Projet_7
{
    public class Pokemon
    {

        private int _atk;
        private int _def;
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
            get { return  _atk; }
            init { _atk = value; }
        }
        public int DEF
        {
            get { return _def; }
            init { _def = value; }
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
            get => _xpMax + _xpMax/4;
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
            get;set;

        }

        public double Skill2
        {
            get;set;
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
            PV = 95;
            PVMax = PV;
            PM = 50;
            ATK = 80;
            DEF = 50;
            TYPE = Type.Electric;
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
            TYPE = Type.Electric;
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


        public override void Hurt(int damage, Type type)
        {
            damage = damage - DEF;
            switch (type)
            {
                case Type.Electric:
                    damage = damage * 1 / 2;
                    break;
                case Type.Ground:
                    damage = damage * 2;
                    break;
                case Type.Flying:
                    damage = damage * 1 / 2;
                    break;
                case Type.Steel:
                    damage = damage * 1 / 2;
                    break;
                case Type.Giselle:
                    damage = damage * 2;
                    break;
                default:
                    break;
            }
            
            if (damage < 0)
                damage = LVL;
            PV = PV - damage;
            if (PV < 0) { PV = 0; }
        }

    }

    public class Seviper : Pokemon
    {
       
        public Seviper(int lvl)
        {
            PV = 123;
            PVMax = PV;
            PM = 100;
            ATK = 100;
            DEF = 60;
            TYPE = Type.Poison;
            LVL = 1;
            XPMax = 60;
            Name = "Seviper";
            Art = "`;-.          ___,\r\n  `.`\\_...._/`.-\"`\r\n    \\        /      ,\r\n    /()   () \\    .' `-._\r\n   |)  .    ()\\  /   _.'\r\n   \\  -'-     ,; '. <\r\n    ;.__     ,;|   > \\\r\n   / ,    / ,  |.-'.-'\r\n  (_/    (_/ ,;|.<`\r\n    \\    ,     ;-`\r\n     >   \\    /\r\n    (_,-'`> .'\r\n         (_,'";
            Skill1 = 1.5 * ATK;
            Skill2 = 2 * ATK;

            for (int i = 0; i < lvl; i++)
            {
                LVLup();
            }

        }


        public override void Hurt(int damage, Type type)
        {
            damage = damage - DEF;
            switch (type)
            {
                case Type.Electric:
                    damage = damage * 1 / 2;
                    break;
                case Type.Ground:
                    damage = damage * 2;
                    break;
                case Type.Flying:
                    damage = damage * 1 / 2;
                    break;
                case Type.Steel:
                    damage = damage * 1 / 2;
                    break;
                case Type.Giselle:
                    damage = damage * 2;
                    break;
                default:
                    break;
            }

            if (damage < 0)
                damage = LVL;
            PV = PV - damage;
            if (PV < 0) { PV = 0; }
        }

    }

    public class Boustiflor : Pokemon
    {
       
        public Boustiflor(int lvl)
        {
            PV = 115;
            PVMax = PV;
            PM = 50;
            ATK = 90;
            DEF = 50;
            TYPE = Type.Grass;
            LVL = 1;
            XPMax = 60;
            Name = "Boustiflor";
            Art = "`;-.          ___,\r\n  `.`\\_...._/`.-\"`\r\n    \\        /      ,\r\n    /()   () \\    .' `-._\r\n   |)  .    ()\\  /   _.'\r\n   \\  -'-     ,; '. <\r\n    ;.__     ,;|   > \\\r\n   / ,    / ,  |.-'.-'\r\n  (_/    (_/ ,;|.<`\r\n    \\    ,     ;-`\r\n     >   \\    /\r\n    (_,-'`> .'\r\n         (_,'";
            Skill1 = 1.5 * ATK;
            Skill2 = 2 * ATK;

            for (int i = 0; i < lvl; i++)
            {
                LVLup();
            }

        }


        public override void Hurt(int damage, Type type)
        {
            damage = damage - DEF;
            switch (type)
            {
                case Type.Electric:
                    damage = damage * 1 / 2;
                    break;
                case Type.Ground:
                    damage = damage * 2;
                    break;
                case Type.Flying:
                    damage = damage * 1 / 2;
                    break;
                case Type.Steel:
                    damage = damage * 1 / 2;
                    break;
                case Type.Giselle:
                    damage = damage * 2;
                    break;
                default:
                    break;
            }

            if (damage < 0)
                damage = LVL;
            PV = PV - damage;
            if (PV < 0) { PV = 0; }
        }

    }

    public class Farfuret : Pokemon
    {
       
        public Farfuret(int lvl)
        {
            PV = 105;
            PVMax = PV;
            PM = 50;
            ATK = 95;
            DEF = 55;
            TYPE = Type.Dark;
            LVL = 1;
            XPMax = 60;
            Name = "Farfuret";
            Art = "`;-.          ___,\r\n  `.`\\_...._/`.-\"`\r\n    \\        /      ,\r\n    /()   () \\    .' `-._\r\n   |)  .    ()\\  /   _.'\r\n   \\  -'-     ,; '. <\r\n    ;.__     ,;|   > \\\r\n   / ,    / ,  |.-'.-'\r\n  (_/    (_/ ,;|.<`\r\n    \\    ,     ;-`\r\n     >   \\    /\r\n    (_,-'`> .'\r\n         (_,'";
            Skill1 = 1.5 * ATK;
            Skill2 = 2 * ATK;

            for (int i = 0; i < lvl; i++)
            {
                LVLup();
            }

        }


        public override void Hurt(int damage, Type type)
        {
            damage = damage - DEF;
            switch (type)
            {
                case Type.Electric:
                    damage = damage * 1 / 2;
                    break;
                case Type.Ground:
                    damage = damage * 2;
                    break;
                case Type.Flying:
                    damage = damage * 1 / 2;
                    break;
                case Type.Steel:
                    damage = damage * 1 / 2;
                    break;
                case Type.Giselle:
                    damage = damage * 2;
                    break;
                default:
                    break;
            }

            if (damage < 0)
                damage = LVL;
            PV = PV - damage;
            if (PV < 0) { PV = 0; }
        }

    }

    public class Chuchmur : Pokemon
    {
        
        public Chuchmur(int lvl)
        {
            PV = 114;
            PVMax = PV;
            PM = 51;
            ATK = 51;
            DEF = 23;
            TYPE = Type.Normal;
            LVL = 1;
            XPMax = 60;
            Name = "Chuchmur";
            Art = "`;-.          ___,\r\n  `.`\\_...._/`.-\"`\r\n    \\        /      ,\r\n    /()   () \\    .' `-._\r\n   |)  .    ()\\  /   _.'\r\n   \\  -'-     ,; '. <\r\n    ;.__     ,;|   > \\\r\n   / ,    / ,  |.-'.-'\r\n  (_/    (_/ ,;|.<`\r\n    \\    ,     ;-`\r\n     >   \\    /\r\n    (_,-'`> .'\r\n         (_,'";
            Skill1 = 1.5 * ATK;
            Skill2 = 2 * ATK;

            for (int i = 0; i < lvl; i++)
            {
                LVLup();
            }

        }


        public override void Hurt(int damage, Type type)
        {
            damage = damage - DEF;
            switch (type)
            {
                case Type.Electric:
                    damage = damage * 1 / 2;
                    break;
                case Type.Ground:
                    damage = damage * 2;
                    break;
                case Type.Flying:
                    damage = damage * 1 / 2;
                    break;
                case Type.Steel:
                    damage = damage * 1 / 2;
                    break;
                case Type.Giselle:
                    damage = damage * 2;
                    break;
                default:
                    break;
            }

            if (damage < 0)
                damage = LVL;
            PV = PV - damage;
            if (PV < 0) { PV = 0; }
        }

    }

    public class Flabebe : Pokemon
    {
       
        public Flabebe(int lvl)
        {
            PV = 94;
            PVMax = PV;
            PM = 50;
            ATK = 38;
            DEF = 39;
            TYPE = Type.Fairy;
            LVL = 1;
            XPMax = 60;
            Name = "Flabebe";
            Art = "`;-.          ___,\r\n  `.`\\_...._/`.-\"`\r\n    \\        /      ,\r\n    /()   () \\    .' `-._\r\n   |)  .    ()\\  /   _.'\r\n   \\  -'-     ,; '. <\r\n    ;.__     ,;|   > \\\r\n   / ,    / ,  |.-'.-'\r\n  (_/    (_/ ,;|.<`\r\n    \\    ,     ;-`\r\n     >   \\    /\r\n    (_,-'`> .'\r\n         (_,'";
            Skill1 = 1.5 * ATK;
            Skill2 = 2 * ATK;

            for (int i = 0; i < lvl; i++)
            {
                LVLup();
            }

        }


        public override void Hurt(int damage, Type type)
        {
            damage = damage - DEF;
            switch (type)
            {
                case Type.Electric:
                    damage = damage * 1 / 2;
                    break;
                case Type.Ground:
                    damage = damage * 2;
                    break;
                case Type.Flying:
                    damage = damage * 1 / 2;
                    break;
                case Type.Steel:
                    damage = damage * 1 / 2;
                    break;
                case Type.Giselle:
                    damage = damage * 2;
                    break;
                default:
                    break;
            }

            if (damage < 0)
                damage = LVL;
            PV = PV - damage;
            if (PV < 0) { PV = 0; }
        }

    }

    public class Picassault : Pokemon
    {
        
        public Picassault(int lvl)
        {

            PV = 85;
            PVMax = PV;
            PM = 50;
            ATK = 75;
            DEF = 30;
            TYPE = Type.Flying;
            LVL = 1;
            XPMax = 60;
            Name = "Picassault";
            Art = "`;-.          ___,\r\n  `.`\\_...._/`.-\"`\r\n    \\        /      ,\r\n    /()   () \\    .' `-._\r\n   |)  .    ()\\  /   _.'\r\n   \\  -'-     ,; '. <\r\n    ;.__     ,;|   > \\\r\n   / ,    / ,  |.-'.-'\r\n  (_/    (_/ ,;|.<`\r\n    \\    ,     ;-`\r\n     >   \\    /\r\n    (_,-'`> .'\r\n         (_,'";
            Skill1 = 1.5 * ATK;
            Skill2 = 2 * ATK;

            for (int i = 0; i < lvl; i++)
            {
                LVLup();
            }

        }


        public override void Hurt(int damage, Type type)
        {
            damage = damage - DEF;
            switch (type)
            {
                case Type.Electric:
                    damage = damage * 1 / 2;
                    break;
                case Type.Ground:
                    damage = damage * 2;
                    break;
                case Type.Flying:
                    damage = damage * 1 / 2;
                    break;
                case Type.Steel:
                    damage = damage * 1 / 2;
                    break;
                case Type.Giselle:
                    damage = damage * 2;
                    break;
                default:
                    break;
            }

            if (damage < 0)
                damage = LVL;
            PV = PV - damage;
            if (PV < 0) { PV = 0; }
        }

    }

    public class Insolourdo : Pokemon
    {
       
        public Insolourdo(int lvl)
        {
            PV = 150;
            PVMax = PV;
            PM = 50;
            ATK = 70;
            DEF = 70;
            TYPE = Type.Normal;
            LVL = 1;
            XPMax = 60;
            Name = "Insolourdo";
            Art = "`;-.          ___,\r\n  `.`\\_...._/`.-\"`\r\n    \\        /      ,\r\n    /()   () \\    .' `-._\r\n   |)  .    ()\\  /   _.'\r\n   \\  -'-     ,; '. <\r\n    ;.__     ,;|   > \\\r\n   / ,    / ,  |.-'.-'\r\n  (_/    (_/ ,;|.<`\r\n    \\    ,     ;-`\r\n     >   \\    /\r\n    (_,-'`> .'\r\n         (_,'";
            Skill1 = 1.5 * ATK;
            Skill2 = 2 * ATK;

            for (int i = 0; i < lvl; i++)
            {
                LVLup();
            }

        }


        public override void Hurt(int damage, Type type)
        {
            damage = damage - DEF;
            switch (type)
            {
                case Type.Electric:
                    damage = damage * 1 / 2;
                    break;
                case Type.Ground:
                    damage = damage * 2;
                    break;
                case Type.Flying:
                    damage = damage * 1 / 2;
                    break;
                case Type.Steel:
                    damage = damage * 1 / 2;
                    break;
                case Type.Giselle:
                    damage = damage * 2;
                    break;
                default:
                    break;
            }

            if (damage < 0)
                damage = LVL;
            PV = PV - damage;
            if (PV < 0) { PV = 0; }
        }

    }

    public class Funecire : Pokemon
    {
        
        public Funecire(int lvl)
        {
            PV = 100;
            PVMax = PV;
            PM = 50;
            ATK = 30;
            DEF = 55;
            TYPE = Type.Ghost;
            LVL = 1;
            XPMax = 60;
            Name = "Funecire";
            Art = "`;-.          ___,\r\n  `.`\\_...._/`.-\"`\r\n    \\        /      ,\r\n    /()   () \\    .' `-._\r\n   |)  .    ()\\  /   _.'\r\n   \\  -'-     ,; '. <\r\n    ;.__     ,;|   > \\\r\n   / ,    / ,  |.-'.-'\r\n  (_/    (_/ ,;|.<`\r\n    \\    ,     ;-`\r\n     >   \\    /\r\n    (_,-'`> .'\r\n         (_,'";
            Skill1 = 1.5 * ATK;
            Skill2 = 2 * ATK;

            for (int i = 0; i < lvl; i++)
            {
                LVLup();
            }

        }


        public override void Hurt(int damage, Type type)
        {
            damage = damage - DEF;
            switch (type)
            {
                case Type.Electric:
                    damage = damage * 1 / 2;
                    break;
                case Type.Ground:
                    damage = damage * 2;
                    break;
                case Type.Flying:
                    damage = damage * 1 / 2;
                    break;
                case Type.Steel:
                    damage = damage * 1 / 2;
                    break;
                case Type.Giselle:
                    damage = damage * 2;
                    break;
                default:
                    break;
            }

            if (damage < 0)
                damage = LVL;
            PV = PV - damage;
            if (PV < 0) { PV = 0; }
        }

    }

    public class Giselle : Pokemon
    {
       
        public Giselle(int lvl)
        {
            PV = 100;
            PVMax = PV;
            PM = 100;
            ATK = 100;
            DEF = 100;
            TYPE = Type.Giselle;
            LVL = 1;
            XPMax = 60;
            Name = "Giselle";
            Art = "`;-.          ___,\r\n  `.`\\_...._/`.-\"`\r\n    \\        /      ,\r\n    /()   () \\    .' `-._\r\n   |)  .    ()\\  /   _.'\r\n   \\  -'-     ,; '. <\r\n    ;.__     ,;|   > \\\r\n   / ,    / ,  |.-'.-'\r\n  (_/    (_/ ,;|.<`\r\n    \\    ,     ;-`\r\n     >   \\    /\r\n    (_,-'`> .'\r\n         (_,'";
            Skill1 = 3.5 * ATK;
            Skill2 = 4 * ATK;

            for (int i = 0; i < lvl; i++)
            {
                LVLup();
            }

        }


        public override void Hurt(int damage, Type type)
        {
            damage = damage - DEF;
            switch (type)
            {
                case Type.Electric:
                    damage = damage * 1 / 2;
                    break;
                case Type.Ground:
                    damage = damage * 2;
                    break;
                case Type.Flying:
                    damage = damage * 1 / 2;
                    break;
                case Type.Steel:
                    damage = damage * 1 / 2;
                    break;
                case Type.Giselle:
                    damage = damage * 2;
                    break;
                default:
                    break;
            }

            if (damage < 0)
                damage = LVL;
            PV = PV - damage;
            if (PV < 0) { PV = 0; }
        }

    }


}