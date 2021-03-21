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
                case "&#128205;":
                    await VkApi.Messages.SendAsync(new MessagesSendParams
                    {
                        RandomId = DateTime.Now.Millisecond,
                        UserId = message.FromId,
                        Message = "Из какого вы города?"
                    });
                    break;
                case "1 &#128197; 1":
                    await VkApi.Messages.SendAsync(new MessagesSendParams
                    {
                        RandomId = DateTime.Now.Millisecond,
                        UserId = message.FromId,
                        Message = message.Text
                    });
                    break;
                case "&#128293;":
                    await VkApi.Messages.SendAsync(new MessagesSendParams
                    {
                        RandomId = DateTime.Now.Millisecond,
                        UserId = message.FromId,
                        Message = "Вот ваш прогноз: "
                    });
                    break;
                case "&#9200;":
                    await VkApi.Messages.SendAsync(new MessagesSendParams
                    {
                        RandomId = DateTime.Now.Millisecond,
                        UserId = message.FromId,
                        Message = "Уведомления включены"
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
