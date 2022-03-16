using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Snake
{
	class Program
	{
		static void Main(string[] args)
		{
            Console.SetBufferSize(250, 80);

			Walls walls = new Walls(80, 25);
			walls.Draw();

			// Отрисовка точек			
			Point p = new Point(4, 5, '*');
			Snake snake = new Snake(p, 4, Direction.RIGHT);
			snake.Draw();

			FoodCreator foodCreator = new FoodCreator(80, 25, '$'); // Создание еды в приделах рамки 
			Point food = foodCreator.CreateFood();
			food.Draw();

			while (true)
			{
				if (walls.IsHit(snake) || snake.IsHitTail()) // если Змейка коснулась стенки то игра заканчивается 
				{
					break;
				}
				if (snake.Eat(food))  //если Змейка косается точки еды то появляется новая еда в новой точке
				{
					food = foodCreator.CreateFood();
					food.Draw();
				}
				else // движение змейуи 
				{
					snake.Move(); // 
				}

				Thread.Sleep(150); // скорость змейки 
				if (Console.KeyAvailable)
				{
					ConsoleKeyInfo key = Console.ReadKey();
					snake.HandleKey(key.Key);
				}
			}
			Console.ReadLine();
		}
	
		


		

	}
}
