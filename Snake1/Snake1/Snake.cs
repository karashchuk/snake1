using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake1
{
    class Snake:Figure
    {
        Direction direction;

        public Snake(point tail, int length, Direction _direction)
        {
            direction = _direction;

            pList = new List<point>();
            for (int i =0; i< length;i++)
            {
                point p = new point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        internal void Move()
        {
            point tail = pList.First();
            pList.Remove(tail);
            point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();

            //throw new NotImplementedException();
        }
        public point GetNextPoint()
        {
            point head = pList.Last();
            point NextPoint = new point(head);
            NextPoint.Move(1, direction);
            return NextPoint;
        }

        public void HandlyKey (ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                direction = Direction.LEFT;
            else if (key == ConsoleKey.RightArrow)
                direction = Direction.RIGHT;
            else if (key == ConsoleKey.UpArrow)
                direction = Direction.UP;
            else if (key == ConsoleKey.DownArrow)
                direction = Direction.DOWN;

        }

        internal bool Eat(point food)
        {
            point head = GetNextPoint();
            //if(head.IsHit(food))
            if (head.x == food.x && head.y == food.y)
            {
                food.sym = head.sym;
                pList.Add(food);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
