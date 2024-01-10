using RestSharp;

namespace APIAutomationProject.Utilities
{
    public class APIHelper
    {
        public RestClient GetRestClient()
        {
            RestClient restClient = new RestClient();
            return restClient;
        }


        public RestResponse ExecuteRestRequest(string url, Dictionary<string, string> headers, Method method, object body)
        {
            RestRequest restRequest = new RestRequest()
            {
                Method = method,
                Resource = url
            };

            if (headers != null)
            {
                foreach (string key in headers.Keys)
                {
                    restRequest.AddHeader(key, headers[key]);
                }
            }

            if (body != null)
            {
                restRequest.AddBody(body);
            }

            RestClient restClient = GetRestClient();
            RestResponse restResponse = restClient.Execute(restRequest);
            return restResponse;


        }


    }
}
