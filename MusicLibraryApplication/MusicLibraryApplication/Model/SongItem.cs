using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace MusicLibraryApplication.Model
{
    public enum MusicGenre
    {
        Classical,
        Country,
        Electronic,
        Jazz,
        Pop,
        Rap,
        Rock
    }

    public enum Decades
    {
        Sixties,
        Seventies,
        Eighties,
        Ninties,
        Aughts,
        Teens,
        Twenties,
        Unknown
    }

    public class SongItem
    {
        public string SongTitle { get; set; }
        public string ArtistName { get; set; }
        public string AlbumName { get; set; }
        public MusicGenre Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ImageFile { get; set; }
        public string AudioFile { get; set; }

        public SongItem (string name, string artist, string albumName, MusicGenre genre, DateTime releaseDate)
        {
            SongTitle = name;
            ArtistName = artist;
            AlbumName = albumName;
            Genre = genre;
            ReleaseDate = releaseDate;
            ImageFile = $"/Assets/Images/MusicNote.png";
            AudioFile = $"/Assets/Audio/{Genre}/{SongTitle}.mp3";

        }
    }
}