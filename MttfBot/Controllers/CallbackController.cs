using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MttfBot.Models;
using Newtonsoft.Json;
using System;
using VkNet.Abstractions;
using VkNet.Model;
using VkNet.Model.RequestParams;
using VkNet.Utils;

namespace VkBot.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CallbackController : ControllerBase
    {
        /// <summary>
        /// Конфигурация приложения
        /// </summary>
        private readonly IConfiguration _configuration;
        private readonly IVkApi _api;

        public CallbackController(IConfiguration configuration, IVkApi api)
        {
            _configuration = configuration;
            _api = api;
        }

        [HttpPost]
        public IActionResult Callback([FromBody] Updates updates)
        {
            _api.Messages.Send(new MessagesSendParams
            {
                RandomId = DateTime.Now.Millisecond,
                PeerId = 349724532,
                Message = "success"
            });
            // Тип события
            switch (updates.Type)
            {
                // Ключ-подтверждение
                case "confirmation":
                    {
                        return Ok(_configuration["Config:Confirmation"]);
                    }

                // Новое сообщение
                case "message_new":
                    {
                        // Десериализация
                        var msg = Message.FromJson(new VkResponse(updates.Object));

                        _api.Messages.Send(new MessagesSendParams
                        {
                            RandomId = DateTime.Now.Millisecond,
                            PeerId = msg.PeerId,
                            Message = msg.Text
                        });

                        break;
                    }
            }

            return Ok("ok");
        }
    }
}
