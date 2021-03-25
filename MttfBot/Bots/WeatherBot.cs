﻿using MttfBot.Interfaces;
using VkNet.Model;
using System;
using System.Threading.Tasks;
using VkNet.Abstractions;
using VkNet.Model.RequestParams;

namespace MttfBot.Bots
{
    public class WeatherBot : IBot
    {
        public IVkApi VkApi { get; private set; }
        public IWeatherForecaster WeatherForecaster { get; private set; }

        public WeatherBot(IVkApi vkApi, IWeatherForecaster weatherForecaster)
        {
            VkApi = vkApi;
            WeatherForecaster = weatherForecaster;
        }

        public async Task ProcessRequest(Message message)
        {
            if(message.Geo != null)
            {
                await VkApi.Messages.SendAsync(new MessagesSendParams
                {
                    RandomId = DateTime.Now.Millisecond,
                    UserId = message.FromId,
                    Message = WeatherForecaster.GetResponse(message.Geo.Coordinates.Latitude, message.Geo.Coordinates.Longitude).Result.Substring(0, 4096)
                });
            }
            switch (message.Text)
            {
                case "Начать":
                    await VkApi.Messages.SendAsync(new MessagesSendParams
                    {
                        RandomId = DateTime.Now.Millisecond,
                        UserId = message.FromId,
                        Message = "Привет! Меня зовут WeatherBot. Я создан чтобы сообщать " +
                        "тебе актуальную погоду в какой бы точке земного шара ты не оказался.\n" +
                        "Напиши мне город, погоду в котором хочешь узнать, и я дам тебе прогноз на ближайшие 3 дня " +
                        "или выбери другую вторую опцию и укажи интересующие даты, только помни, " +
                        "что более дальние прогнозы менее точны"
                    });
                    break;
                case "~check":
                    //await VkApi.Messages.SendAsync(new MessagesSendParams
                    //{
                    //    RandomId = DateTime.Now.Millisecond,
                    //    UserId = message.FromId,
                    //    Message = 
                    //});
                    break;
            }
        }
    }
}
