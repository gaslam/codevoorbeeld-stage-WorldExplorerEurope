using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WorldExplorerEurope.App.ViewModels.SignalR
{
    public class ExplorerHubViewModel
    {
        public static bool IsConnected = false;
        HubConnection hubConnection;
        public ExplorerHubViewModel()
        {
            var ip = "localhost";
            if (Device.RuntimePlatform == Device.Android)
                ip = "10.0.2.2";

            hubConnection = new HubConnectionBuilder()
                .WithUrl($"http://{ip}:5000/chatHub")
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

        public async Task UpdateFavourites()
        {
            try
            {
                await hubConnection.InvokeAsync("SendMessage");
                IsConnected = true;
            }
            catch (Exception ex)
            {
                // send failed
                IsConnected = false;
            }
        }
    }
}
