using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    internal class SaveLoader
    {
        public void Load(out int health, out int alcohol, out int happiness, out int fatigue, out int money)
        {
            string csv_data = File.ReadAllText("save.csv");
            int[] data = Array.ConvertAll(csv_data.Split(';'), int.Parse);

            health = data[0];
            alcohol = data[1];
            happiness = data[2];
            fatigue = data[3];
            money = data[4];
        }
        public void Save(int health, int alcohol, int happiness, int fatigue, int money)
        {
            string csv_data = health.ToString() + ";" +
                              alcohol.ToString() + ";" +
                              happiness.ToString() + ";" +
                              fatigue.ToString() + ";" +
                              money.ToString();
            File.WriteAllText("save.csv", csv_data);
        }
    }
}
