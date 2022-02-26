using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MusicLibraryApplication.Model
{
    public static class MusicManager
    {

        // Gets all songs for Observable Collection
        public static void GetAllMusic(ObservableCollection<SongItem> collection)
        {
            var allMusic = GetMusic();
            collection.Clear();

            allMusic.ForEach(item => collection.Add(item));
        }

        // Gets the music by its name to add to the user collection 

        public static void GetMusicByTitle(ObservableCollection<SongItem> collection, string title)
        {
            var allMusic = GetMusic();
            var filteredMusic = allMusic.Where(item => item.SongTitle== title).ToList();
            //collection.Clear();

            filteredMusic.ForEach(item => collection.Add(item));
        }

        // Filters songs in Observable Collection by genre
        public static void GetMusicByCategory(ObservableCollection<SongItem> collection, MusicGenre genre)
        {
            var allMusic = GetMusic();
            var filteredMusic = allMusic.Where(item => item.Genre == genre).ToList();
            collection.Clear();

            filteredMusic.ForEach(item => collection.Add(item));
        }

        //Filters songs in Observable Collection by artist
        public static void GetMusicByArtist(ObservableCollection<SongItem> collection, string artist)
        {
            var allMusic = GetMusic();
            var filteredMusic = allMusic.Where(item => item.ArtistName == artist).ToList();
            collection.Clear();

            filteredMusic.ForEach(item => collection.Add(item));
        }

        //Filters songs in Observable Collection by decade
        public static void GetMusicByDecade(ObservableCollection<SongItem> collection, Decades decade)
        {
            var allMusic = GetMusic();
            var filteredMusic = allMusic.Where(item => Helper.ConvertToDecade(item.ReleaseDate) == decade).ToList();
            collection.Clear();

            filteredMusic.ForEach(item => collection.Add(item));
        }

        //Creates entire music collection into List
        private static List<SongItem> GetMusic()
        {
            var musicCollection = new List<SongItem>();
            musicCollection.Add(new SongItem("Strangers In The Night", "Frank Sinatra ","Greatest Hits", MusicGenre.Classical));
            musicCollection.Add(new SongItem("I'll Be Home for Christmas", "Michael Buble", "Let It Snow", MusicGenre.Classical));
            musicCollection.Add(new SongItem("I Get A Kick Out Of You", "Michael Buble", "Let It Snow", MusicGenre.Classical));


            musicCollection.Add(new SongItem("Beautiful", "Akon", "Unknown", MusicGenre.Country));
            musicCollection.Add(new SongItem("Song3", "Unknown ", "Unknown", MusicGenre.Country));
            musicCollection.Add(new SongItem("If I Were A Boy (remix)", "Beyonce", "Unknown", MusicGenre.Country));

            musicCollection.Add(new SongItem("A Day To Be Alone", "One Less Reason", "Everydaylife", MusicGenre.Pop));
            musicCollection.Add(new SongItem("Marry Me", "Train", "Save Me San Fransisco", MusicGenre.Pop));
            musicCollection.Add(new SongItem("Song9", "Artist1 ", "Unknown", MusicGenre.Pop));

            musicCollection.Add(new SongItem("Harvest Moon", "Neil Young", "Harvest Moon", MusicGenre.Rap));
            musicCollection.Add(new SongItem("Heart Of Gold", "Neil Young","Unknown", MusicGenre.Rap));

            musicCollection.Add(new SongItem("Song16", "Unknown ", "Unknown", MusicGenre.Rock));
            musicCollection.Add(new SongItem("Flight Attendant", "Josh Rouse", "Unknown", MusicGenre.Rock));


            musicCollection.Add(new SongItem("Antything Can Happen", "Hans zimmer", "The Holiday", MusicGenre.Electronic));
            musicCollection.Add(new SongItem("Light My Fire ", "Hans zimmer", "The Holiday", MusicGenre.Electronic));


            musicCollection.Add(new SongItem("Jar of Heaerts", "Christina Perri", "Unknown", MusicGenre.Jazz));
            musicCollection.Add(new SongItem("Hey, Soul Sister", "Various Artists", "Unknow", MusicGenre.Jazz));


            return musicCollection;
        }

        // This  method to retreive the meta data of the file 
        private static void GetMusicTags(ObservableCollection<SongItem> collection, MusicGenre genre)
        {
           
            Metadata tag = new Metadata();
            tag.ReadFileMetaData();
        }
    }
}
