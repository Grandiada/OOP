using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class point
    {

        public int x;
        public int y;
        public char sym;
        public point(int x,int y, char sym)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
        }
        public point(point P)
        {
            x = P.x;
            y = P.y;
            sym = P.sym;
        }
        public void move(int offset, direction Direction)
        {
            if (Direction == direction.RIGHT)
            {
                x += offset;
            }
            else if (Direction == direction.LEFT)
            {
                x -= offset;
            }
            else if (Direction == direction.UP)
            {
                y -= offset;
            }
            else if (Direction == direction.DOWN)
            {
                y += offset;
            }
        }

        public void Clear()
        {
            sym = ' ';
            draw();
        }

        public override string ToString()
        {
            return x + ", " + y + ", " + sym;
        }
        public void draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public bool IsHit(point p)
        {
            return p.x == this.x && p.y == this.y;
        }
    }
}
