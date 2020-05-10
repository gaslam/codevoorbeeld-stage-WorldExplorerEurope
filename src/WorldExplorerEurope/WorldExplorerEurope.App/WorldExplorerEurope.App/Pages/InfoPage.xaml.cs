using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldExplorerEurope.App.ViewModels;
using WorldExplorerEurope.Domain.Models;
using WorldExplorerEurope.App.ViewModels.Syncfusion;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using WorldExplorerEurope.App.Pages;
using MediaManager;
using Plugin.SimpleAudioPlayer;
using System.Net;
using System.IO;
using System.Net.Http;

namespace WorldExplorerEurope.App.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InfoPage : TabbedPage
    {
        ISimpleAudioPlayer player;
        private InfoViewModel _infoViewModel;
        public InfoPage(Country country)
        {
            InitializeComponent();
            this.HeightRequest = 600;
            player = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        }

        private async void lsvSpotify_ItemTapped(object sender, Syncfusion.ListView.XForms.ItemTappedEventArgs e)
        {
            var media = e.ItemData as BasicPlaylist;
            string url = media.PreviewUrl.ToString();
            if(player.IsPlaying == true)
            {
                player.Stop();
            }
            HttpClient httpClient = new HttpClient();
            var fileStream = await httpClient.GetStreamAsync(url);
            player.Load(fileStream);
            player.Play();
        }

        protected override async void OnDisappearing()
        {
            if (player.IsPlaying == true)
            {
                player.Stop();
            }
            base.OnDisappearing();
        }
    }
}