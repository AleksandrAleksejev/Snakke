using System;
using System.Collections.Generic;
using System.Text;
using WMPLib;

namespace Snakke
{
    public class Sound
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        private string pathToMedia;

        public Sound(string pathToResources)
        {
            pathToMedia = pathToResources;
        }
        public void Play()
        {
            player.URL = pathToMedia + "media.mp3";
            player.settings.volume = 30;
            player.controls.play();
            player.settings.setMode("loop", true);

        }

        public void Play(string songName)
        {
            player.URL = pathToMedia + songName + "Game.mp3";
            player.controls.play();

        }

        public void PlayEat()
        {
            player.URL = pathToMedia + "Eat.mp3";
            player.settings.volume = 100;
            player.controls.play();
        }
    }
}
