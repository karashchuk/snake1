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

            //Отрисовка рамки
            horosontalline upline = new horosontalline(0, 78, 0, '+');
            horosontalline downline = new horosontalline(0, 78, 24, '+');
            VerticalLine leftline = new VerticalLine(0, 0, 24, '+');
            VerticalLine rightline = new VerticalLine(78, 0, 24, '+');
            upline.Drow();
            downline.Drow();
            leftline.Drow();
            rightline.Drow();

            //Отрисовка точек
            point p = new point(4, 5, '%');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();

            while(true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandlyKey(key.Key);
                }
                Thread.Sleep(100);
                snake.Move();
            }

            Console.ReadLine();

        }

    }
}
