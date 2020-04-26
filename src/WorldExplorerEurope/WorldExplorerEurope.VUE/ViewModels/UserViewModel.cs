using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorldExplorerEurope.VUE.ViewModels.Base;

namespace WorldExplorerEurope.VUE.ViewModels
{
    public class UserViewModel: BaseId
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nationality { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
    }
}
