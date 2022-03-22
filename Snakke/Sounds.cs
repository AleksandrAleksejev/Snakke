using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace Snake
{
    public class Sounds
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        private string pathToMedia;

        public Sounds(string pathToResources)
        {
            pathToMedia = pathToResources;
        }

        public void Play(string sound) // Публичный метод (Звук фона) 
        {
            player.URL = pathToMedia + sound;
            player.settings.volume = 30;
            player.controls.play();
            player.settings.setMode("loop", true);
        }

        public void Stop(string sound)// Публичный метод (Звук Смерти)
        {
            player.URL = pathToMedia + sound;
            player.settings.volume = 100;
            player.controls.play();
        }

        public void PlayEat(string sound) //Публичный метод (Звук поедания)
        {
            player.URL = pathToMedia + sound;
            player.settings.volume = 100;
            player.controls.play();
        }
    }
}
