﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WorldExplorerEurope.API.Domain.DTO.Base
{
    public abstract class DtoBaseCountry
    {
        public Guid Id { get; set; }
        public Guid CountryId { get; set; }
    }
}
