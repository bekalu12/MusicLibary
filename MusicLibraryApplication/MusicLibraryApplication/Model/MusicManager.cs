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
            collection.Clear();

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
            //  musicCollection.Add(new SongItem("American Woman", "Lenny Kravitz", "Austin Powers: The Spy Who Shagged Me", "4:21", MusicGenre.Rock, new DateTime(1999, 05, 10), "Virgin"));
            musicCollection.Add(new SongItem("Strangers in the night", "Frank Sinatra "," Greatest Hits",MusicGenre.Classical));
            musicCollection.Add(new SongItem("I'll Be Home for Christmas", "Michael Buble ", " Let It Snow", MusicGenre.Classical));
            musicCollection.Add(new SongItem("I Get A Kick Out Of You", "Michael Buble ", " Let It Snow", MusicGenre.Classical));


            musicCollection.Add(new SongItem("Akon - Beautiful", "Akon", " Unknown", MusicGenre.Country));
            musicCollection.Add(new SongItem("Song3", "Unknown ", " Unknown", MusicGenre.Country));
            musicCollection.Add(new SongItem("If I were a boy remix", "Beyonce ", " Unknown", MusicGenre.Country));

            musicCollection.Add(new SongItem("A Day To Be Alone", "One Less Reason", " Everydaylife", MusicGenre.Pop));
            musicCollection.Add(new SongItem("Marry Me", "Train ", " Save Me SanFransisco", MusicGenre.Pop));
            musicCollection.Add(new SongItem("Unknown", "Unknown ", " Unknown", MusicGenre.Pop));

            musicCollection.Add(new SongItem("Harvest Moon", "Neil Young", " Harvest Moon", MusicGenre.Rap));
            musicCollection.Add(new SongItem("Heart Of Gold", "Neil Young" ,"Unknown", MusicGenre.Rap));

            musicCollection.Add(new SongItem("Unknown", "Unknown ", " Unknown", MusicGenre.Rock));
            musicCollection.Add(new SongItem("Flight Attendant", "JOSH ROUSE ", " Unknown", MusicGenre.Rock));

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
