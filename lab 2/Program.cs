using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Health = 100, Mana = 0, Cheerfulness = 0, Tierd = 0, Cash = 0;
            bool exe = true;
            while (exe)
            {
                Console.WriteLine("Добро пожоловать в маргинала валеру!");
                Console.WriteLine("1-играть. 2-информация. 3-выход");
                string num = Console.ReadLine();
                Console.Clear();
                switch (num)
                {
                    case "1":
                        Game game = new Game();
                        game.Menu(Health, Mana, Cheerfulness, Tierd, Cash);
                        break;
                    case "2":
                        Console.WriteLine("Это игра про маргинала Валеру в которой вашей задачей является управлять валерой и его жизнью");
                        break;
                    case "3":
                        exe = false;
                        break;
                    default:
                        Console.WriteLine("Ошибка");
                        break;
                }
            }
        }
    }
}
