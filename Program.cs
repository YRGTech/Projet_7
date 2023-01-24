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
            /*var position = new SerializeTheObject
            {
                posX = 5,
                posY = 5
            };

            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(position, options);
            File.WriteAllText("t.json", jsonString);*/


            Game game = new Game();
            game.Run();

            /*string t = File.ReadAllText("t.json");
            SerializeTheObject loadString = JsonSerializer.Deserialize<SerializeTheObject>(t);*/

            
        }
        /*static XDocument XmlUsingPlainCode()
        {
            XDocument document = new XDocument
                (
                    new XDeclaration("1.0", "utf-8", "yes"),
                    new XComment("XML from plain code"),
                    new XElement("Courses")
                );

            return document;
        }*/
    }

}