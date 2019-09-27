using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using VehiclesPingSimulator.Models;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace VehiclesPingSimulator
{
    class Program
    {
        static IConfiguration Configuration { get; set; }
        static HttpClient client = new HttpClient();

        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            Configuration = builder.Build();

            RunAsync().GetAwaiter().GetResult();
        }

        static async Task RunAsync()
        {
            var resullt = await GetAvailableVehiclesAsync();
            Random random = new Random();
            var seconds = random.Next(30, 120);
            while (true)
            {
                foreach (Vehicledata vd in resullt)
                {
                    await Task.Run(async delegate
                     {
                         SimulateRandomPing(vd.VIN);
                         await Task.Delay(seconds * 1000);
                     });
                }
            }
        }
        static async Task<IEnumerable<Vehicledata>> GetAvailableVehiclesAsync()
        {
            var vehicleAPIURL = Configuration.GetSection("AppSettings:VehiclesEndPoint").Value;
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = await client.GetAsync(vehicleAPIURL);
            if (response.IsSuccessStatusCode)
            {
                var vehiclesdata = await response.Content.ReadAsAsync<IEnumerable<Vehicledata>>();
                return vehiclesdata;
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }
            return null;
        }

        static async void SimulateRandomPing(string VehicleId)
        {
            var pingVehicleAPIURL = Configuration.GetSection("AppSettings:VehiclesPing").Value + VehicleId;
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = await client.GetAsync(pingVehicleAPIURL);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
              //  Console.WriteLine("Vehicle Ping success: ({1})", VehicleId);
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }
        }
    }
}
