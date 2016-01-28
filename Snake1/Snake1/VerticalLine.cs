﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake1
{
    class VerticalLine
    {
        List<point> pList;
        public VerticalLine (int x, int yUp,int yDown,char sym)
        {
            pList = new List<point>();
            for (int y = yUp; y <= yDown; y++)
            {
                point p = new point(x, y, sym);
                pList.Add(p);
            }
        }

        public void vDraw()
        {
            foreach(point p in pList)
            {
                p.Draw();
            }
        }

    }
}
