using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using TestMediator.Domain.Abstractions;
using TestMediator.Domain.Commands.Request;
using TestMediator.Domain.Models;

namespace TestMediator.Domain.Commands.Handlers
{
    class WeatherCommandHandler : IRequestHandler<WeatherCommand, WeatherResponseModel>
    {
        private readonly IWeatherQueries _weatherQueries;
        public WeatherCommandHandler(IWeatherQueries weatherQueries)
        {
            _weatherQueries = weatherQueries ?? throw new ArgumentNullException(nameof(weatherQueries));
        }

        public async Task<WeatherResponseModel> Handle(WeatherCommand message, CancellationToken cancellationToken)
        {
            Console.WriteLine("----------- Getting Weather from - Ciudad: " + message.City);

            var res = await _weatherQueries.GetWeatherAsync(message.City, message.Town);

            return res;
        }
    }
}
