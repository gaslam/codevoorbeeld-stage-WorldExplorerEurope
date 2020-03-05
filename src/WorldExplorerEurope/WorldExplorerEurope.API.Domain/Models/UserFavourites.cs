using System;
using System.Collections.Generic;
using System.Text;

namespace WorldExplorerEurope.API.Domain.Models
{
    public class UserFavourites
    {
        public Guid UserId { get; set; }
        public Guid MemoryId { get; set; }
        public User User { get; set; }
        public Memory Memory { get; set; }
    }
}
