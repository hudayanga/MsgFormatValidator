using System;
using System.Collections.Generic;
using System.Linq;
using MessageProcessApi.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

namespace MessageProcessApi
{
    public class MessageProcessor : IMessageProcessor
    {

        private readonly IEnumerable<IMessageValidator> _messageValidators;

        public MessageProcessor(IEnumerable<IMessageValidator> messageValidators)
        {
            _messageValidators = messageValidators.ToList();
        }

       public bool  ValidateSchema(string js)
       {
            int msgAccepted=0;
            foreach (var item in _messageValidators)
            {
                var result = item.Validate(js);
                if (result)
                {
                    msgAccepted++;
                    item.Save(js);   
                }
            }
            return msgAccepted > 0 ? true: false;
       }
    }
}
