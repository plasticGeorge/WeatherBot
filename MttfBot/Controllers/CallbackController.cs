﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
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
        private IVkApi _api;
        public CallbackController(IConfiguration configuration, IVkApi api)
        {
            _configuration = configuration;
            _api = api;
        }

        [HttpPost]
        public IActionResult Post([FromBody] Models.Callback callback)
        {
            switch(callback.Type)
            {
                case "confirmation":
                    return Ok(_configuration["Confirmation:202559462"]);
                case "message_new":
                    var mes = Message.FromJson(new VkResponse(callback.Object.SelectToken("message")));
                    _api.Messages.Send(new MessagesSendParams
                    {
                        RandomId = DateTime.Now.Millisecond,
                        PeerId = mes.PeerId,
                        Message = mes.Text
                    });
                    return Ok("ok");
                default:
                    return Ok("ok");
            };
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Redirect("https://www.youtube.com/watch?v=eiqfAdyCEGY");
        }
    }
}
