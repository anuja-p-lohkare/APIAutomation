using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharpAutomation.HelperClass.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIAutomationProject.APIRequests
{
    public class DeleteRequest
    {
        public bool ExecuteDeleteRequest(string url)
        {
            RestClientHelper rch = new RestClientHelper();
            bool flag = false;
            var request = rch.GetRestRequest(url, null, Method.Delete, null, DataFormat.Json);
            var response = rch.SendRequest(request);
            if (response.IsSuccessful)
            {
                flag = true;
            }
            return flag;
        }
    }
}
