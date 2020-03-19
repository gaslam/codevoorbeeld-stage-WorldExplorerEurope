using System;

namespace WorldExplorerEurope.API.Domain.Models
{
    public class Country : EntityBase
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
