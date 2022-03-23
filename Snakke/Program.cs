using Snakke;
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
			//int score = 0;
			Console.SetBufferSize(250, 80); //Функция для установления размера окна и чтобы не было возможности перемотки 

			Walls walls = new Walls(85, 25);
			walls.Draw();

			// Отрисовка точек			
			Point p = new Point(4, 5, '@', ConsoleColor.Green); // функция согдания точки 
			Snake snake = new Snake(p, 4, Direction.RIGHT); // создание змейки с размеров 4 точки и направление в право 
			snake.Draw(); // отрисовка змейки на поле
			FoodCreator foodCreator = new FoodCreator(85, 25, '$', ConsoleColor.White); // Создание еды в приделах рамки 
			Point food = foodCreator.CreateFood(); // вызов метода создания еды и создания точки 
			food.Draw(); // отрисовка точки(еды) на полн 
			Score score = new Score(0, 1);
			score.speed = 350;
			score.vivodScore();
			Params settings = new Params();
			Sounds soundeat = new Sounds(settings.GetResourceFolder());
			Sounds sounddeath = new Sounds(settings.GetResourceFolder());

			while (true) // бесконечный цикл 
			{
				if (walls.IsHit(snake) || snake.IsHitTail()) // если Змейка коснулась стенки или хвоста то игра заканчивается 
				{
					sounddeath.Play("Death.mp3");
					break; // остановка программы 
					
				}
				if (snake.Eat(food))  //если Змейка косается точки еды то появляется новая еда в новой точке
				{
					soundeat.Play("Eat.mp3");
					food = foodCreator.CreateFood(); // вызов метода появыления еды на экране 
					food.Draw();// отрисовкк еды на экране 
					score.Scoree();
					score.vivodScore();
					if (score.Scoree())
					{
						score.speed -= 10;
					}
				}
				else // движение змейки
				{
					snake.Move(); // движение змейки 
				}

				Thread.Sleep(score.speed); // скорость задержки перемещения точек по экрану тоесть скорость змейки не меняется пока не будет нажата клавиша 
				if (Console.KeyAvailable) // проверка на то была ли нажата клавиша 
				{
					ConsoleKeyInfo key = Console.ReadKey(); // получает значение нажатой клавиши 
					snake.HandleKey(key.Key); // вызов метода проверки нажатия клавишь 
				}
			}
			WriteGameOver();
			Console.ReadLine();// конец программы 
		}
		static void WriteGameOver()// заставка конца игры (Надо добавить вывод баллов и уровня)
		{
			int xOffset = 32;
			int yOffset = 9;
			Console.ForegroundColor = ConsoleColor.White;
			Console.SetCursorPosition(xOffset, yOffset++);
			WriteText("=====================", xOffset, yOffset++);
			WriteText(" G A M E    O V E R ", xOffset, yOffset++);
			//WriteText("$Your score is {score} ", xOffset, yOffset++);
			WriteText("=====================", xOffset, yOffset++);
		}
		static void WriteText(String text, int xOffset, int yOffset)
		{
			Console.SetCursorPosition(xOffset, yOffset);
			Console.WriteLine(text);
		}

	}


		

	}

