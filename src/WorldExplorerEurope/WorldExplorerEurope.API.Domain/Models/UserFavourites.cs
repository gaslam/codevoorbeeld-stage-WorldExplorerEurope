using System;
using System.Collections.Generic;
using System.Text;

namespace WorldExplorerEurope.API.Domain.Models
{
    public class UserFavourites
    {
        public Guid UserId { get; set; }
        public Guid FavouriteId { get; set; }
        public User User { get; set; }
        public Favourite Favourite { get; set; }
    }
}
