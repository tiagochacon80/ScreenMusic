﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound
{
    internal class Album
    {
        private List<Music> Musics = new List<Music>();
        public string Name {  get; set; }
        public int TotalTime => Musics.Sum(m => m.Duration);

        public Album() 
        {
            
        }

        public void AddMusic(Music music)
        {
            Musics.Add(music);
        }

        public void DisplayMusicofAlbum()
        {
            Console.WriteLine($"list of songs from the album {Name}:\n");
            foreach (var music in Musics)
            {
                Console.WriteLine($"Music: {music.Name}");
            }
            Console.WriteLine($"\nTotal time: {TotalTime}");
        }
    }
}
