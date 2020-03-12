using System;
using System.Collections.Generic;
using System.Text;

namespace WorldExplorerEurope.API.Domain.Models
{
    public class User : EntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nationality { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }

        public ICollection<UserMemories> Memories { get; set; }
        public ICollection<UserFavourites> Favourites { get; set; }
        public ICollection<UserWishlists> Wishlists { get; set; }

    }
}
