﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WorldExplorerEurope.API.Domain.Services;

namespace WorldExplorerEurope.API.Services
{
    public class MemoryService<T> : IMemoryPhotoService
    {
        private readonly IWebHostEnvironment _webHostEnv;

        public MemoryService(IWebHostEnvironment webHostEnv, IHttpContextAccessor httpContextAccessor)
        {
            _webHostEnv = webHostEnv;
        }
        public async Task<Uri> CreateImage(IFormFile file, Guid fileId)
        {
            Path.ChangeExtension(file.FileName, ".png");
            var newFileExtension = $"{fileId}{Path.GetExtension(file.FileName)}";

            var root = Path.Combine(_webHostEnv.WebRootPath, "images", typeof(T).Name.ToLower());

            if (!Directory.Exists(root))
            {
                Directory.CreateDirectory(root);
            }

            var filePath = Path.Combine(root, newFileExtension);

            if (file.Length > 0)
            {
                using (FileStream stream = new FileStream(filePath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
            }

            return new Uri($"http://192.168.0.181:5000/images/{typeof(T).Name.ToLower()}/{newFileExtension}", UriKind.Absolute);
        }
    }
}
