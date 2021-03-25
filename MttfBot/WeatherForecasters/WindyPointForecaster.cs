﻿using MttfBot.Interfaces;
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
        public async Task<string> GetResponse(double lat, double lon)
        {
            HttpResponseMessage response;
            using (HttpClient client = new HttpClient())
            {
                response = await client.PostAsync("https://api.windy.com/api/point-forecast/v2",
                                            JsonContent.Create<WindyPointRequest>(new WindyPointRequest
                                            {
                                                Latitude = lat,
                                                Longitude = lon,
                                                Model = "gfs",
                                                Parameters = JArray.FromObject(new string[] {"wind", "dewpoint", "rh", "pressure"}),
                                                Levels = JArray.FromObject(new string[] { "surface", "150h", "200h" }),
                                                Key = ApiToken
                                            }));
            }
            return await response.RequestMessage.Content.ReadAsStringAsync();
        }
    }
}
