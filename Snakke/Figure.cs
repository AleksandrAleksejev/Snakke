using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class Figure // класс который будет использоваться в наследники в других классах 
	{
		protected List<Point> pList;

		public void Draw()// конструктор для отрисовки точек на экране 
		{
			foreach (Point p in pList)
			{
				p.Draw();
			}
		}

		internal bool IsHit(Figure figure)
		{
			foreach (var p in pList)
			{
				if (figure.IsHit(p))
					return true;
			}
			return false;
		}

		private bool IsHit(Point point)
		{
			foreach (var p in pList)
			{
				if (p.IsHit(point))
					return true;
			}
			return false;
		}
	}
}