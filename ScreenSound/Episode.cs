using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound
{
    public class Episode
    {
        public string Title { get; }
        public int Duration  { get; }
        public int Order { get; }
        public string Summary => $"{Order}. {Title} ({Duration} min) - {string.Join(",", guests)}"; 
        
        private List<string> guests = new();

    
        public Episode(int order, string title, int duration)
        {
            Order = order;
            Title = title;
            Duration = duration;
            
        }

        public void AddGuest(string guest)
        {
            guests.Add(guest);
        }
    }
}
