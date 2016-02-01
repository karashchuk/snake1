using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);
            VerticalLine v1 = new VerticalLine(12, 0, 12, '&');
            //v1.Drow();
            point p = new point(4, 5, '*');
            Figure fSnake = new Snake(p, 4, Direction.RIGHT);
            //fSnake.Drow();
            Snake snake = (Snake)fSnake;

            horosontalline h1 = new horosontalline(0, 20, 14, '%');
            //h1.Drow();

            List<Figure> fList = new List<Figure>();
            fList.Add(fSnake);
            fList.Add(v1);
            fList.Add(h1);
            foreach (var f in fList)
            {
                f.Drow();
            }


        Console.ReadLine();

        }

        //static void Draw(Figure figure)
        //{
        //    figure.Drow();
        //}


    }
}
