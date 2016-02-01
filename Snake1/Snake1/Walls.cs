using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake1
{
    class Walls
    {
        List<Figure> wallList;

        public Walls (int mapWidht,int mapHight, char map_sym)
        {
            wallList = new List<Figure>();

            //Отрисовка рамки
            horosontalline upline = new horosontalline(0, mapWidht-2, 0, map_sym);
            horosontalline downline = new horosontalline(0, mapWidht-2, mapHight-1, map_sym);
            VerticalLine leftline = new VerticalLine(0, 0, mapHight-1, map_sym);
            VerticalLine rightline = new VerticalLine(mapWidht-2, 0, mapHight-1, map_sym);
            wallList.Add(upline);
            wallList.Add(downline);
            wallList.Add(leftline);
            wallList.Add(rightline);

        }

        internal bool IsHit(Figure figure)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }

        public void Draw()
        {
            foreach (var wall in wallList)
            {
                wall.Drow();
            }
        }

    }
}
