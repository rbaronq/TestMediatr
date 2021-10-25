using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net;
using System.Threading.Tasks;
using TestMediator.Domain.Commands.Request;
using TestMediator.Domain.Models;

namespace TestMediator.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherController : ControllerBase
    {

        private readonly ILogger<WeatherController> _logger;
        private readonly IMediator _mediator;

        public WeatherController(ILogger<WeatherController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        /// <summary>
        /// Get Weather
        /// </summary>
        /// <param name="city"></param>
        /// <param name="town"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{city}/{town}")]
        [ProducesResponseType(typeof(WeatherResponseModel), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.Forbidden)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        public async Task<WeatherResponseModel> Get(string city, string town)
        {
            var model = new WeatherCommand(town, city);

            var response = await _mediator.Send(model);

            return response;
        }
    }
}
