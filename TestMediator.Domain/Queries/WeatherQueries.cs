using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMediator.Domain.Abstractions;
using TestMediator.Domain.Models;

namespace TestMediator.Domain.Queries
{
    class WeatherQueries : IWeatherQueries
    {
        public Task<WeatherResponseModel> GetWeatherAsync(string city, string town)
        {
            // Call services that call repo...
            return Task.Run(() => {
                return new WeatherResponseModel()
                {
                    City = city,
                    Town = town,
                    IsRaining = false,
                    Weather = "Cloudly"
                };
            });            
        }
    }
}
