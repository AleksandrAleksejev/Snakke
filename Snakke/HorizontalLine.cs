using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class HorizontalLine : Figure // горизонтальная линия наследуется фигурой 
	{
		public HorizontalLine(int xLeft, int xRight, int y, char sym) // конструктор для создания линий поля игры 
		{
			pList = new List<Point>(); // список точек 
			for (int x = xLeft; x <= xRight; x++)// цикл создания горизонтальных точек 
			{
				Point p = new Point(x, y, sym, ConsoleColor.White);// создание точек с нужными координатами 
				pList.Add(p); // добавления точек в список 
			}
		}
	}
}