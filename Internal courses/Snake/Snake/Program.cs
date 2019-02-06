using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Snake
{
	class Program
	{
		static void Main( string[] args )
		{
            int mapWidth = 80;
            int mapHeight = 50;
            Console.SetWindowSize(mapWidth, mapHeight);
			Console.SetBufferSize(mapWidth, mapHeight );

			Walls walls = new Walls( mapWidth,mapHeight );
			walls.Draw();

					
			Point p = new Point( 40, 25, '*' );
			Snake snake = new Snake( p, 4, Direction.DOWN );
			snake.Draw();

			Food foodCreator = new Food( mapWidth, mapHeight, '@' );
			Point food = foodCreator.CreateFood();
			food.Draw();

			while (true)
			{
				if ( walls.IsHit(snake) || snake.IsHitTail() )
				{
					break;
				}
				if(snake.Eat( food ) )
				{
					food = foodCreator.CreateFood();
					food.Draw();
				}
				else
				{
					snake.Move();
				}

				Thread.Sleep( 100 );
				if ( Console.KeyAvailable )
				{
					ConsoleKeyInfo key = Console.ReadKey();
					snake.HandleKey( key.Key );
				}
			}

			WriteGameOver();
			Console.ReadLine();
      }


		static void WriteGameOver()
		{
			int xOffset = 25;
			int yOffset = 8;
			Console.ForegroundColor = ConsoleColor.Red;
			Console.SetCursorPosition( xOffset, yOffset++ );
			WriteText( "G A M E   O V E R", xOffset + 1, yOffset++ );
		}

		static void WriteText( String text, int xOffset, int yOffset )
		{
			Console.SetCursorPosition( xOffset, yOffset );
			Console.WriteLine( text );
		}

	}
}
