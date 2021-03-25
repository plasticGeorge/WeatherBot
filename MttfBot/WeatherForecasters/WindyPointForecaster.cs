using MttfBot.Interfaces;
using MttfBot.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace MttfBot.WeatherForecasters
{
    public class WindyPointForecaster : IWeatherForecaster
    {
        public string ApiToken { get; set; }
        public async Task<WindyPointResponse> GetResponse(double lat, double lon)
        {
            HttpResponseMessage response;
            using (HttpClient client = new HttpClient())
            {
                response = await client.PostAsync("https://api.windy.com/api/point-forecast/v2",
                                            JsonContent.Create<WindyPointRequest>(new WindyPointRequest
                                            {
                                                Lat = lat,
                                                Lon = lon,
                                                Model = "gfs",
                                                Parameters = new[] {"wind", "dewpoint", "rh", "pressure"},
                                                Levels = new[] { "surface"},
                                                Key = ApiToken
                                            }));
            }
            return await response.Content.ReadFromJsonAsync<WindyPointResponse>();
        }
    }
}
