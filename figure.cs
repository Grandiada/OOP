using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class figure
    {
     protected List<point> pList;
        internal bool IsHit(figure Figure)
        {
            foreach (var p in pList){
                if (Figure.IsHit(p))
                    return true;

            }
            return false;
        }
        private bool IsHit(point Point)
        {
            foreach (var p in pList)
            {
                if (p.IsHit(Point))
                    return true;
            }
            return false;
        }
        public virtual void Drow()
        {
            foreach (point p in pList)
            {
                p.draw();
            }
        }
    }
}
