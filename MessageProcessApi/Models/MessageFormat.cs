using System;
namespace MessageProcessApi
{
    public static class MessageFormat
    {
        public static string MsgFormatA => @"{
                                    'description': 'MessageFormatA',
                                    'type': 'object',
                                    'maxProperties': 6,
                                    'properties': {
                                                    'id': {'type': 'integer'},
                                                    'from': {'type': 'string'},
                                                    'to': {'type': 'string'},
                                                    'type': {'type': 'string'},
                                                    'text': {'type': 'string'},
                                                    'sendTime': {'type': 'string'}
                                                  },
                                    'additionalProperties': false
                                  }";
        public static string MsgFormatB => @"{
                                    'description': 'MessageFormatB',
                                    'type': 'object',
                                   
                                    'properties': {
                                                    'id': {'type': 'integer'},
                                                    'message': {
                                                                    'type': 'object',
                                                                    'properties': {
                                                                    'type': {'type': 'string'},
                                                                    'id': {'type': 'string'},
                                                                    'text': {'type': 'string'}},
                                                                    'additionalProperties': false
                                                                                                     },
                                                                    
                                                    'source': {
                                                                     'type': 'object',
                                                                    'properties': {
                                                                    'type': {'type': 'string'},
                                                                    'userId': {'type': 'string'}},
                                                                    'additionalProperties': false

                                                                                            },
                                                    'timestamp': {'type': 'string'}
                                                
                                                  },
                                     'additionalProperties': false
                                   
                                  }";
        public static string MsgFormatC => @"{
                                    'description': 'MessageFormatC',
                                    'type': 'object',
                                 
                                    'properties': {
                                                    'id': {'type': 'integer'},
                                                    'msisdn': {'type': 'string'},
                                                    'message': {
                                                                'type': 'object',
                                                                    'properties': {
                                                                'msgText': {'type': 'string'},
                                                                'msgTime': {'type': 'string'}
                                                                                }
                                                                ,'additionalProperties': false
                                                                }
                                                   
                                                  },
                                     'additionalProperties': false
                                  }";
    }
}
