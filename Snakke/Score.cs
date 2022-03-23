using System;
using System.Collections.Generic;
using System.Text;

namespace Snakke
{
    public class Score // класс счетчика 
    {
        public int score;
        public int speed;
        public int level;
        public Score(int score, int level) // конструктор вызывания функции для создания цифр на счетчике
        {
            this.score = score;
            this.level = level;
        }
        public bool Scoree()// функция для добавления 100 баллов при сьедение 1 $ и при достижению 1000 баллов повышение уровня и скорости на 10 единиц 
        {
            score += 100;
            if (score % 1000 == 0)
            {
                level += 1;
                return true;
            }
            else { return false; }
        }
        public void ScoreWrite()// отрисовка счетчика на экране 
        {
            Console.SetCursorPosition(100, 2);// координаты отрисовки счетчика 
            Console.WriteLine("Очки:" + score.ToString()); // счетчик очков 
            Console.SetCursorPosition(100, 3);// координаты отрисовки счетчика 
            Console.WriteLine("Уровень:" + level.ToString()); // счетчик уровня 
            Console.SetCursorPosition(90, 1); // координаты 
            Console.WriteLine("=========================="); // отриисовка рамки на экране 
            Console.SetCursorPosition(90, 4); // координаты 
            Console.WriteLine("=========================="); // отриисовка рамки на экране 
        }
    }
}
