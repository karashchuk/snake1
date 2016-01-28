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
            //point p1 = new point(1, 3, '*');
            //p1.Draw();

            //point p2 = new point(4, 5, '#');
            //p2.Draw();

            horosontalline line = new horosontalline(5, 15, 8, '#');
            line.hDraw();

            VerticalLine vline = new VerticalLine(5, 9, 19, '#');
            vline.vDraw();

            line = new horosontalline(5, 15, 19, '#');
            line.hDraw();

            vline = new VerticalLine(15, 9, 19, '#');
            vline.vDraw();




            Console.ReadLine();

        }

    }
}
