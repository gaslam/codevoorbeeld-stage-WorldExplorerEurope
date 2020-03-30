using System;
using System.Collections.Generic;
using System.Text;
using WorldExplorerEurope.App.Domain.Models.Base;

namespace WorldExplorerEurope.App.Domain.Models
{
    public class User : BaseId
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nationality { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }

        public IObservable<Memories> Memories { get; set; }
        public IObservable<Favourites> Favourites { get; set; }
        public IObservable<Wishlist> Wishlists { get; set; }
    }
}
