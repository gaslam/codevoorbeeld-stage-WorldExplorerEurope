using Microsoft.AspNetCore.SignalR.Client;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WorldExplorerEurope.App.Domain.Models;
using WorldExplorerEurope.Domain.Models;
using Xamarin.Forms;

namespace WorldExplorerEurope.App.ViewModels.SignalR
{
    public class ExplorerHubViewModel
    {
        public bool IsConnected = false;
        private static HubConnection hubConnection;
        public ExplorerHubViewModel()
        {

            hubConnection = new HubConnectionBuilder()
                .WithUrl($"http://192.168.0.218:5000/ExplorerHub")
                .Build();
        }

        public async Task Connect()
        {
            try
            {
                await hubConnection.StartAsync();
                IsConnected = true;
            }
            catch (Exception ex)
            {
                IsConnected = false;
            }
        }

        public async Task UpdateLists(Country country)
        {
            try
            {
                string countryToSend = JsonConvert.SerializeObject(country);
                await hubConnection.InvokeAsync("addFavourites", countryToSend);
                IsConnected = true;
            }
            catch (Exception ex)
            {
                // send failed
                IsConnected = false;
            }
        }

        public HubConnection GetHub()
        {
            return hubConnection;
        }
    }
}
