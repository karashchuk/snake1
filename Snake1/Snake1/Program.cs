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



            Console.ReadLine();

        }

    }
}
