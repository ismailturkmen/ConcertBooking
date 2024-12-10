using ConcertBooking.Application.Services.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConcertBooking.Application.Services.Implementations
{
    public class UtilityService : IUtilityService
    {

        private IWebHostEnvironment _env;
        private IHttpContextAccessor _contextAccessor;

        public UtilityService(IWebHostEnvironment env, IHttpContextAccessor contextAccessor)
        {
            _env = env;
            _contextAccessor = contextAccessor;
        }

        public Task DeleteImage(string ContainerName, string dbpath)
        {
            if(string.IsNullOrEmpty(dbpath))
            {
                return Task.CompletedTask;
            }
            var filename = Path.GetFileName(dbpath);
            var completePath = Path.Combine(_env.WebRootPath,ContainerName, filename);
            if(File.Exists(completePath))
            {
                File.Delete(completePath);
            }
            return Task.CompletedTask;
        }

        public async Task<string> EditImage(string ContainerName, IFormFile file, string dbpath)
        {
            await DeleteImage(ContainerName, dbpath);
            return await SaveImage(ContainerName, file);
        }

        public async Task<string> SaveImage(string ContainerName, IFormFile file)
        {
            var extension = Path.GetExtension(file.FileName);
            var filename = $"{Guid.NewGuid()}{extension}";
            string folder = Path.Combine(_env.WebRootPath, ContainerName) ;
            if(!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }
            var filePath = Path.Combine(folder, filename);
            using(var memoryStreem = new MemoryStream())
            {
                await file.CopyToAsync(memoryStreem);
                var content = memoryStreem.ToArray();
                await File.WriteAllBytesAsync(filePath, content);
            }

            var basePath = $"{_contextAccessor.HttpContext.Request.Scheme}://{_contextAccessor.HttpContext.Request.Host}";
            var combinedPath = Path.Combine(basePath, ContainerName, filename).Replace("\\", "/");
            return combinedPath;
        }
    }
}
