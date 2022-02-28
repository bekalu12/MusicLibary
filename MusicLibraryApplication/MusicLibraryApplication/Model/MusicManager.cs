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

        // Gets song in Observable Collection by Title
        public static void GetSelectedMusicByTitle(ObservableCollection<SongItem> collection, string title)
        {
            var allMusic = GetMusic();
            var filteredMusic = allMusic.Where(item => item.SongTitle == title).Distinct().ToList();

            filteredMusic.ForEach(item =>
            {
                if (!collection.Any(song => song.SongTitle == item.SongTitle))
                {
                    collection.Add(item);
                }
            });
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
            musicCollection.Add(new SongItem("Strangers In The Night", "Frank Sinatra","Greatest Hits", MusicGenre.Classical, new DateTime(1960, 12, 25)));
            musicCollection.Add(new SongItem("I'll Be Home for Christmas", "Michael Buble", "Let It Snow", MusicGenre.Classical, new DateTime(2000, 12, 25)));
            musicCollection.Add(new SongItem("I Get A Kick Out Of You", "Michael Buble", "Let It Snow", MusicGenre.Classical, new DateTime(2007, 12, 25)));


            musicCollection.Add(new SongItem("Beautiful", "Akon", "Album1", MusicGenre.Country, new DateTime(2000, 12, 25)));
            musicCollection.Add(new SongItem("Song5", "Frank Sinatra", "Greatest Hits", MusicGenre.Country, new DateTime(2015, 12, 25)));
            musicCollection.Add(new SongItem("If I Were A Boy (remix)", "Beyonce", "Album3", MusicGenre.Country, new DateTime(2015, 12, 25)));

            musicCollection.Add(new SongItem("A Day To Be Alone", "One Less Reason", "Everydaylife", MusicGenre.Pop, new DateTime(2015, 12, 25)));
            musicCollection.Add(new SongItem("Marry Me", "Train", "Save Me San Fransisco", MusicGenre.Pop, new DateTime(2015, 12, 25)));
            musicCollection.Add(new SongItem("Song9", "Artist1", "Unknown", MusicGenre.Pop, new DateTime(2015, 12, 25)));

            musicCollection.Add(new SongItem("Harvest Moon", "Neil Young", "Harvest Moon", MusicGenre.Rap, new DateTime(2015, 12, 25)));
            musicCollection.Add(new SongItem("Heart Of Gold", "Neil Young","Album4", MusicGenre.Rap, new DateTime(2015, 12, 25)));

            musicCollection.Add(new SongItem("Song16", "Unknown", "Unknown", MusicGenre.Rock, new DateTime(2015, 12, 25)));
            musicCollection.Add(new SongItem("Flight Attendant", "Josh Rouse", "Unknown", MusicGenre.Rock, new DateTime(2015, 12, 25)));


            musicCollection.Add(new SongItem("Antything Can Happen", "Hans Zimmer", "The Holiday", MusicGenre.Electronic, new DateTime(2015, 12, 25)));
            musicCollection.Add(new SongItem("Light My Fire", "Hans Zimmer", "The Holiday", MusicGenre.Electronic, new DateTime(2015, 12, 25)));


            musicCollection.Add(new SongItem("Jar of Hearts", "Christina Perri", "Unknown", MusicGenre.Jazz, new DateTime(2015, 12, 25)));
            musicCollection.Add(new SongItem("Hey Soul Sister", "Various Artists", "Unknown", MusicGenre.Jazz, new DateTime(2015, 12, 25)));


            return musicCollection;
        }

      
   
    }
}
