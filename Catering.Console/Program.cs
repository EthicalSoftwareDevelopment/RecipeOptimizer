using System;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using Catering.Console.Utils;
using Catering.Console.Utils.Interfaces;
using Catering.Domain.DomainModels;
using Catering.WebApi.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Catering.Console
{
    public class Program
    {
        private static string _urlPath_OptimalMenu = "catering/GetBestCombination/";
            
        public static async Task Main(string[] args)
        {
            var client = GetHttpClient();

            var bestCookingOption = await client.GetFromJsonAsync<SetMenu>(
                _urlPath_OptimalMenu);
            
            var writerUtilities = GetWritingUtilitiesService();
            
            writerUtilities.WriteSetMenu(bestCookingOption);
        }

        /// <summary>
        /// HttpClient for WebApis
        /// </summary>
        /// <returns></returns>
        private static HttpClient GetHttpClient()
        {
            HttpClient client = new HttpClient();
            
            client.BaseAddress = new Uri("http://localhost:5179/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json")
            );
            
            return client;
        }
        
        
        /// <summary>
        /// Dependancy Injection workaround for Console Apps
        /// </summary>
        /// <returns></returns>
        private static IWriterUtilities GetWritingUtilitiesService()
        {
            var serviceProvider = new ServiceCollection()
                .AddLogging()
                .AddSingleton<IWriterUtilities, WriterUtilities>()
                .BuildServiceProvider();
            ;

            var writerUtilities = serviceProvider.GetService<IWriterUtilities>();
            System.Console.WriteLine("Starting application");

            return writerUtilities;
        }
    }
}