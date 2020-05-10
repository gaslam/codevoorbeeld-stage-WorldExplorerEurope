using Microsoft.AspNetCore.SignalR.Client;
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
        public static bool IsConnected = false;
        HubConnection hubConnection;
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
                object countryToSend = (object)country;
                await hubConnection.InvokeAsync("addFavourite", countryToSend);
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
