using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CavalosTrabalho
{
    public static class SaveLoad
    {
        //Save Game
        public static void SaveGame(Cavalo g)
        {

            string fileName = "SaveGame.txt";

            if (File.Exists(fileName))
            {
                //Console.WriteLine("Deleting old file");
                File.Delete(fileName);
            }

            FileStream fileStream = File.Create(fileName);
            BinaryFormatter f = new BinaryFormatter();

            f.Serialize(fileStream, g);


            fileStream.Close();

        }

        //Carregar
        public static Cavalo LoadGame()
        {

            string fileName = "MuseuGuardo.txt";

            if (File.Exists(fileName))
            {
                FileStream fileStream = File.OpenRead(fileName);
                BinaryFormatter f = new BinaryFormatter();

                return f.Deserialize(fileStream) as Cavalo;
            }
            else
            {
                return new Program();
            }

        }
    }
}
