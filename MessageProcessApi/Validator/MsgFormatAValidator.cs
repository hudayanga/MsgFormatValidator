using MessageProcessApi.Models;
using MessageProcessApi.Service;
using MessageProcessApi.Validator;
using Newtonsoft.Json;

namespace MessageProcessApi
{
    public class MsgFormatAValidator : AbstractValidator,IMessageValidator
    {
        private readonly IMessageRepository _messageRepository;
        public MsgFormatAValidator(IMessageRepository messageRepository)
        {
            _messageRepository = messageRepository;
        }
        public bool Save(string js)
        {         
            var message = JsonConvert.DeserializeObject<MsgFormatA>(js);
            _messageRepository.Add(message);
            return true;
        }

        public bool Validate(string js)
        {
            string schemaJson = MessageFormat.MsgFormatA;
            return base.IsValid(schemaJson,js);            
        }

       
    }
}
