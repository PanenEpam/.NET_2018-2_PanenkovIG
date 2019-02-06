using System;
namespace Snake
{
    public class Food : Figure
    {

        int mapX;
        int mapY;
        char sym;

        Random random = new Random();

        public Food(int _mapX, int _mapY, char _sym)
        {
            mapX = _mapX;
            mapY = _mapY;
            sym = _sym;
        }

        public Point CreateFood()
        {
            int x = random.Next(2, mapX - 2);
            int y = random.Next(2, mapY - 2);
            return new Point(x, y, sym);
        }
    }
}
