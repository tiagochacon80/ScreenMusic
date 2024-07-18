using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Model
{
    public class Music
    {
        public string Name { get; }
        public Band Artist { get; }
        public int Duration { get; set; }
        public bool IsAvailable { get; private set; }
        public Genre MusicGenre { get; set; }
        public string Summarydescription => $"This song is by {Artist}";


        public Music(string name, Band artist, int duration, bool isAvailable)
        {
            Name = name;
            Artist = artist;
            Duration = duration;
            IsAvailable = true;
        }

        public void SetIsAvailable(bool isAvailable)
        {
            IsAvailable = isAvailable;
        }

        public void DisplayInfo()
        {
            Console.WriteLine(Summarydescription);
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Artist: {Artist}");
            Console.WriteLine($"Duration: {Duration}");
            if (IsAvailable)
            {
                Console.WriteLine("Is avaliable in the plan.");
            }
            else
            {
                Console.WriteLine("Purchase the Plan+");
            }

        }

        public void DisplayArtistName()
        {
            Console.WriteLine($"Name/Artist: {Name} - {Artist}");
        }
    }
}
