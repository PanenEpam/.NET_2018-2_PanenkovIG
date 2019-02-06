using System;
using System.Threading;

namespace Snake
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int mapWight = 80;
            int mapHeight = 40;

            Console.SetWindowSize(mapWight, mapHeight);
            Console.SetBufferSize(mapWight, mapHeight);

            HorizontalLine upLine = new HorizontalLine(0, mapWight - 2, 0, '#');
            HorizontalLine downLine = new HorizontalLine(0, mapWight - 2, mapHeight - 1, '#');
            VerticalLine leftLine = new VerticalLine(0, mapHeight - 1, 0, '#');
            VerticalLine rightLine = new VerticalLine(0, mapHeight - 1, mapWight - 2, '#');
            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();


            Point p = new Point(3, 4, '*');
            Snake snake = new Snake(p, 3, Directoin.RIGHT);
            snake.Draw();
            snake.Move();

            Food foodCreator = new Food(mapWight, mapHeight, '@');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.Rotation(key.Key);
                }
            }
        }
    }
}
