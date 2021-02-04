using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Microsoft.AspNetCore.Hosting;
using Test.Models;

namespace Test.Services
{
    public class ImageService
    {
        public ImageService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        public string ImageFileName(string file)
        {
            return Path.Combine(WebHostEnvironment.WebRootPath, "css", file);
        }
    }
}
