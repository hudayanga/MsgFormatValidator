using MessageProcessApi.Models;
using MessageProcessApi.Service;
using MessageProcessApi.Validator;
using Newtonsoft.Json;

namespace MessageProcessApi
{
    public class MsgFormatBValidator : AbstractValidator, IMessageValidator
    {
        private readonly IMessageRepository _messageRepository;
        public MsgFormatBValidator(IMessageRepository messageRepository)
        {
            _messageRepository = messageRepository;
        }
        public bool Save(string js)
        {
            var message = JsonConvert.DeserializeObject<MsgFormatB>(js);
            _messageRepository.Add(message);
            return true;
        }

        public bool Validate(string js)
        {
            string schemaJson = MessageFormat.MsgFormatB;
            return base.IsValid(schemaJson, js);
        }
    }
}
