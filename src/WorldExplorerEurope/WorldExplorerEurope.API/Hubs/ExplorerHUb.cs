using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorldExplorerEurope.API.Hubs
{
    public class ExplorerHub : Hub
    {
        public async Task AddFavourite()
        {
            await Clients.All.SendAsync("addFavourite");
        }
    }
}
