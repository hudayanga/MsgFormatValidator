using System;
namespace MessageProcessApi
{
    public interface IMessageValidator
    {
        public bool Validate(string js);

        public bool Save(string js);

    }

    
}
