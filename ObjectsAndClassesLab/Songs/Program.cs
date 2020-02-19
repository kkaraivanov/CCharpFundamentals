using System;
using System.Collections.Generic;
using System.Linq;

namespace Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int countSongs = int.Parse(Console.ReadLine());
            List<Song> songs = AddNewSongToList(countSongs).ToList();
            string prinTypeSongs = Console.ReadLine();
            
            if(prinTypeSongs == "all")
                foreach (var item in songs)
                    Console.WriteLine(item.Name);
            else
                foreach (var item in songs.Where(song => song.TypeLis == prinTypeSongs))
                    Console.WriteLine(item.Name); 
        }

        private static List<Song> AddNewSongToList(int countSongs)
        {
            // "{typeList}_{name}_{time}"
            List<Song> newSongs = new List<Song>();
            for (int i = 0; i < countSongs; i++)
            {
                string[] song = Console.ReadLine().Split('_').ToArray();
                Song newSong = new Song();
                newSong.TypeLis = song[0];
                newSong.Name = song[1];
                newSong.Time = song[2];
                newSongs.Add(newSong);
            }

            return newSongs;
        }
    }
}
