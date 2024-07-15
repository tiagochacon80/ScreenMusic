using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound
{
    public class Band
    {
        private List<Album> Albums = new List<Album>();        

        public Band()
        {
            Name = Name;
        }
        public string Name { get; }

        public void AddAlbum(Album album)
        {
            Albums.Add(album);
        }

        public void DisplayBandInfo()
        {
            foreach (var album in Albums)
            {                
                Console.WriteLine($"Album: {album.Name} ({album.TotalTime})");
            }
        }
    }
}
