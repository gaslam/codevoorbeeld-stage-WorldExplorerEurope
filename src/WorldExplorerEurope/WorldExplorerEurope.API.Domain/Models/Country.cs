using System;

namespace WorldExplorerEurope.API.Domain
{
    public class Country
    {
        public string Name { get; set; }
        public string FlagUrl { get; set; }
        public long Population { get; set; }
        public string Capital { get; set; }
        public string Currency { get; set; }
        public bool IsEUMember { get; set; }
        public string Description { get; set; }
    }
}
