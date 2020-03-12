using System;
using System.Collections.Generic;
using System.Text;

namespace WorldExplorerEurope.API.Domain.Models
{
    public class UserWishlists : EntityBase
    {
        public Guid UserId { get; set; }
        public Guid WishlistId { get; set; }
        public User User { get; set; }
        public Wishlist Wishlist { get; set; }
    }
}
