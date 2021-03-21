using MttfBot.Interfaces;
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
        string str = "";

        public WeatherBot(IVkApi vkApi)
        {
            VkApi = vkApi;
        }

        public async Task ProcessRequest(Message message)
        {
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
                case "Выбрать город":

                    break;
                case "Выбрать даты":

                    break;
                case "~check":
                    if (str == "off" || str == "")
                        str = "on";
                    else
                        str = "off";
                    await VkApi.Messages.SendAsync(new MessagesSendParams
                    {
                        RandomId = DateTime.Now.Millisecond,
                        UserId = message.FromId,
                        Message = str
                    });
                    break;
            }
        }
    }
}
