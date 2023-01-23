using System.Xml.Serialization;
using System.IO;
using System.Xml;
using System;

using static Serialized;
using System.Xml.Linq;

namespace Projet_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string xmlDocPath = "C:/Users/mleconte/source/Projet_7/xmlFromPlainCode.xml";

            //Game game = new Game();
            //game.Run();

            //appelle la fonction
            /*XDocument xmlFromPlainCode = XmlUsingPlainCode();*/
            //Save dans le doc XML
            //xmlFromPlainCode.Save(xmlDocPath);

            XDocument loadedDocument = XDocument.Load("C:/Users/mleconte/source/Projet_7/xmlFromPlainCode.xml");

            // Console Output for demo
            /*Console.WriteLine("------ # Generated XML from code # ------");
            Console.WriteLine(xmlFromPlainCode);
            Console.WriteLine();*/
            Console.WriteLine("------ # Loaded XML Document # ------");
            Console.WriteLine(loadedDocument);

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