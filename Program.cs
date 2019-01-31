using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

using Assignment2.Models;

namespace Assignment2
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var host = BuildWebHost(args);

            using(var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                try
                {
                    DataSeeder.Initialize(services);
                }
                catch(Exception exp)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(exp, "An error occurred seeding the Database");

                }
            }

            host.Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}