using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class Snake : Figure // змейка является наследником класса фигура 
	{
		Direction direction; // класс змейка хранит данные класса с направлениями 

		public Snake(Point tail, int length, Direction _direction) // конструктор котрый задает стартовую точку появления и какое направление у змейки на поле 
		{
			direction = _direction; //переменная направления 
			pList = new List<Point>(); // список точек
			for (int i = 0; i < length; i++) // цикл в котором несколько раз создается копия хвостовой точки котороая переданна в конструкторе 
			{
				Point p = new Point(tail); // добавление определенного количества точек в определенной координате 
				p.Move(i, direction); // точка сдвигается на i позиций по направлению Direct
				pList.Add(p); // добавление точки в списк
			}
		}

		public void Move() //  Метод движения змейки 
		{
			Point tail = pList.First(); // вызывает у списка метод First он берет первый элемент их списка 
			pList.Remove(tail); // удаляем последнюю точку из змейки чтобы она передвигаласть по полю 
			Point head = GetNextPoint(); // добавляем 1 точку вперед чтобы ло движение змейки 
			pList.Add(head);// добавление точки головы в список 

			tail.Clear();// метод для того чтобы убрать последнюю точку хвоста с экрана 
			head.Draw();// метод для отрисовки на экран  новой точки перед головой 
		}

		public Point GetNextPoint() // функция которая вычисляет где окажется точка змейки в следующий момент 
		{
			Point head = pList.Last(); // текущаа позиция головы змейки до того как она переместилась вызыванием метода Last 
			Point nextPoint = new Point(head); // создание новой точки которая является копией предыдущего положения головы змейки 
			nextPoint.Move(1, direction); // точка сдвигается по направлению directionn 
			return nextPoint; // возвращаем переменную 
		}

		public bool IsHitTail()// функция для проверки столкнулась ли змейка с хвостом 
		{
			var head = pList.Last(); // получает координаты головной точки 
			for (int i = 0; i < pList.Count - 2; i++) // делает проверку есть ли совпадения координат головной точки и хвочста 
			{
				if (head.IsHit(pList[i])) // если есть пересечения головы с хвостом то 
					return true; // возвращаем Тру и перехотим в бесконечный цикл и игра заканчиваеттся 
			}
			return false; // Возвращаем Фолс значит не врезался в хвочт 
		}

		public void HandleKey(ConsoleKey key) // публичный метод 
		{// проверка чему была равна нажатая клавиша 
			if (key == ConsoleKey.LeftArrow)// если клавиша была левой стрелкой то 
				direction = Direction.LEFT; // направление змейки изменится налево 
			else if (key == ConsoleKey.RightArrow)// если правая клавиша то
				direction = Direction.RIGHT;// направление направо 
			else if (key == ConsoleKey.DownArrow)// если клавиша вниз то 
				direction = Direction.DOWN; // то направление вниз 
			else if (key == ConsoleKey.UpArrow) // если клавиша вверх то 
				direction = Direction.UP; // направление вверх
		}

		public bool Eat(Point food) // публичный метод поедания еды 
		{
			Point head = GetNextPoint(); // передвижение змейки 
			if (head.IsHit(food)) // проверка если это точка где окажется змейка на следующем ходу совпадает по координатом с едой то 
			{// будет акт питания змейки 
				food.sym = head.sym; // удлиннение змейки 
				pList.Add(food);// добавление точки в список 
				return true; // возвращение true и переход в бесконечный цикл 
			}
			else // если не соввпадает по координатам то не будет акта питания 
				return false;
		}
	}
}