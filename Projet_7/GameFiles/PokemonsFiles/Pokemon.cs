namespace Projet_7.GameFiles.PokemonsFiles
{
    public class Pokemon
    {

        private int _atk;
        private int _def;
        private int _pv;
        private int _pvMax;
        private int _pm;
        private int _lvl;
        private double _xp;
        private PokeType _type;
        private string _name;
        private string _art;
        private double _xpMax;

        public Pokemon()
        {
            PV = 0;
            PM = 0;
            _atk = 0;
            _def = 0;
            _type = PokeType.Normal;
            LVL = 0;
            Name = "Pokemon";

        }

        public int PV { get { return _pv; } set { _pv = value; } }
        public int PVMax { get { return _pvMax; } set { _pvMax = value; } }

        public int PM { get { return _pm; } set { _pm = value; } }
        public int PMMax { get; set; }

        public int LVL { get => _lvl; set { _lvl = value; } }

        public int ATK { get { return _atk; } set { _atk = value; } }
        public int DEF { get { return _def; } set { _def = value; } }
        public PokeType TYPE { get => _type; init { _type = value; } }

        public double XP { get => _xp; set { _xp = value; } }
        public double XPMax { get => 0.8 * Math.Pow(LVL, 3); set { _xpMax = value; } }

        public string Name { get => _name; protected set { _name = value; } }
        public string Art { get => _art; init { _art = value; } }
        public double Skill1 { get; set; }

        public double Skill2 { get; set; }

        public virtual void Hurt(int damage, PokeType type)
        {

        }
        public void Attack(Pokemon target, double skill)
        {

            target.Hurt((int)skill, target.TYPE);
        }

        public void Heal(int value)
        {
            PV += value;
            if (PV > PVMax)
                PV = PVMax;
        }


        public bool IsAlive()
        {
            return PV > 0;
        }


        public virtual void Draw()
        {
            Console.Write(_art);
        }
        public void LVLup()
        {
            LVL = LVL + 1;
            Heal(PVMax);
            PVMax = (int)(5 * Math.Log2(LVL) + PVMax);
            PMMax = (int)(5 * Math.Log2(LVL) + PMMax);
            Random randstat = new Random();
            _atk = _atk + randstat.Next(3) + 1;
            _def = _def + randstat.Next(3) + 1;
            PV = PVMax;
            PM = PMMax;

        }

    }

    public class Pikachu : Pokemon
    {
        public Pikachu()
        {
            PV = 95;
            PVMax = PV;
            PM = 50;
            PMMax = PM;
            ATK = 80;
            DEF = 50;
            TYPE = PokeType.Electric;
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
            TYPE = PokeType.Electric;
            LVL = 1;
            XPMax = 60;
            Name = "Pikachu";
            Art = "       ,___          .-;'\r\n       `\"-.`\\_...._/`.`\r\n    ,      \\        /\r\n .-' ',    / ()   ()\\\r\n`'._   \\  /()    .  (|\r\n    > .' ;,     -'-  /\r\n   / <   |;,     __.;\r\n   '-.'-.|  , \\    , \\\r\n      `>.|;, \\_)    \\_)\r\n       `-;     ,    /\r\n          \\    /   <\r\n           '. <`'-,_)\r\n            '._)";
            Skill1 = 1.5 * ATK;
            Skill2 = 2 * ATK;

            for (int i = 0; i < lvl; i++)
            {
                LVLup();
            }

        }



        public override void Hurt(int damage, PokeType type)
        {
            damage = damage - DEF;
            switch (type)
            {
                case PokeType.Electric:
                    damage = damage * 1 / 2;
                    break;
                case PokeType.Ground:
                    damage = damage * 2;
                    break;
                case PokeType.Flying:
                    damage = damage * 1 / 2;
                    break;
                case PokeType.Steel:
                    damage = damage * 1 / 2;
                    break;
                case PokeType.Giselle:
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
        public override void Draw()
        {
            Console.SetCursorPosition(0, 50 - 12);
            Console.Write(Art);
        }

    }

    public class PikachuDresseur : Pikachu
    {
        public PikachuDresseur()
        {
            PV = 95;
            PVMax = PV;
            PM = 50;
            PMMax = PM;
            ATK = 80;
            DEF = 50;
            TYPE = PokeType.Electric;
            LVL = 1;
            XPMax = 60;
            Name = "Pikachute";
            Art = "`;-.          ___,\r\n  `.`\\_...._/`.-\"`\r\n    \\        /      ,\r\n    /()   () \\    .' `-._\r\n   |)  .    ()\\  /   _.'\r\n   \\  -'-     ,; '. <\r\n    ;.__     ,;|   > \\\r\n   / ,    / ,  |.-'.-'\r\n  (_/    (_/ ,;|.<`\r\n    \\    ,     ;-`\r\n     >   \\    /\r\n    (_,-'`> .'\r\n         (_,'";
            Skill1 = 1.5 * ATK;
            Skill2 = 2 * ATK;
        }
        public PikachuDresseur(int lvl)
        {
            PV = 95;
            PVMax = PV;
            PM = 50;
            ATK = 80;
            DEF = 50;
            TYPE = PokeType.Electric;
            LVL = 1;
            XPMax = 60;
            Name = "PikachuDresseur";
            Art = "`;-.          ___,\r\n  `.`\\_...._/`.-\"`\r\n    \\        /      ,\r\n    /()   () \\    .' `-._\r\n   |)  .    ()\\  /   _.'\r\n   \\  -'-     ,; '. <\r\n    ;.__     ,;|   > \\\r\n   / ,    / ,  |.-'.-'\r\n  (_/    (_/ ,;|.<`\r\n    \\    ,     ;-`\r\n     >   \\    /\r\n    (_,-'`> .'\r\n         (_,'";
            Skill1 = 1.5 * ATK;
            Skill2 = 2 * ATK;

            for (int i = 0; i < lvl; i++)
            {
                LVLup();
            }

        }



        public override void Hurt(int damage, PokeType type)
        {
            damage = damage - DEF;
            switch (type)
            {
                case PokeType.Electric:
                    damage = damage * 1 / 2;
                    break;
                case PokeType.Ground:
                    damage = damage * 2;
                    break;
                case PokeType.Flying:
                    damage = damage * 1 / 2;
                    break;
                case PokeType.Steel:
                    damage = damage * 1 / 2;
                    break;
                case PokeType.Giselle:
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

        public override void Draw()
        {
            Console.SetCursorPosition(3 * Console.WindowWidth / 4, 37);
            Console.WriteLine("`;-.          ___,\r\n");
            Console.SetCursorPosition(3 * Console.WindowWidth / 4, 38);
            Console.WriteLine("  `.`\\_...._/`.-\"`\r\n");
            Console.SetCursorPosition(3 * Console.WindowWidth / 4, 39);
            Console.WriteLine("    \\        /      ,\r\n");
            Console.SetCursorPosition(3 * Console.WindowWidth / 4, 40);
            Console.WriteLine("    /()   () \\    .' `-._\r\n");
            Console.SetCursorPosition(3 * Console.WindowWidth / 4, 41);
            Console.WriteLine("   |)  .    ()\\  /   _.'\r\n");
            Console.SetCursorPosition(3 * Console.WindowWidth / 4, 42);
            Console.WriteLine("   \\  -'-     ,; '. <\r\n");
            Console.SetCursorPosition(3 * Console.WindowWidth / 4, 43);
            Console.WriteLine("    ;.__     ,;|   > \\\r\n");
            Console.SetCursorPosition(3 * Console.WindowWidth / 4, 44);
            Console.WriteLine("   / ,    / ,  |.-'.-'\r\n");
            Console.SetCursorPosition(3 * Console.WindowWidth / 4, 45);
            Console.WriteLine("  (_/    (_/ ,;|.<`\r\n");
            Console.SetCursorPosition(3 * Console.WindowWidth / 4, 46);
            Console.WriteLine("    \\    ,     ;-`\r\n");
            Console.SetCursorPosition(3 * Console.WindowWidth / 4, 47);
            Console.WriteLine("     >   \\    /\r\n");
            Console.SetCursorPosition(3 * Console.WindowWidth / 4, 48);
            Console.WriteLine("    (_,-'`> .'");
            Console.SetCursorPosition(3 * Console.WindowWidth / 4, 49);
            Console.WriteLine("         (_,'");

        }
    }

    public class Abo : Pokemon
    {

        public Abo(int lvl)
        {
            PV = 85;
            PVMax = PV;
            ATK = 60;
            DEF = 44;
            TYPE = PokeType.Poison;
            LVL = 1;
            XPMax = 60;
            Name = "Abo";
            Art = "                            __..._              \r\n                        ..-'      o.            \r\n                     .-'            :           \r\n                 _..'             .'__..--<     \r\n          ...--\"\"                 '-.           \r\n      ..-\"                       __.'           \r\n    .'                  ___...--'               \r\n   :        ____....---'                        \r\n  :       .'                                    \r\n :       :           _____                      \r\n :      :    _..--\"\"\"     \"\"\"--..__             \r\n:       :  .\"                      \"\"i--.       \r\n:       '.:                         :    '.     \r\n:         '--...___i---\"\"\"\"--..___.'      :     \r\n :                 \"\"---...---\"\"          :     \r\n  '.                                     :      \r\n    '-.                                 :       \r\n       '--...                         .'        \r\n         :   \"\"---....._____.....---\"\"          \r\n         '.    '.                               \r\n           '-..  '.                             \r\n               '.  :                            \r\n          fsc   : .'                            \r\n               /  :                             \r\n             .'   :                             \r\n           .' .--'                              \r\n          '--'";
            Skill1 = 1.5 * ATK;
            Skill2 = 2 * ATK;

            for (int i = 0; i < lvl; i++)
            {
                LVLup();
            }

        }


        public override void Hurt(int damage, PokeType type)
        {
            damage = damage - DEF;
            switch (type)
            {
                case PokeType.Fighting:
                    damage = damage * 1 / 2;
                    break;
                case PokeType.Fairy:
                    damage = damage * 1 / 2;
                    break;
                case PokeType.Bug:
                    damage = damage * 1 / 2;
                    break;
                case PokeType.Grass:
                    damage = damage * 1 / 2;
                    break;
                case PokeType.Poison:
                    damage = damage * 1 / 2;
                    break;
                case PokeType.Psychic:
                    damage = damage * 2;
                    break;
                case PokeType.Ground:
                    damage = damage * 2;
                    break;
                case PokeType.Giselle:
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
        public override void Draw()
        {
            Console.SetCursorPosition(0, 50 - 26);
            Console.Write(Art);
        }

    }

    public class Boustiflor : Pokemon
    {

        public Boustiflor(int lvl)
        {
            PV = 115;
            PVMax = PV;
            ATK = 90;
            DEF = 50;
            TYPE = PokeType.Grass;
            LVL = 1;
            XPMax = 60;
            Name = "Boustiflor";
            Art = "     /|\\\r\n     |||||\r\n     |||||\r\n /\\  |||||\r\n|||| |||||\r\n|||| |||||  /\\\r\n|||| ||||| ||||\r\n \\|`-'|||| ||||\r\n  \\__ |||| ||||\r\n     ||||`-'|||\r\n     |||| ___/\r\n     |||||\r\n     |||||\r\n-----------------";
            Skill1 = 1.5 * ATK;
            Skill2 = 2 * ATK;

            for (int i = 0; i < lvl; i++)
            {
                LVLup();
            }

        }


        public override void Hurt(int damage, PokeType type)
        {
            damage = damage - DEF;
            switch (type)
            {
                case PokeType.Water:
                    damage = damage * 1 / 2;
                    break;
                case PokeType.Fire:
                    damage = damage * 2;
                    break;
                case PokeType.Electric:
                    damage = damage * 1 / 2;
                    break;
                case PokeType.Ice:
                    damage = damage * 2;
                    break;
                case PokeType.Bug:
                    damage = damage * 2;
                    break;
                case PokeType.Grass:
                    damage = damage * 1 / 2;
                    break;
                case PokeType.Poison:
                    damage = damage * 2;
                    break;
                case PokeType.Ground:
                    damage = damage * 1 / 2;
                    break;
                case PokeType.Flying:
                    damage = damage * 2;
                    break;
                case PokeType.Giselle:
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
        public override void Draw()
        {
            Console.SetCursorPosition(0, 50 - 14);
            Console.Write(Art);
        }

    }

    public class Farfuret : Pokemon
    {

        public Farfuret(int lvl)
        {
            PV = 105;
            PVMax = PV;
            ATK = 95;
            DEF = 55;
            TYPE = PokeType.Dark;
            LVL = 1;
            XPMax = 60;
            Name = "Farfuret";
            Art = "                                   _,-/\\^---,\r\n               ;\"~~~~~~~~\";          _/;; ~~  {0 `---v\r\n             ;\" :::::   :: \"\\_     _/   ;;     ~ _../\r\n           ;\" ;;    ;;;       \\___/::    ;;,'~~~~\r\n         ;\"  ;;;;.    ;;     ;;;    ::   ,/\r\n        / ;;   ;;;______;;;;  ;;;    ::,/\r\n       /;;V_;; _-~~~~~~~~~~;_  ;;;   ,/\r\n      | :/ / ,/              \\_  ~~)/\r\n      |:| / /~~~=              \\;; \\~~=\r\n      ;:;{::~~~~~~=              \\__~~~=\r\n   ;~~:;  ~~~~~~~~~               ~~~~~~\r\n   \\/~~";
            Skill1 = 1.5 * ATK;
            Skill2 = 2 * ATK;

            for (int i = 0; i < lvl; i++)
            {
                LVLup();
            }

        }


        public override void Hurt(int damage, PokeType type)
        {
            damage = damage - DEF;
            switch (type)
            {
                case PokeType.Fighting:
                    damage = damage * 2;
                    break;
                case PokeType.Fairy:
                    damage = damage * 2;
                    break;
                case PokeType.Bug:
                    damage = damage * 2;
                    break;
                case PokeType.Psychic:
                    damage = damage * 0;
                    break;
                case PokeType.Ghost:
                    damage = damage * 1 / 2;
                    break;
                case PokeType.Dark:
                    damage = damage * 1 / 2;
                    break;
                case PokeType.Giselle:
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
        public override void Draw()
        {
            Console.SetCursorPosition(0, 50 - 12);
            Console.Write(Art);
        }

    }

    public class Chuchmur : Pokemon
    {

        public Chuchmur(int lvl)
        {
            PV = 114;
            PVMax = PV;
            ATK = 51;
            DEF = 23;
            TYPE = PokeType.Normal;
            LVL = 1;
            XPMax = 60;
            Name = "Chuchmur";
            Art = "   ,-.                                                 .\r\n    .` `.                                             .'|\r\n    ` `. `-._                     _,.--._            /  |\r\n     `  ..   `.                  /       `.        ,' , '\r\n      `  ` `.  `-._              | '\\\".     \\\\      /  / .\r\n       `. `   `.   `.          ,\\\"'---'      .   ,' ,'' |\r\n         ` `.    `.  `.       .             |  /  / /  F\r\n          `. .     `.  \\\\ ,..--|             |,'  / /  /\r\n            \\\\ `.     .  |      \\\\           ,.   / /  /\r\n             `._`._   j   .----.`._     _,` | ,\\\" / ,'\r\n                `._`\\\"`  ,',\\\"\\\"\\\"\\\"-.`.\\\"\\\"--' ,-\\\":+.-'.'\r\n               ,'     . |`._)   . L     ||_7\\\\+-'\r\n               /       | |       | |     .\\\\   \\\\.\r\n              /        |  .      | |      \\\\\\\\_,'j\r\n             .          ._ `----' /        `--\\\" '\r\n            j             \\\"--..--'              |\r\n           ,|                        ,-\\\".       |\r\n         ,' |                       /   |       '\r\n        /   '                       `..'    ,'   \\\\\r\n       /   j                               /      L\r\n      j    |                              .       |\r\n      |  _.'                              |     , |\r\n     `-' .                               |   ,'  '\r\n          |                               `.-'     .\r\n          |                                        |\r\n          |                                        j\r\n          '                                       .\r\n           `                                     /\r\n            `.                                  /\r\n         ______.                              ,'\r\n       ,'       `-._                     _,.'\\\"\\\"`--..\r\n      .         ___,+ -...._________,...<_          \\\\\r\n       .___,.-\\\"'                          `-._      |\r\n                                              `-....' ";
            Skill1 = 1.5 * ATK;
            Skill2 = 2 * ATK;

            for (int i = 0; i < lvl; i++)
            {
                LVLup();
            }

        }


        public override void Hurt(int damage, PokeType type)
        {
            damage = damage - DEF;
            switch (type)
            {
                case PokeType.Fighting:
                    damage = damage * 2;
                    break;
                case PokeType.Ghost:
                    damage = damage * 0;
                    break;
                case PokeType.Giselle:
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
        public override void Draw()
        {
            Console.SetCursorPosition(0, 50 - 33);
            Console.Write(Art);
        }
    }

    public class Flabebe : Pokemon
    {

        public Flabebe(int lvl)
        {
            PV = 94;
            PVMax = PV;
            ATK = 38;
            DEF = 39;
            TYPE = PokeType.Fairy;
            LVL = 1;
            XPMax = 60;
            Name = "Flabebe";
            Art = ".-.'  '.-.\r\n          .-(   \\  /   )-.\r\n         /   '..oOOo..'   \\\r\n ,       \\.--.oOOOOOOo.--./\r\n |\\  ,   (   :oOOOOOOo:   )\r\n_\\.\\/|   /'--'oOOOOOOo'--'\\\r\n'-.. ;/| \\   .''oOOo''.   /\r\n.--`'. :/|'-(   /  \\   )-'\r\n '--. `. / //'-'.__.'-;\r\n   `'-,_';//      ,  /|\r\n        '((       |\\/./_\r\n          \\\\  . |\\; ..-'\r\n           \\\\ |\\: .'`--.\r\n            \\\\, .' .--'\r\n             ))'_,-'`\r\n            //-'\r\n           // \r\n          //\r\n         |/";
            Skill1 = 1.5 * ATK;
            Skill2 = 2 * ATK;

            for (int i = 0; i < lvl; i++)
            {
                LVLup();
            }

        }


        public override void Hurt(int damage, PokeType type)
        {
            damage = damage - DEF;
            switch (type)
            {
                case PokeType.Fighting:
                    damage = damage * 1 / 2;
                    break;
                case PokeType.Poison:
                    damage = damage * 2;
                    break;
                case PokeType.Steel:
                    damage = damage * 2;
                    break;
                case PokeType.Dragon:
                    damage = damage * 1 / 2;
                    break;
                case PokeType.Dark:
                    damage = damage * 1 / 2;
                    break;
                case PokeType.Giselle:
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
        public override void Draw()
        {
            Console.SetCursorPosition(0, 50 - 19);
            Console.Write(Art);
        }
    }

    public class Picassault : Pokemon
    {

        public Picassault(int lvl)
        {

            PV = 85;
            PVMax = PV;
            ATK = 75;
            DEF = 30;
            TYPE = PokeType.Flying;
            LVL = 1;
            XPMax = 60;
            Name = "Picassault";
            Art = "         .   ,\r\n       '. '.  \\  \\\r\n      ._ '-.'. `\\  \\\r\n        '-._; .'; `-.'. \r\n       `~-.; '.       '.\r\n        '--,`           '.\r\n           -='.          ;\r\n .--=~~=-,    -.;        ;\r\n .-=`;    `~,_.;        /\r\n`  ,-`'    .-;         |\r\n   .-~`.    .;         ;\r\n    .;.-   .-;         ,\\\r\n      `.'   ,=;     .-'  `~.-._\r\n       .';   .';  .'      .'   '-.\r\n         .\\  ;  ;        ,.' _  a',\r\n        .'~\";-`   ;      ;\"~` `'-=.)\r\n      .' .'   . _;  ;',  ;\r\n      '-.._`~`.'  \\  ; ; :\r\n           `~'    _'\\\\_ \\\\_ \r\n                 /=`^^=`\"\"/`)-.\r\n                 \\ =  _ =     =\\\r\n                  `\"\"` `~-. =   ;";
            Skill1 = 1.5 * ATK;
            Skill2 = 2 * ATK;

            for (int i = 0; i < lvl; i++)
            {
                LVLup();
            }

        }


        public override void Hurt(int damage, PokeType type)
        {
            damage = damage - DEF;
            switch (type)
            {
                case PokeType.Electric:
                    damage = damage * 2;
                    break;
                case PokeType.Ground:
                    damage = damage * 0;
                    break;
                case PokeType.Fighting:
                    damage = damage * 1 / 2;
                    break;
                case PokeType.Ice:
                    damage = damage * 2;
                    break;
                case PokeType.Bug:
                    damage = damage * 1 / 2;
                    break;
                case PokeType.Grass:
                    damage = damage * 1 / 2;
                    break;
                case PokeType.Rock:
                    damage = damage * 2;
                    break;
                case PokeType.Giselle:
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
        public override void Draw()
        {
            Console.SetCursorPosition(0, 50 - 22);
            Console.Write(Art);
        }
    }

    public class Insolourdo : Pokemon
    {

        public Insolourdo(int lvl)
        {
            PV = 150;
            PVMax = PV;
            ATK = 70;
            DEF = 70;
            TYPE = PokeType.Normal;
            LVL = 1;
            XPMax = 60;
            Name = "Insolourdo";
            Art = "                           _     _\r\n   ,,,,,,,,,,,,,,,,,,,,,,,  \\   /\r\n / (  (  (  (  (  (  (  (  \\( = =)\r\n<  (  (  (  (  (  (  (  (  / ( ^ )\r\n \\ (__(__(__(__(__(__(__(__)   ~      -cfbd-\r\n   ^  ^  ^  ^  ^  ^  ^  ^  ^";
            Skill1 = 1.5 * ATK;
            Skill2 = 2 * ATK;

            for (int i = 0; i < lvl; i++)
            {
                LVLup();
            }

        }


        public override void Hurt(int damage, PokeType type)
        {
            damage = damage - DEF;
            switch (type)
            {
                case PokeType.Ghost:
                    damage = damage * 0;
                    break;
                case PokeType.Fighting:
                    damage = damage * 2;
                    break;
                case PokeType.Giselle:
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
        public override void Draw()
        {
            Console.SetCursorPosition(0, 50 - 6);
            Console.Write(Art);
        }
    }

    public class Funecire : Pokemon
    {

        public Funecire(int lvl)
        {
            PV = 100;
            PVMax = PV;
            ATK = 30;
            DEF = 55;
            TYPE = PokeType.Ghost;
            LVL = 1;
            XPMax = 60;
            Name = "Funecire";
            Art = "            )\r\n           (_)\r\n          .-'-.\r\n          |   |\r\n          |   |\r\n          |   |\r\n          |   |\r\n        __|   |__   .-.\r\n     .-'  |   |  `-:   :\r\n    :     `---'     :-'\r\n     `-._       _.-'\r\n         '\"\"\"\"\"\"";
            Skill1 = 1.5 * ATK;
            Skill2 = 2 * ATK;

            for (int i = 0; i < lvl; i++)
            {
                LVLup();
            }

        }


        public override void Hurt(int damage, PokeType type)
        {
            damage = damage - DEF;
            switch (type)
            {
                case PokeType.Fighting:
                    damage = damage * 0;
                    break;
                case PokeType.Normal:
                    damage = damage * 0;
                    break;
                case PokeType.Ghost:
                    damage = damage * 2;
                    break;
                case PokeType.Poison:
                    damage = damage * 1 / 2;
                    break;
                case PokeType.Bug:
                    damage = damage * 1 / 2;
                    break;
                case PokeType.Dark:
                    damage = damage * 2;
                    break;
                case PokeType.Giselle:
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
        public override void Draw()
        {
            Console.SetCursorPosition(0, 50 - 12);
            Console.Write(Art);
        }
    }

    public class Giselle : Pokemon
    {

        public Giselle(int lvl)
        {
            PV = 100;
            PVMax = PV;
            PM = 1000;
            ATK = 200;
            DEF = 200;
            TYPE = PokeType.Giselle;
            LVL = 1;
            XPMax = 60;
            Name = "Giselle";
            Art = "                                              _\r\n                                   .-.  .--''` )\r\n                                _ |  |/`   .-'`\r\n                               ( `\\      /`\r\n                               _)   _.  -'._\r\n                             /`  .'     .-.-;\r\n                             `).'      /  \\  \\\r\n                            (`,        \\_o/_o/__\r\n                             /           .-''`  ``'-.\r\n                             {         /` ,___.--''`\r\n                             {   ;     '-. \\ \\\r\n           _   _             {   |'-....-`'.\\_\\\r\n          / './ '.           \\   \\          `\"`\r\n       _  \\   \\  |            \\   \\\r\n      ( '-.J     \\_..----.._ __)   `\\--..__\r\n     .-`                    `        `\\    ''--...--.\r\n    (_,.--\"\"`/`         .-             `\\       .__ _)\r\n            |          (                 }    .__ _)\r\n            \\_,         '.               }_  - _.'\r\n               \\_,         '.            } `'--'\r\n                  '._.     ,_)          /\r\n                     |    /           .'\r\n                      \\   |    _   .-'\r\n                       \\__/;--.||-'\r\n                        _||   _||__   __\r\n                 _ __.-` \"`)(` `\"  ```._)\r\n                (_`,-   ,-'  `''-.   '-._)\r\n               (  (    /          '.__.'\r\n                `\"`'--'";
            Skill1 = 3.5 * ATK;
            Skill2 = 4 * ATK;

            for (int i = 0; i < lvl; i++)
            {
                LVLup();
            }

        }


        public override void Hurt(int damage, PokeType type)
        {
            damage = damage - DEF;
            switch (type)
            {
                case PokeType.Normal:
                    damage = damage / 4;
                    break;
                case PokeType.Fighting:
                    damage = damage / 4;
                    break;
                case PokeType.Flying:
                    damage = damage / 4;
                    break;
                case PokeType.Poison:
                    damage = damage / 4;
                    break;
                case PokeType.Ground:
                    damage = damage / 4;
                    break;
                case PokeType.Rock:
                    damage = damage / 4;
                    break;
                case PokeType.Bug:
                    damage = damage / 4;
                    break;
                case PokeType.Ghost:
                    damage = damage / 4;
                    break;
                case PokeType.Steel:
                    damage = damage / 4;
                    break;
                case PokeType.Fire:
                    damage = damage / 4;
                    break;
                case PokeType.Water:
                    damage = damage / 4;
                    break;
                case PokeType.Grass:
                    damage = damage / 4;
                    break;
                case PokeType.Electric:
                    damage = damage / 4;
                    break;
                case PokeType.Psychic:
                    damage = damage / 4;
                    break;
                case PokeType.Ice:
                    damage = damage / 4;
                    break;
                case PokeType.Dragon:
                    damage = damage / 4;
                    break;
                case PokeType.Dark:
                    damage = damage / 4;
                    break;
                case PokeType.Fairy:
                    damage = damage / 4;
                    break;
                case PokeType.Giselle:
                    damage = damage * 8;
                    break;
                default:
                    break;
            }

            if (damage < 0)
                damage = LVL;
            PV = PV - damage;
            if (PV < 0) { PV = 0; }
        }
        public override void Draw()
        {
            Console.SetCursorPosition(0, 50 - 28);
            Console.Write(Art);
        }
    }


}