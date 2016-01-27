using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            Func1(x);
            Console.WriteLine("call Func1 x = " + x);

            x = 1;
            Func2(x);
            Console.WriteLine("Call Func2 x = " + x);

            x = 1;
            Func3(x);
            Console.WriteLine("Call Func3 x = " + x);

            point p1 = new point(1, 3, '*');
            Console.WriteLine("          p1.x = " + p1.x + "      p1.y = " + p1.y);
            Move(p1,10, 10);
            Console.WriteLine("Call move p1.x = " + p1.x + "      p1.y = " + p1.y);

            point p2 = new point(4, 5, '#');
            Console.WriteLine("          p2.x = " + p2.x + "      p2.y = " + p2.y);
            p1 = p2;
            Console.WriteLine(" p1=p2         p1.x = " + p1.x + "      p1.y = " + p1.y);
            Console.WriteLine(" p1=p2         p2.x = " + p2.x + "      p2.y = " + p2.y);
            p2.x = 8;
            p2.y = 9;
            Console.WriteLine("8-9 p1=p2         p1.x = " + p1.x + "      p1.y = " + p1.y);
            Console.WriteLine("8-9 p1=p2         p2.x = " + p2.x + "      p2.y = " + p2.y);

            p1 = new point(1, 3, '*');
            Update(p1);
            Console.WriteLine("          p1.x = " + p1.x + "      p1.y = " + p1.y);






            //point p1 = new point(1,3,'*');
            //p1.Draw();

            //point p2 = new point(4,5,'#');
            //p2.Draw();

            Console.ReadLine();

        }
        public static void Func1(int value)
        {

        }

        public static void Func2(int value)
        {
            value = value + 1;
        }

        public static void Func3(int x)
        {
            x = x + 1;
        }

        public static void Move(point p,int dx,int dy)
        {
            p.x = p.x + dx;
            p.y = p.y + dy;
        }
        public static void Update(point p)
        {
            p = new point();
        }
    }
}
