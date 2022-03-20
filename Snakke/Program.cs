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
            Console.SetBufferSize(250, 80); //Функция для установления размера окна и чтобы не было возможности перемотки 

			Walls walls = new Walls(80, 25);
			walls.Draw();

			// Отрисовка точек			
			Point p = new Point(4, 5, '*'); // функция согдания точки 
			Snake snake = new Snake(p, 4, Direction.RIGHT); // создание змейки с размеров 4 точки и направление в право 
			snake.Draw(); // отрисовка змейки на поле 

			FoodCreator foodCreator = new FoodCreator(80, 25, '$'); // Создание еды в приделах рамки 
			Point food = foodCreator.CreateFood(); // вызов метода создания еды и создания точки 
			food.Draw(); // отрисовка точки(еды) на полн 

			while (true) // бесконечный цикл 
			{
				if (walls.IsHit(snake) || snake.IsHitTail()) // если Змейка коснулась стенки или хвоста то игра заканчивается 
				{
					break; // остановка программы 
				}
				if (snake.Eat(food))  //если Змейка косается точки еды то появляется новая еда в новой точке
				{
					food = foodCreator.CreateFood(); // вызов метода появыления еды на экране 
					food.Draw();// отрисовкк еды на экране 
				}
				else // движение змейки
				{
					snake.Move(); // движение змейки 
				}

				Thread.Sleep(150); // скорость задержки перемещения точек по экрану тоесть скорость змейки не меняется пока не будет нажата клавиша 
				if (Console.KeyAvailable) // проверка на то была ли нажата клавиша 
				{
					ConsoleKeyInfo key = Console.ReadKey(); // получает значение нажатой клавиши 
					snake.HandleKey(key.Key); // вызов метода проверки нажатия клавишь 
				}
			}
			Console.ReadLine();// конец программы 
		}
	
		


		

	}
}
