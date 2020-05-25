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
        public string Role { get; set; }
        public string  Token { get; set; }
        public bool IsSpotifyDj { get; set; }
    }
}
