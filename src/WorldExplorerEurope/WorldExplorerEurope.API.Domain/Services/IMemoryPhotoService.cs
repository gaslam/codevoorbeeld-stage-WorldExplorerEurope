using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WorldExplorerEurope.API.Domain.Services
{
    public interface IMemoryPhotoService
    {
        public Task<Uri> CreateImage(IFormFile file, Guid fileId);
    }
}
