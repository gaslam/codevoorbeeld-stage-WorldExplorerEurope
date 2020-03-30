using System;
using System.Collections.Generic;
using System.Text;
using WorldExplorerEurope.App.Domain.Models.Base;

namespace WorldExplorerEurope.App.Domain.Models
{
    public class Country : BaseId
    {
        public string Name { get; set; }
        public Uri Flag { get; set; }
        public long Population { get; set; }
        public string Capital { get; set; }
        public string Currency { get; set; }
        public bool IsEUMember { get; set; }
        public string Description { get; set; }
    }
}
