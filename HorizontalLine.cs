using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class HorizontalLine : figure
    {

        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        {
            pList = new List<point>();
            for (int x = xLeft; x <= xRight; x++)
            {
                point p = new point(x, y, sym);
                pList.Add(p);
            }

        }
        public override void Drow()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            base.Drow();
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
