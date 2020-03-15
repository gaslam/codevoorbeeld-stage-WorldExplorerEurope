using System;
using System.Collections.Generic;
using System.Text;

namespace WorldExplorerEurope.API.Domain.DTO
{
    public class UserWishlistDto
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public ICollection<WishlistDto> Wishlists { get; set; }
    }
}
