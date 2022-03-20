﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class FoodCreator
	{
		int mapWidht;
		int mapHeight;
		char sym;

		Random random = new Random();

		public FoodCreator(int mapWidth, int mapHeight, char sym) // конструктор для места где будет появляться еда на поле и символ отображения еды 
		{
			this.mapWidht = mapWidth; // ширена поля 
			this.mapHeight = mapHeight; // высота поля 
			this.sym = sym; // символ еды 
		}

		public Point CreateFood() // метод создания еды 
		{
			int x = random.Next(2, mapWidht - 2); // генерирует произвольные координаты 
			int y = random.Next(2, mapHeight - 2); // генерирует произвольные координаты 
			return new Point(x, y, sym); // появляется новая точка с этими  координатами 
		}
	}
}