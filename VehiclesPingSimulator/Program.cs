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
        static HttpClient client = new HttpClient();
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfigurationRoot configuration = builder.Build();

            RunAsync().GetAwaiter().GetResult();

        }

        static async Task RunAsync()
        {
            // Get the product
            var resullt = await GetAvailableVehiclesAsync();
            foreach(Vehicledata vd in resullt)
            {
                Console.WriteLine($"ID: {vd.ID}\tPrice: " +
              $"{vd.VIN}\VIN: {vd.Regnr}");
            }

        }
        static async Task<IEnumerable<Vehicledata>> GetAvailableVehiclesAsync()
        {
            string vehicleAPIURL = "https://localhost:44314/api/vehicle";//ConfigurationManager.AppSettings["VehiclesEndPoint"];
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

        static void SimulateRandomPing(string VehicleId)
        {

        }
    }
}
