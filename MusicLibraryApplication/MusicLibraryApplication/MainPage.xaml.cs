using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Collections;
using System.Collections.ObjectModel;
using MusicLibraryApplication.Model;
using MusicAppLib.Models;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MusicLibraryApplication
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private ObservableCollection<SongItem> Musics; // List that has all music files loaded 

        // Yassmin: the right menu that has the music category list displayed , when the user chooses a category all the songs under this list will be loaded 

        private List<MenuItem> MenuItem; 
        public MainPage()
        {

            this.InitializeComponent();
            Metadata tag = new Metadata();
            tag.ReadFileMetaData();

            //Yassmin : Read all the music files into observable collection 

            Musics = new ObservableCollection<SongItem>();
            MusicManager.GetAllMusic(Musics);

            //Yassmin: Load all the music category list to the right menu 
            MenuItem = new List<MenuItem>();
            MenuItem.Add(new MenuItem
            {
                Icon = $"Assets/Image/MusicLibrary/Classical/Classical.png",// Yassmin : the name of the icon needs to be changed based on the final icons we use and their names 
                MenuSelection = MusicGenre.Classical // Yassmin : I had to convert it toString untill Michelle changes the menuItem from string to MusicGenre
            }) ;

            MenuItem.Add(new MenuItem
            {
                Icon = $"Assets/Image/MusicLibrary/Country/Country.png",// Yassmin : the name of the icon needs to be changed based on the final icons we use and their names 
                MenuSelection = MusicGenre.Country// Yassmin : I had to convert it toString untill Michelle changes the menuItem from string to MusicGenre

            }) ;
            MenuItem.Add(new MenuItem
            {
                Icon = $"Assets/Image/MusicLibrary/Electronic/Electronic.png",// Yassmin : the name of the icon needs to be changed based on the final icons we use and their names 
                MenuSelection = MusicGenre.Electronic// Yassmin : I had to convert it toString untill Michelle changes the menuItem from string to MusicGenre

            });
            MenuItem.Add(new MenuItem
            {
                Icon = $"Assets/Image/MusicLibrary/Pop/Pop.png",// Yassmin : the name of the icon needs to be changed based on the final icons we use and their names 
                MenuSelection = MusicGenre.Pop// Yassmin : I had to convert it toString untill Michelle changes the menuItem from string to MusicGenre

            });
            MenuItem.Add(new MenuItem
            {
                Icon = $"Assets/Image/MusicLibrary/Rap/Rap.png",// Yassmin : the name of the icon needs to be changed based on the final icons we use and their names 
                MenuSelection = MusicGenre.Rap// Yassmin : I had to convert it toString untill Michelle changes the menuItem from string to MusicGenre

            });
            MenuItem.Add(new MenuItem
            {
                Icon = $"Assets/Image/MusicLibrary/Rock/Rock.png",// Yassmin : the name of the icon needs to be changed based on the final icons we use and their names 
                MenuSelection = MusicGenre.Rock// Yassmin : I had to convert it toString untill Michelle changes the menuItem from string to MusicGenre

            });
            /*    MenuItem.Add(new MenuItem    // Yassmin : for tge JAZZ if it is added 
                {
                    Icon = $"Assets/Image/MusicLibrary/Rap/Rap.png",
                    MenuSelection = MusicGenre.Rap
                });
            */



        }

        private void ListOfMusic_ItemClick(object sender, ItemClickEventArgs e)
        {
            var menuItem= (MenuItem)e.ClickedItem;
            //Yassmin : expected that the texbock of the musics page changed to be the Genre 
            MusicManager.GetMusicByCategory(Musics, menuItem.MenuSelection);

        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            // I need to store all checked items in a list or collection 
        }
    }
}
