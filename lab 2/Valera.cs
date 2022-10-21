using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    internal class Valera
    {
        public int h, m, cf, t, c;

        public Valera(int h, int m, int cf, int t, int c)
        {
            Download_Stat(h, m, cf, t, c);
        }
        public int Alcohol { get { return m; } }
        public void Download_Stat(int h, int m, int cf, int t, int c)
        {
            this.h = h;
            this.m= m;  
            this.cf = cf;   
            this.t = t; 
            this.c = c;
        }
        public void Upload_Start(out int h, out int m, out int cf, out int t, out int c)
        {
            h = this.h;
            m = this.m;
            cf = this.cf;
            t = this.t;
            c = this.c;
        }
        public void Show_Stat()
        {
            Console.WriteLine($"Здоровье: {this.h}");
            Console.WriteLine($"Алкоголь: {this.m}");
            Console.WriteLine($"Жизнерадостность: {this.cf}");
            Console.WriteLine($"Усталость: {this.t}");
            Console.WriteLine($"Деньги: {this.c}");
        }
        public bool Exist()
        {
            if ((this.h <= 0) || (this.h > 100))
            {
                if (this.h <= 0)
                    return false;
                if (this.h > 100)
                    this.h = 100;
            }
            if ((this.m < 0) || (this.m > 100))
            {
                if (this.m < 0)
                    this.m = 0;
                if (this.m > 100)
                    return false;
            }
            if ((this.cf < -10) || (this.cf > 10))
            {
                if (this.cf < -10)
                    this.cf = -10;
                if (this.cf > 10)
                    this.cf = 10;
            }
            if ((this.t < 0) || (this.t > 100))
            {
                if (this.t < 0)
                    this.t = 0;
                if (this.t > 100)
                    return false;
            }
            if (c < 0)
                return false;

            return true;
        }

        public bool Life()
        {
            if (this.h<=0)
            {
                return false;
            }
            if (this.t>=100)
            {
                return false;
            }
            return true;
        }
        public bool Work()
        {
            if (this.m <50 && this.t <10 )
            {
                this.cf -=5;
                this.m -=30;
                this.c +=100;
                this.t += 70;
                return true;
            }
            return false;
        }
        public void Piece()
        {
            this.cf += 1;
            this.m -= 10;
            this.t += 10;
        }
        public void Vine_and_TV()
        {
            this.h -= 5;
            this.cf -= 1;
            this.m += 30;
            this.c -= 20;
            this.t += 10;
        }
        public void Bar()
        {
            this.h -= 10;
            this.cf += 1;
            this.m += 60;
            this.c -= 100;
            this.t += 40;
        }
        public void Drink_With_Debils()
        {
            this.h -= 80;
            this.cf += 5;
            this.m += 90;
            this.c -= 150;
            this.t += 80;
        }
        public void Sing_in_Subway()
        {
            this.cf += 1;
            this.m += 10;
            if (this.m<70 && this.m>40)
            {
                this.c += 60;
            }
            else
            {
                this.c += 10;
            }
            this.t += 20;
        }
        public void Sleep()
        {
            this.m -= 50;
            if (this.m >70 )
            {
                this.cf -= 70;
            }
            if (this.m < 30)
            {
                this.h += 90;
            }
            this.t -= 70;
        }

    }
}
