using MediatR;
using TestMediator.Domain.Models;

namespace TestMediator.Domain.Commands.Request
{
    public class WeatherCommand : IRequest<WeatherResponseModel>
    {
        public string City { get; private set; }

        public string Town { get; private set; }

        public WeatherCommand(string town, string city) 
        {
            City = city;
            Town = town;
        }
    }
}
