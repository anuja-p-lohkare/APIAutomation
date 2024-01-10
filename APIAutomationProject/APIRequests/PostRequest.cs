using APIAutomationProject.Utilities;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace APIAutomationProject.APIRequests
{
    public class PostRequest
    {
        public (string, string) ExecuteCreateUserRequest(string url, object payload)
        {
            try
            {
                string name = null;
                string role = null;
                APIHelper apiHelper = new APIHelper();

                var response = apiHelper.ExecuteRestRequest(url, null, Method.Post, payload);

                if (response.IsSuccessful)
                {
                    var resDetails = JToken.Parse(response.Content);

                    name = resDetails.SelectToken("name").Value<string>();
                    role = resDetails.SelectToken("job").Value<string>();
                }
                return (name, role);
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
