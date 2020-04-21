using System;
using System.Collections.Generic;
using System.Text;
using WorldExplorerEurope.App.Domain.Models.Base;

namespace WorldExplorerEurope.App.Domain.Models
{
    public class Favourite : BaseId
    {
        public Guid UserId { get; set; }
        public Guid CountryId { get; set; }
    }
}
