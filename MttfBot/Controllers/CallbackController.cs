using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using MttfBot.Interfaces;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VkNet.Abstractions;
using VkNet.Model;
using VkNet.Model.RequestParams;
using VkNet.Utils;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MttfBot.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CallbackController : ControllerBase
    {
        private IConfiguration _configuration;
        private IBot _bot;
        public CallbackController(IConfiguration configuration, IBot bot)
        {
            _configuration = configuration;
            _bot = bot;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Models.Callback callback)
        {
            switch (callback.Type)
            {
                case "confirmation":
                    return Ok(_configuration["Confirmation:" + callback.GroupId]);

                case "message_new":
                    await _bot.ProcessRequest(Message.FromJson(new VkResponse(callback.Object)));
                    return Ok("ok");
                default:
                    return Ok("ok");
            };
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hi! I'm working!");
        }
    }
}
