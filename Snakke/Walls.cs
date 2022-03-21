using Snakke;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class Walls
	{
		List<Figure> wallList;

		public Walls(int mapWidth, int mapHeight) // конструктор принимающий габариты карты 
		{
			wallList = new List<Figure>();

			// Отрисовка рамочки
			//на основе габаритов рисует гаризонтальные и вертикальные линии 
			HorizontalLine upLine = new HorizontalLine(0, mapWidth - 2, 0, '+');
			HorizontalLine downLine = new HorizontalLine(0, mapWidth - 2, mapHeight - 1, '+');
			VerticalLine leftLine = new VerticalLine(0, mapHeight - 1, 0, '+');
			VerticalLine rightLine = new VerticalLine(0, mapHeight - 1, mapWidth - 2, '+');
			// создав линии мы добвляем их в список которых хранится в данном класса 
			wallList.Add(upLine);
			wallList.Add(downLine);
			wallList.Add(leftLine);
			wallList.Add(rightLine);
			Params settings = new Params();
			Sounds sound = new Sounds(settings.GetResourceFolder());
			sound.Play("Game.mp3");
			Sounds soundeat = new Sounds(settings.GetResourceFolder());
		}

		internal bool IsHit(Figure figure) // функция для проверки столкнулась ли змейка со стеной
		{
			foreach (var wall in wallList)// проверка на пересечение точек 
			{
				if (wall.IsHit(figure)) // если змейка столкнулось со стенкой  то 
				{
					return true; // возвращает тру и запускается бесконечный цикл
				}
			}
			return false; // возвращает знвчение Фолс
		}

		public void Draw() // метод где по очередно пробегается по всем фигурам и 
		{
			foreach (var wall in wallList)
			{
				wall.Draw(); // вызывает для них метод Draw
			}
		}
	}
}
