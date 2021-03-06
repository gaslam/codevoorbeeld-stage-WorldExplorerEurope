﻿using System;
using System.Collections.Generic;
using System.Text;
using WorldExplorerEurope.API.Domain.DTO.Bases;
using WorldExplorerEurope.API.Domain.Models;

namespace WorldExplorerEurope.API.Domain.DTO
{
    public class WishlistDto : EntityBase
    {

        public Guid UserId { get; set; }

        public ICollection<WishlistDto> Wishlists { get; set; }
    }
}
