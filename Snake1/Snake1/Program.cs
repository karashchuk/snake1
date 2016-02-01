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
            point p = new point(74, 5, '*');
            Snake snake = new Snake(p, 4, Direction.LEFT);
            snake.Drow();

            FoodCreator foodCreator = new FoodCreator(80, 25,'$');
            point food = foodCreator.CreateFood();
            food.Draw();

            while(true)
            {
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    //snake.Move();
                }

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandlyKey ( key.Key );
                }
                Thread.Sleep(100);
                snake.Move();
            }

            //Console.ReadLine();

        }

    }
}
