using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake1
{
    class horosontalline : Figure
    {
        public horosontalline(int xLeft,int XRight, int y, Char sym)
        {
            pList = new List<point>();
            for (int x = xLeft; x <= XRight; x++)
            {
                point p = new point(x, y, sym);
                pList.Add(p);
            }

           
        }

    }
}
