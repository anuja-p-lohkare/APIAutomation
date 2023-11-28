using APIAutomationProject.APIRequests;
using APIAutomationProject.Utilities;
using Microsoft.Extensions.Configuration;

namespace APIAutomationProject.Tests
{
    public class APITests
    {

        [Test]
        public void VerifyGetUserRequest()
        {
            var settings = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory().Replace("bin\\Debug\\net6.0", "")).AddJsonFile("appSettings.json").Build();
            string testDataFilePath = settings["TestDataFile"];
            GetRequest gr = new GetRequest();
            string baseUrl = JsonReader.GetTestData("TestGetUserRequest.BaseUrl", testDataFilePath);
            string resource = JsonReader.GetTestData("TestGetUserRequest.Resource", testDataFilePath);
            string url = baseUrl + resource;
            var resDetails= gr.ExexuteGetUserRequest(url);
            string actFstName = resDetails.Item1;
            string actLstname = resDetails.Item2;
            string expFstName = JsonReader.GetTestData("TestGetUserRequest.FirstName", testDataFilePath);
            string expLstName = JsonReader.GetTestData("TestGetUserRequest.LastName", testDataFilePath);
            Assert.That(actFstName, Is.EqualTo(expFstName), "First name is incorrect");
            Assert.That(actLstname, Is.EqualTo(expLstName), "Last name is incorrect");
        }

        [Test]
        public void VerifyCreateUserRequest()
        {
            var settings = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory().Replace("bin\\Debug\\net6.0", "")).AddJsonFile("appSettings.json").Build();
            string testDataFilePath = settings["TestDataFile"];
            PostRequest postreq = new PostRequest();
            string baseUrl = JsonReader.GetTestData("TestCreateUserRequest.BaseUrl", testDataFilePath);
            string resource = JsonReader.GetTestData("TestCreateUserRequest.Resource", testDataFilePath);
            var reqBody = JsonReader.GetPayloadFromTestData("TestCreateUserRequest.RequestBody", testDataFilePath);            
            string url = baseUrl + resource;
            var resDetails = postreq.ExecuteCreateUserRequest(url, reqBody);
            string actName = resDetails.Item1;
            string actRole = resDetails.Item2;
            string expName = JsonReader.GetTestData("TestCreateUserRequest.Name", testDataFilePath);
            string expRole = JsonReader.GetTestData("TestCreateUserRequest.Job", testDataFilePath);
            Assert.That(actName, Is.EqualTo(expName), "Name is incorrect");
            Assert.That(actRole, Is.EqualTo(expRole), "Role is incorrect");
        }

        [Test]
        public void VerifyUpdateUserNameRequest()
        {
            var settings = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory().Replace("bin\\Debug\\net6.0", "")).AddJsonFile("appSettings.json").Build();
            string testDataFilePath = settings["TestDataFile"];
            PutRequest putRes = new PutRequest();
            string baseUrl = JsonReader.GetTestData("TestChangeUserNameRequest.BaseUrl", testDataFilePath);
            string resource = JsonReader.GetTestData("TestChangeUserNameRequest.Resource", testDataFilePath);
            var reqBody = JsonReader.GetPayloadFromTestData("TestChangeUserNameRequest.RequestBody", testDataFilePath);
            string url = baseUrl + resource;            
            string actName = putRes.ExecuteUpdateUserRequest(url, reqBody);            
            string expName = JsonReader.GetTestData("TestChangeUserNameRequest.UpdatedName", testDataFilePath);            
            Assert.That(actName, Is.EqualTo(expName), "Name is incorrect");            
        }

        [Test]
        public void VerifyDeleteRequest()
        {
            var settings = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory().Replace("bin\\Debug\\net6.0", "")).AddJsonFile("appSettings.json").Build();
            string testDataFilePath = settings["TestDataFile"];
            DeleteRequest delReq = new DeleteRequest();
            string baseUrl = JsonReader.GetTestData("TestDeleteRequest.BaseUrl", testDataFilePath);
            string resource = JsonReader.GetTestData("TestDeleteRequest.Resource", testDataFilePath);            
            string url = baseUrl + resource;
            bool isRecDel = delReq.ExecuteDeleteRequest(url);            
            Assert.That(isRecDel, Is.True, "Record is not deleted");
        }
    }
}
