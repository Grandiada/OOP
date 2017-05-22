using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace snake
{
    class Program
    {
        
        static void Main(string[] args)
        {
           Console.SetWindowSize(85, 30);
           Console.SetBufferSize(85, 30);
            walls Walls = new walls(80, 25);
            Walls.Draw();


            // отрисовка точек
            point p = new point(4, 5, '*');
            snake snake1 = new snake(p, 4, direction.RIGHT);
            snake1.Drow();
            //отрисовка еды
            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            point food = foodCreator.CreateFood();
            food.draw();

            while (true)

            {
                if (Walls.IsHit(snake1) || snake1.isHitTail())
                {
                    Console.Clear();
                    Console.WriteLine("game over. Special for OOP BSUIR");
                    break;
                }
                if (snake1.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.draw();
                }
                else
                {
                    snake1.Move();
                }
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake1.HandleKey(key.Key);
                }
                Thread.Sleep(100);

            }
            Console.ReadLine();

        }
    }
}
