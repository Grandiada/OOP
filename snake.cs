using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class snake : figure
    {
        direction Direction;
        //0-
        public snake( point tail, int lenght, direction _Direction)
        {
            Direction = _Direction;
            pList = new List<point>();
            for(int i = 0; i < lenght; i++)
            {
                point p = new point(tail);
                p.move(i, Direction);
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
            head.draw();
        }

        internal bool isHitTail()
        {
            var head = pList.Last();
            for (int i = 0; i < pList.Count - 2; i++)
            {
                if (head.IsHit(pList[i]))
                    return true;
            }
            return false;
        }

        public point GetNextPoint()
        {
            point head = pList.Last();
            point nextPoint = new point(head);
            nextPoint.move(1, Direction);
            return nextPoint;

        }
        public void HandleKey(ConsoleKey Key)
        {
            if (Key == ConsoleKey.LeftArrow)
                Direction = direction.LEFT;
            else if (Key == ConsoleKey.RightArrow)
                Direction = direction.RIGHT;
            else if (Key == ConsoleKey.UpArrow)
                Direction = direction.UP;
            else if (Key == ConsoleKey.DownArrow)
                Direction = direction.DOWN;
        }

        internal bool Eat(point food)
        {
            point head = GetNextPoint();
            if (head.IsHit(food))
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
