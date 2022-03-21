using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class VerticalLine : Figure // вертикальная линия наследуется фигурой 
	{
		public VerticalLine(int yUp, int yDown, int x, char sym) // конструктор для создания линий поля игры 
		{
			pList = new List<Point>(); // список точек 
			for (int y = yUp; y <= yDown; y++)// цикл создания Вертикальных точек
			{
				Point p = new Point(x, y, sym, ConsoleColor.White);// создание точек с нужными координатами 
				pList.Add(p); // добавления точек в список 
			}
		}
	}
}
