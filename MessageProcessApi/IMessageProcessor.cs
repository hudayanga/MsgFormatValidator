using System;
namespace MessageProcessApi
{
    public interface IMessageProcessor
    {
        public bool ValidateSchema(string js);
    }
}
