using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayerApp
{
    public class Subscriber
    {
        public string Name { get; }
        public Subscriber(string name)
        {
            Name = name;
        }

        public void SongPlayedHandler(string DesiredSong)
        {
            Console.WriteLine($"{Name} is listening the song {DesiredSong}");
        }

        public void SongPausedHandler(string DesiredSong)
        {
            Console.WriteLine($"{Name} has just paused the song {DesiredSong}");    
        }

        public void SongStoppedHandler(string DesiredSong)
        {
            Console.WriteLine($"{Name} has just stopped the song {DesiredSong}");
        }

        public void SongSkippedHandler(string DesiredSong)
        {
            Console.WriteLine($"{Name} has just skipped the song {DesiredSong}");
        }
    }
}
