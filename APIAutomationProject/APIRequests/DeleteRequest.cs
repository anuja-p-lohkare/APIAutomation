using APIAutomationProject.Utilities;
using RestSharp;


namespace APIAutomationProject.APIRequests
{
    public class DeleteRequest
    {
        public bool ExecuteDeleteRequest(string url)
        {
            try
            {
                bool flag = false;
                APIHelper apiHelper = new APIHelper();

                var response = apiHelper.ExecuteRestRequest(url, null, Method.Delete, null);

                if (response.IsSuccessful)
                {
                    flag = true;
                }
                return flag;
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
