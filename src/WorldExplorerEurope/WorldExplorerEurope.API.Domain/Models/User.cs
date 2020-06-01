using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WorldExplorerEurope.API.Domain.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nationality { get; set; }
        public DateTime BirthDate { get; set; }
        public string Role { get; set; }
        public bool IsSpotifyDj { get; set; }

    }
}
