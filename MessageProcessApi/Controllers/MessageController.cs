using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using MessageProcessApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.Json;

namespace MessageProcessApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MessageController : ControllerBase
    {
        
        private readonly IMessageProcessor _messageProcessor;

        public MessageController(IMessageProcessor messageProcessor)
        {
            _messageProcessor = messageProcessor;
        }

        [HttpPost]
        public ActionResult Post([FromBody] JsonElement msgFormatA)
        {
            string json = System.Text.Json.JsonSerializer.Serialize(msgFormatA);
            var isValid = _messageProcessor.ValidateSchema(json);
            if (!isValid)
            {
                return BadRequest("Please Check Your Request");
            }
            else
            {
                return Ok("Message Accepted");
            }
        }

    }
}
