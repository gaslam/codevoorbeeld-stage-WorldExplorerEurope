﻿using System;
using System.Collections.Generic;
using System.Text;
using WorldExplorerEurope.API.Domain.DTO.Base;

namespace WorldExplorerEurope.API.Domain.DTO
{
    public class UserMemoriesDto : DtoBaseUser
    {
        public ICollection<MemoryDto> Memories { get; set; }
    }
}
