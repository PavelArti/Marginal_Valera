using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    internal class Game
    {
        public void Menu(int h, int m, int cf, int t, int c)
        {
            Valera valera = new Valera(h, m, cf, t, c);
            Message message = new Message();
            bool exe = true;

            while (exe)
            {
                int pre_hp, pre_al, pre_hap, pre_fat, pre_m;
                valera.Upload_Start(out pre_hp, out pre_al, out pre_hap, out pre_fat, out pre_m);
                valera.Show_Stat();
                Console.WriteLine();
                message.Info();
                string action = Console.ReadLine();
                Console.Clear();
                switch (action)
                {
                    case "1":
                        if (!valera.Work())
                        {
                            message.Job_Failed();
                        }
                        else
                        {
                            message.Job();
                        }
                        break;
                    case "2":
                        valera.Piece();
                        message.Piece();
                        break;
                    case "3":
                        valera.Vine_and_TV();
                        message.Drink_Vine_TV();
                        break;
                    case "4":
                        valera.Bar();
                        message.Bar();
                        break;
                    case "5":
                        valera.Drink_With_Debils();
                        message.Drink_With_Debils();
                        break;
                    case "6":
                        valera.Sing_in_Subway();
                        message.Sing(valera.Alcohol);
                        break;
                    case "7":
                        valera.Sleep();
                        message.Sleep(valera.Alcohol);
                        break;
                    default:
                        Console.WriteLine("Error! Wrong input");
                        break;
                    case "8":
                        SaveLoader save = new SaveLoader();
                        save.Save(pre_hp, pre_al, pre_hap, pre_fat, pre_m);
                        message.Save();
                        break;
                    case "9":
                        SaveLoader lave = new SaveLoader();
                        lave.Load(out pre_hp, out pre_al, out pre_hap, out pre_fat, out pre_m);
                        valera.Download_Stat(pre_hp, pre_al, pre_hap, pre_fat, pre_m);
                        message.Load();
                        break;
                    case "10":
                        exe = false;
                        break;
                }
                if (!valera.Exist())
                {
                    valera.Download_Stat(pre_hp, pre_al, pre_hap, pre_fat, pre_m);
                    Console.Clear();
                    message.Bad_Event("Это действие приведет к завершению игры!! Выберете другое действие. Для вас стараемся)\n");
                }
            }
        }

	}
}

