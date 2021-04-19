using System;

namespace Highlighters
{
    public class LanguageInjection
    {
        private void LanguageInjection1()
        {
            string regex = "([A-Z])\\w++ \\D%% (?i-:xyz)";
            string html = "<p>test</p";
            string jso2n = "{\r\n    \"date\": \"2018-05-06\"}";
            string json = "[\r\n  {\r\n    \"date\": \"2018-05-06\",\r\n    \"temperatureC\": 1,\r\n    \"summary\": \"Freezing\"\r\n  },\r\n  {\r\n    \"date\": \"2018-05-07\",\r\n    \"temperatureC\": 14,\r\n    \"summary\": \"Bracing\"\r\n  },\r\n  {\r\n    \"date\": \"2018-05-08\",\r\n    \"temperatureC\": -13,\r\n    \"summary\": \"Freezing\"\r\n  },\r\n  {\r\n    \"date\": \"2018-05-09\",\r\n    \"temperatureC\": -16,\r\n    \"summary\": \"Balmy\"\r\n  },\r\n  {\r\n    \"date\": \"2018-05-10\",\r\n    \"temperatureC\": -2,\r\n    \"summary\": \"Chilly\"\r\n  }\r\n]";
            string xml = "<food><name>Name</food>";
            string js = "const name = 'James'\r\n\r\nconst person = { first: name }\r\n\r\nconsole.log(person)\r\nvar ref = /foo        bar/;\r\nconst message = 'Hello, World';\r\n\r\nconst sayHelloLinting = (fName) => {\r\n    console.log(`Hello linting, ${fName}`);\r\n};";
            string css = "\r\n.btn-primary {\r\n    color: #fff;\r\n    background-color: #1b6ec2;\r\n    border-color: #1861ac;\r\n}\r\n";
            
            string a = "a/{*x?}/";
        }

        private void Test22()
        {
            Console.WriteLine("test")
        }


        // 
    }
}