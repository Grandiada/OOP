using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class VerticalLine: figure
    {
      
        public VerticalLine(int yUP, int yDown, int x, char sym)
        {
            pList = new List<point>();
            for (int y = yUP; y <= yDown; y++)
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
