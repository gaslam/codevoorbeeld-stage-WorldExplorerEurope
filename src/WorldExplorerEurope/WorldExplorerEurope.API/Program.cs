using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace WorldExplorerEurope.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        //Xamarin.Forms cannot reach the localhost so we had to use this. It ensures that you can reach the api over your local internet. 
        //We do not have our own domain, so the teacher recommended this to us.
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                    webBuilder
                    .UseUrls("http://0.0.0.0:5000", "https://0.0.0.0:5001")
                    .UseStartup<Startup>());

    }
}
