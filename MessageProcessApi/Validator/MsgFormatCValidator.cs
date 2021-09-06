using MessageProcessApi.Models;
using MessageProcessApi.Service;
using MessageProcessApi.Validator;
using Newtonsoft.Json;

namespace MessageProcessApi
{
    public class MsgFormatCValidator : AbstractValidator, IMessageValidator
    {
        private readonly IMessageRepository _messageRepository;
        public MsgFormatCValidator(IMessageRepository messageRepository)
        {
            _messageRepository = messageRepository;
        }
        public bool Save(string js)
        {
            var message = JsonConvert.DeserializeObject<MsgFormatC>(js);
            _messageRepository.Add(message);
            return true;
        }

        public bool Validate(string js)
        {
            string schemaJson = MessageFormat.MsgFormatC;
            return base.IsValid(schemaJson, js);
        }
    }
}
