using System;
using System.Collections.Generic;
using System.Linq;

namespace ScreenSound.Model
{
    public class Band
    {
        private List<Album> Albums = new List<Album>();
        private List<Rating> Ratings = new List<Rating>();

        public Band(string name)
        {
            Name = name;
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
                Console.WriteLine($"Album: {album.Name} ({album.TotalTime}) - Average Rating: {GetAverageRating()}");
            }
        }

        internal void AddRating(Rating rating)
        {
            Ratings.Add(rating);
        }

        private double GetAverageRating()
        {
            return Ratings.Count > 0 ? Ratings.Average(r => r.Score) : 0;
        }
    }
}
