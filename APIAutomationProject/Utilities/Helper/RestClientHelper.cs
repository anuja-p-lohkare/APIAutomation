using RestSharp;

namespace RestSharpAutomation.HelperClass.Request
{
    public class RestClientHelper
    {
        //Get client
        public RestClient GetRestClient()
        {
            RestClient restClient = new RestClient();
            return restClient;
        }

        //Get request to send
        public RestRequest GetRestRequest(string url, Dictionary<string, string> headers, Method method, object body, DataFormat dataFormat)
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

            return restRequest;
        }

        //Send request
        public RestResponse SendRequest(RestRequest restRequest)
        {
            RestClient restClient = GetRestClient();
            RestResponse restResponse = restClient.Execute(restRequest);
            return restResponse;
        }     
    }
}
