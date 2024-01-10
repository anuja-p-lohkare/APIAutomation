using APIAutomationProject.Utilities;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace APIAutomationProject.APIRequests
{
    public class PutRequest
    {
        public string ExecuteUpdateUserRequest(string url, object payload)
        {
            try
            {
                string name = null;
                var apiHelper = new APIHelper();

                var response = apiHelper.ExecuteRestRequest(url, null, Method.Put, payload);

                if (response.IsSuccessful)
                {
                    var resDetails = JToken.Parse(response.Content);
                    name = resDetails.SelectToken("name").Value<string>();
                }
                return name;
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
