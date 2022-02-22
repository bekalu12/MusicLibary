using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibraryApplication.Models
{
    public static class MusicManager
    {

        // Gets all songs for Observable Collection
        public static void GetAllMusic(ObservableCollection<MusicItem> collection)
        {
            var allMusic = GetMusic();
            collection.Clear();

            allMusic.ForEach(item => collection.Add(item));
        }

        // Filters songs in Observable Collection by genre
        public static void GetMusicByCategory(ObservableCollection<MusicItem> collection, MusicGenre genre)
        {
            var allMusic = GetMusic();
            var filteredMusic = allMusic.Where(item => item.Genre == genre).ToList();
            collection.Clear();

            filteredMusic.ForEach(item => collection.Add(item));
        }

        //Filters songs in Observable Collection by artist
        public static void GetMusicByArtist(ObservableCollection<MusicItem> collection, string artist)
        {
            var allMusic = GetMusic();
            var filteredMusic = allMusic.Where(item => item.Artist == artist).ToList();
            collection.Clear();

            filteredMusic.ForEach(item => collection.Add(item));
        }

        //Filters songs in Observable Collection by decade
        public static void GetMusicByDecade(ObservableCollection<MusicItem> collection, Decades decade)
        {
            var allMusic = GetMusic();
            var filteredMusic = allMusic.Where(item => Helper.ConvertToDecade(item.ReleaseDate) == decade).ToList();
            collection.Clear();

            filteredMusic.ForEach(item => collection.Add(item));
        }

        //Creates entire music collection into List
        private static List<MusicItem> GetMusic()
        {
            var musicCollection = new List<MusicItem>();
            musicCollection.Add(new MusicItem("American Woman", "Lenny Kravitz", "Austin Powers: The Spy Who Shagged Me", "4:21", MusicGenre.Rock, new DateTime(1999, 05, 10), "Virgin"));

            return musicCollection;
        }
    }
}
