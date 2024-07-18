using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Model
{
    public class Podcast
    {

        public string Host { get; }
        public string Name { get; }

        public List<Episode> episodes = new();
        public int TotalEpisode => episodes.Count;
        Podcast(string host, string name)
        {
            Host = host;
            Name = name;
            episodes = new List<Episode>();
        }

        public void AddEpidose(Episode episode)
        {
            episodes.Add(episode);
        }

        public void DisplayPodcastDetails()
        {
            Console.WriteLine($"Podcast: {Name}");
            Console.WriteLine($"Host: {Host}");
            foreach (var episode in episodes.OrderBy(e => e.Order))
            {
                Console.WriteLine(episode.Summary);
            }
            Console.WriteLine($"Total Episodes: {TotalEpisode}");


        }
    }
}
