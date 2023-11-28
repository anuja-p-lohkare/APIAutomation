using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace APIAutomationProject.Utilities
{
    public class JsonReader
    {
        public static string GetTestData(string tokenName, string filePath)
        {
            string jsonString;
            try
            {
                jsonString = File.ReadAllText(filePath);
            }
            catch (Exception ex)
            {
                throw new Exception("Required file not found", ex);
            }
            var jsonObject = JToken.Parse(jsonString);
            return jsonObject.SelectToken(tokenName).Value<string>();
        }

        public static string GetPayloadFromTestData(string tokenName,  string filePath)
        {
            string jsonString;
            try
            {
                jsonString = File.ReadAllText(filePath);
            }
            catch (Exception ex)
            {
                throw new Exception("Required file not found", ex);
            }
            var jsonObject = JToken.Parse(jsonString);
            return jsonObject.SelectToken(tokenName).ToString();            
        }
    }
}
