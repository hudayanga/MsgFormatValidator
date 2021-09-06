using System;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

namespace MessageProcessApi.Validator
{
    public abstract class AbstractValidator
    {
        public virtual bool IsValid(string schemaJson,string js)
        {
            JSchema schema = JSchema.Parse(schemaJson);
            JObject msgFormat = JObject.Parse(js);
            bool valid = msgFormat.IsValid(schema);
            return valid;
        }
    }
}
