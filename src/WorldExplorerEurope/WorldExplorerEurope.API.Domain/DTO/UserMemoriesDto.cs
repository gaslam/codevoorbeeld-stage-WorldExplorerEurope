using System;
using System.Collections.Generic;
using System.Text;

namespace WorldExplorerEurope.API.Domain.DTO
{
    public class UserMemoriesDto
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public ICollection<MemoryDto> Memories { get; set; }
    }
}
