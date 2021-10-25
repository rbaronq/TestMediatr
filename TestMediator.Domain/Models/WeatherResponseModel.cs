using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMediator.Domain.Models
{
    public class WeatherResponseModel
    {
        public string City { get; set; }
        public string Town { get; set; }
        public bool IsRaining { get; set; }
        public string Weather { get; set; }
    }
}
