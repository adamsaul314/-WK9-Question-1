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

            List<Song> playList = new List<Song>();
            playList.Add(s1);
            playList.Add(s2);
            playList.Add(s3);
            playList.Add(s4);
            playList.Add(s5);

            foreach (Song song in playList)
            {
                Console.WriteLine(song);
            }
        }
    }
}
