using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    internal class Message
    {
        public void Warning(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        public void Bad_Event(string message)
        { 
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        public void Good_Event(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        public void Job()
        {
            Good_Event("Работа выполнена!");
            Good_Event("+100 долларов ");
            Bad_Event("-30 алкоголя ");
            Bad_Event("+70 усталости ");
            Bad_Event("-5 жизнерадостности\n");
        }
        public void Job_Failed()
        {
            Warning("Вы слишком пьяны, либо устали!\n");
        }
        public void Piece()
        {
            Good_Event("Иногда природа восхитительна!");
            Bad_Event("-10 алкоголя");
            Bad_Event("+10 усталости");
            Good_Event("+1 жизнерадостность\n");
        }
        public void Drink_Vine_TV()
        {
            Good_Event("Ого, это все таки был дворецкий. Вы посмотрели сериал:");
            Bad_Event("-5 здоровья");
            Bad_Event("-20 долларов");
            Bad_Event("+30 алкоголя");
            Bad_Event("+10 усталости");
            Bad_Event("-1 жизнерадостность\n");
            
        }
        public void Bar()
        {
            Good_Event("Вы зажгли в баре:");
            Bad_Event("-100 долларов");
            Bad_Event("+60 алкоголя");
            Bad_Event("+40 усталости");
            Good_Event("+1 жизнерадостность\n");
        }
        public void Drink_With_Debils()
        {
            Bad_Event("Вы выпили со своими маргиналами, думаю утром это вам аукнется:");
            Bad_Event("-80 здоровья");
            Bad_Event("-150 долларов");
            Bad_Event("+90 алкоголя");
            Bad_Event("+80 усталости");
            Good_Event("+5 жизнерадостности\n");
        }
        public void Sing(int p)
        {
            if ((p > 40) && (p < 70))
            {
                Good_Event("Это было просто шикарно: ");
                Good_Event("+60 долларов\n");
                
            }
            else
            {
                Good_Event("У тебя замечательный голос людям в метро понравилось твое пение: ");
                Good_Event("+10 долларов\n");
            }
            Bad_Event("+10 алкоголя");
            Bad_Event("+20 усталости");
            Good_Event("+1 жизнерадостность\n");
        }
        
        public void Sleep(int p)
        {
            if (p>70)
            {
                Bad_Event("Вы были очень пьяны и проснулись с жесточайшим похмельем(");
                Bad_Event("-3 жизнерадостности");
            }
            else if(p<30)
            {
                Good_Event("Вы замечательно поспали и готовы к новым свершения!");
                Good_Event("+90 здоровья");
            }
            Good_Event("Утро может быть и не задалось, но зато вы больше не чувствуете усталость)");
            Bad_Event("-50 алкоголя");
            Good_Event("-70 усталости\n");
        }
        public void Info()
        {
            Console.WriteLine("1-сходить на работу\t");
            Console.WriteLine("2-созерцать природу\t");
            Console.WriteLine("3-пить вино и смотреть сериал\t");
            Console.WriteLine("4-сходить в бар\t");
            Console.WriteLine("5-выпить с маргиналами\t");
            Console.WriteLine("6-спеть в метро\t");
            Console.WriteLine("7-поспать\t");
            Console.WriteLine("8-сохранить\t");
            Console.WriteLine("9-загрузить\t");
            Console.WriteLine("10-выйти\t");
        }
        public void Save()
        {
            Good_Event("Игра сохранена.\n");
        }

        public void Load()
        {
            Good_Event("Игра загружена\n");
        }
    }
}
