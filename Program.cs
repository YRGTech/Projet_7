using System.Xml.Serialization;
using System.IO;
using System.Xml;
using System;

using static Serialized;
using System.Xml.Linq;
using System.Text.Json;

namespace Projet_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.Run();

        }
    }

}