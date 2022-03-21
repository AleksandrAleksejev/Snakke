using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class Point // класс хранит данные . логическое обьединение 3 переменных в новый тип данных 
	{
		public int x;
		public int y;
		public char sym;
		public ConsoleColor color;

		public Point()// пустой конструктор 
		{
		}

		public Point(int x, int y, char sym, ConsoleColor color_) // Конструктор вызывания функции для создания точки 
		{
			this.x = x;
			this.y = y;
			this.sym = sym;
			color = color_;
		}

		public Point(Point p, ConsoleColor color_) // Конструктор чтобы задавать  точки с помощью другой точки 
		{
			x = p.x;
			y = p.y;
			sym = p.sym;
			color = color_;
		}

		public void Move(int offset, Direction direction) // конструктор чтобы здвигать точки в определенных направленияз 
		{
			if (direction == Direction.RIGHT) // если значение direction равно право то координата икс увеличивается на размер смещения 
			{
				x = x + offset;
			}
			else if (direction == Direction.LEFT) // если координата влево то икс уменьшится на росстаяние offset
			{
				x = x - offset;
			}
			else if (direction == Direction.UP)
			{
				y = y - offset;
			}
			else if (direction == Direction.DOWN)
			{
				y = y + offset;
			}
		}

		public bool IsHit(Point p) // метод который проверяет есть ли пересечение по координатам текущей точки и точкой заданного аргумента  
		{
			return p.x == this.x && p.y == this.y;
		}

		public void Draw()
		{
			Console.SetCursorPosition(x, y);
			Console.Write(sym);
			Console.ForegroundColor = color;
		}

		public void Clear() // метод для того чтобы убрать последнюю точку экрана 
		{
			sym = ' '; // символ пробел
			Draw(); // рисует символ пробел
		}

		public override string ToString()
		{
			return x + ", " + y + ", " + sym;
		}
	}
}
