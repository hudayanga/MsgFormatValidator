# MsgFormatValidator
Please follow below steps to run API

Step 1- Open Solution in Visual Studio 

Step 2- Change environment variable "SQLite" value to attached database file path in launchSettings.json file
"environmentVariables": {
        "SQLite": "Data Source=/test.sqlite3"
      }

Step 3- Run the application, Application will launch the swagger endpoint

Step 4- Test Api using POST requests

below are some accepted formats and Invalid formats

MsgFormat A

{
  "from": "test from",
  "to": "test to",
  "type": "test type",
  "text": "test text",
  "sendTime": "2021-09-04T13:00:17.503Z"
}

Valid

{
  "frrom": "test from",
  "to": "test to",
  "type": "test type",
  "text": "test text",
  "sendTime": "2021-09-04T13:00:17.503Z"
}

Invalid

MsgFormat B

{
   "message":{
      "type":"hellovvv",
      "id":"dfsfsf",
      "text":"Hello"
   },
   "source":{
      "type":"user",
      "userId":"qwerty"
   },
   "timestamp":"1629680508"
}

Valid

{
   "message":{
      "type": 666,
      "id":"dfsfsf",
      "text":"Hello"
   },
   "source":{
      "type":"user",
      "userId":"qwerty"
   },
   "timestamp":"1629680508"
}

Invalid

MsgFormat C

{
   "msisdn":"addada",
   "message":{
      "msgText":"Hello",
      "msgTime":"adada"
   }
}


Valid

{
   "msiisdn":"addada",
   "meszzsage":{
      "msgText":"Hello",
      "msgTime":"adada"
   }
}
Invalid