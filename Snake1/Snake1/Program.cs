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
            point p1 = new point(1,3,'*');
            p1.Draw();

            point p2 = new point(4,5,'#');
            p2.Draw();

            //point p3 = new point (7,12,)

            List<int> Numlist = new List<int>();
            Numlist.Add(0);
            Numlist.Add(1);
            Numlist.Add(2);

            int x = Numlist[0];
            int y = Numlist[1];
            int z = Numlist[2];

            foreach(int i in Numlist)
            {
                Console.WriteLine(i);
            }

            Numlist.RemoveAt(0);

            List<point> pList= new List<point>();

            pList.Add(p1);
            pList.Add(p2);

            List<Char> CharList = new List<Char>();
            CharList.Add('*');
            CharList.Add('#');
            CharList.Add('$');
            CharList.Add('&');

            point p3 = new point(12, 5, CharList[2]);
            p3.Draw();

            pList.Add(p3);

            point p4 = new point(15, 5, CharList[3]);
            p4.Draw();

            pList.Add(p4);

            Console.ReadLine();

        }

    }
}
