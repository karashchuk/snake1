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

            Walls walls = new Walls (80, 25,'+');
            walls.Draw();
            Metka:

            //Отрисовка точек
            point p = new point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();
           
            FoodCreator foodCreator = new FoodCreator(80, 25,'$');
            point food = foodCreator.CreateFood();
            Console.ForegroundColor = ConsoleColor.Red;
            food.Draw();
            Console.ForegroundColor = ConsoleColor.White;


            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    Console.ForegroundColor = ConsoleColor.Red;
                    food.Draw();
                    Console.ForegroundColor = ConsoleColor.White;
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
            WriteGameOver(snake);
        Metka2:
            ConsoleKeyInfo key1 = Console.ReadKey();
            if (key1.Key == ConsoleKey.Y)
            {
                walls.ClearWalls(80, 25);
                goto Metka;
            }
            else if (key1.Key == ConsoleKey.N)
            {
                walls.ClearWalls(80, 25);
                WriteText("That's all!", 25, 10);
            }
            else
                goto Metka2;

            Console.ReadLine();


        }


        private static void WriteGameOver(Snake snake)
        {
            int xOff=25;
            int yOff=9;
            string myString;
            int SnakeLength = 3;
            SnakeLength = snake.Length();

            myString = "Length  = " + SnakeLength;
            Console.ForegroundColor = ConsoleColor.Green;
            WriteText("===================", xOff, yOff++);
            yOff++;
            WriteText("G A M E   O V E R", xOff+1, yOff++);
            yOff++;
            WriteText(myString, xOff + 3, yOff++);
            yOff++;
            WriteText("Еще раз?  Y/N", xOff + 3, yOff++);
            yOff++;
            WriteText("===================", xOff, yOff++);
        }

        private static void WriteText(string v1, int xOff, int yOff)
        {
            Console.SetCursorPosition(xOff, yOff);
            Console.Write(v1);
        }
    }
}
