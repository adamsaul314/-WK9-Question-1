using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Song s1 = new Song("BEAUTIFUL PEOPLE", "ED SHEERAN", 3.15, Genre.Pop);
            Song s2 = new Song("DANCE MONKEY", "TONES & 1", 4.20, Genre.Dance);
            Song s3 = new Song("CIRCLES", "ED SHEERAN", 3.15, Genre.Pop);
            Song s4 = new Song("BEAUTIFUL PEOPLE", "ED SHEERAN", 3.15, Genre.Dance);
            Song s5 = new Song("BEAUTIFUL PEOPLE", "ED SHEERAN", 3.15, Genre.Pop);

            List<Song> playlist = new List<Song>();
            playlist.Add(s1);
            playlist.Add(s2);
            playlist.Add(s3);
            playlist.Add(s4);
            playlist.Add(s5);

            Display(playlist);
        }
        private static void Display(List<Song> playlist)
        {
            Console.WriteLine("{0,-20}{1,-25}{2,-10}{3,-10}", "Artist","Song","Duration","Genre");
            foreach (Song song in playlist)
            {
                Console.WriteLine($"{song.Artist,-20}{song.Title,-25}{song.Duration,-10}{song.MusicGenre,-10}");
            }
        }
    }
}
