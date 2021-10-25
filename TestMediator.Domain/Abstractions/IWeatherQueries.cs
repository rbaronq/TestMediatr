using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMediator.Domain.Models;

namespace TestMediator.Domain.Abstractions
{
    interface IWeatherQueries
    {
        Task<WeatherResponseModel> GetWeatherAsync(string city, string town);
    }
}
