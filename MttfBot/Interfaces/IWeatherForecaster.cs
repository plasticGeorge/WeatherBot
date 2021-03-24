using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MttfBot.Interfaces
{
    public interface IWeatherForecaster
    {
        public string ApiToken { get; set; }
        public Task<string> GetResponse(double lat, double lon);
    }
}
