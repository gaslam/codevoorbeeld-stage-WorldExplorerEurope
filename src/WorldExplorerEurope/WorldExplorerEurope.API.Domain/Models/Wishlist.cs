﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WorldExplorerEurope.API.Domain.Models
{
    public class Wishlist : EntityBase
    {
        public Guid UserId { get; set; }
        public Guid CountryId { get; set; }
    }
}
