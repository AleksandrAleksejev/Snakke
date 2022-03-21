using System;
using System.Collections.Generic;
using System.Text;

namespace Snakke
{
    public class Score
    {
        private int score;
        public int level;
        public int speed;
        public Score(int score, int level)
        {
            this.score = score;
            this.level = level;
        }
        public bool ScoreUp()
        {
            score += 1;
            if (score % 2 == 0)
            {
                level += 1;
                return true;
            }
            else { return false; }
        }
        public void ScoreWrite()
        {
            Console.SetCursorPosition(100, 2);
            Console.WriteLine("Score:" + score.ToString());
            Console.SetCursorPosition(100, 4);
            Console.WriteLine("Level:" + level.ToString());
        }
    }
}
