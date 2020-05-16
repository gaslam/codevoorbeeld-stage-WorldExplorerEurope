using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorldExplorerEurope.App.Domain.Models;

namespace WorldExplorerEurope.API.Hubs
{
    public class ExplorerHub : Hub
    {
        public async Task AddFavourites(string favourite)
        {
            await Clients.All.SendAsync("addFavourites", favourite);
        }
    }
}
