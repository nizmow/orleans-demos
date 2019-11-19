using System;
using Application.Grains;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Orleans;
using Orleans.Hosting;

namespace Application
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => webBuilder.UseStartup<Startup>())
                .UseOrleans(siloBuilder =>
                {
                    siloBuilder.UseLocalhostClustering();
                    siloBuilder.ConfigureApplicationParts(parts => parts.AddApplicationPart(typeof(Note).Assembly).WithReferences());
                })
                .ConfigureLogging(logging => logging.AddConsole());
        }
}
