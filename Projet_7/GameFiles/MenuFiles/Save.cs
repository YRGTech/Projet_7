using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Projet_7.GameFiles.SaveFiles;
using static System.Net.Mime.MediaTypeNames;

namespace Projet_7.GameFiles.SaveFiles
{
    internal class Save
    {
        public Save() { }

        public void openSaveMenu(Game game)
        {
            Console.Clear();
            Console.WriteLine("Party Saved");
            Thread.Sleep(2500);


            var save = new SerializeTheObject(game.Pikachu,
                       game.Map.playerX, game.Map.playerY,
                       game.Potionnette.Amount, game.Potion.Amount, game.MaximaPocion.Amount,
                       game.Tortoise.Amount, game.Boeuf.Amount, game.Mage.Amount,
                       game.Pangolin.Amount, game.Bat.Amount);

            var options = new JsonSerializerOptions { WriteIndented = true };
            string SaveString = JsonSerializer.Serialize(save, options);
            File.WriteAllText("save.json", SaveString);

        }
    }
}
