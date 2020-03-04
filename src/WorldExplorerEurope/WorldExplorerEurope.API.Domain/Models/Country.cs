using System;

namespace WorldExplorerEurope.API.Domain
{
    public class Country
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public long Population { get; set; }
        public bool IsEUMember { get; set; }
    }
}
