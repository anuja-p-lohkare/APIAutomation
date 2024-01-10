using APIAutomationProject.APIRequests;
using APIAutomationProject.Utilities;
using AventStack.ExtentReports;
using Microsoft.Extensions.Configuration;

namespace APIAutomationProject.Tests
{
    public class APITests: BaseClass
    {
        [Test]
        public void VerifyGetUserRequest()
        {
            extentTest.Value.Info("<b><FONT COLOR='BLUE'>"+"Test case started" +"</FONT></b>");
            var settings = new ConfigurationBuilder().SetBasePath(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName).AddJsonFile("appSettings.json").Build();
            string testDataFilePath = settings["TestDataFile"];

            GetRequest gr = new GetRequest();

            string baseUrl = TestDataReader.GetTestData("testGetUserRequest.baseUrl", testDataFilePath);
            string resource = TestDataReader.GetTestData("testGetUserRequest.resource", testDataFilePath);
            string url = baseUrl + resource;

            extentTest.Value.Info("Execute get user request");

            var resDetails= gr.ExexuteGetUserRequest(url);

            string actFstName = resDetails.Item1;
            string actLstname = resDetails.Item2;
            string expFstName = TestDataReader.GetTestData("testGetUserRequest.firstName", testDataFilePath);
            string expLstName = TestDataReader.GetTestData("testGetUserRequest.lastName", testDataFilePath);

            Assert.That(actFstName, Is.EqualTo(expFstName), "First name is incorrect");
            Assert.That(actLstname, Is.EqualTo(expLstName), "Last name is incorrect");

            extentTest.Value.Info("Executed get user request and validated firstname and lastname");

            extentTest.Value.Info("<b><FONT COLOR='BLUE'>" + "Test case completed" + "</FONT></b>");
        }

        [Test]
        public void VerifyCreateUserRequest()
        {
            extentTest.Value.Info("<b><FONT COLOR='BLUE'>" + "Test case started" + "</FONT></b>");
            var settings = new ConfigurationBuilder().SetBasePath(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName).AddJsonFile("appSettings.json").Build();
            string testDataFilePath = settings["TestDataFile"];

            PostRequest postreq = new PostRequest();

            string baseUrl = TestDataReader.GetTestData("testCreateUserRequest.baseUrl", testDataFilePath);
            string resource = TestDataReader.GetTestData("testCreateUserRequest.resource", testDataFilePath);
            var reqBody = TestDataReader.GetPayloadFromTestData("testCreateUserRequest.requestBody", testDataFilePath);            
            string url = baseUrl + resource;

            extentTest.Value.Info("Execute Create user request");

            var resDetails = postreq.ExecuteCreateUserRequest(url, reqBody);

            string actName = resDetails.Item1;
            string actRole = resDetails.Item2;
            string expName = TestDataReader.GetTestData("testCreateUserRequest.name", testDataFilePath);
            string expRole = TestDataReader.GetTestData("testCreateUserRequest.job", testDataFilePath);

            Assert.That(actName, Is.EqualTo(expName), "Name is incorrect");
            Assert.That(actRole, Is.EqualTo(expRole), "Role is incorrect");

            extentTest.Value.Info("Executed create user request and it is successful");
            extentTest.Value.Info("<b><FONT COLOR='BLUE'>" + "Test case completed" + "</FONT></b>");
        }

        [Test]
        public void VerifyUpdateUserNameRequest()
        {
            extentTest.Value.Info("<b><FONT COLOR='BLUE'>" + "Test case started" + "</FONT></b>");
            var settings = new ConfigurationBuilder().SetBasePath(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName).AddJsonFile("appSettings.json").Build();
            string testDataFilePath = settings["TestDataFile"];

            PutRequest putRes = new PutRequest();

            string baseUrl = TestDataReader.GetTestData("testChangeUserNameRequest.baseUrl", testDataFilePath);
            string resource = TestDataReader.GetTestData("testChangeUserNameRequest.resource", testDataFilePath);
            var reqBody = TestDataReader.GetPayloadFromTestData("testChangeUserNameRequest.requestBody", testDataFilePath);
            string url = baseUrl + resource;

            extentTest.Value.Info("Excute update user request");

            string actName = putRes.ExecuteUpdateUserRequest(url, reqBody);            
            string expName = TestDataReader.GetTestData("testChangeUserNameRequest.updatedName", testDataFilePath);
            
            Assert.That(actName, Is.EqualTo(expName), "Name is incorrect");

            extentTest.Value.Info("Executed update user request and user details are updated successfully");
            extentTest.Value.Info("<b><FONT COLOR='BLUE'>" + "Test case started" + "</FONT></b>");
        }

        [Test]
        public void VerifyDeleteRequest()
        {
            extentTest.Value.Info("<b><FONT COLOR='BLUE'>" + "Test case started" + "</FONT></b>");
            var settings = new ConfigurationBuilder().SetBasePath(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName).AddJsonFile("appSettings.json").Build();
            string testDataFilePath = settings["TestDataFile"];

            DeleteRequest delReq = new DeleteRequest();

            string baseUrl = TestDataReader.GetTestData("testDeleteRequest.baseUrl", testDataFilePath);
            string resource = TestDataReader.GetTestData("testDeleteRequest.resource", testDataFilePath);            
            string url = baseUrl + resource;

            extentTest.Value.Info("Execute delete user request");

            bool isRecDel = delReq.ExecuteDeleteRequest(url); 
            
            Assert.That(isRecDel, Is.True, "Record is not deleted");

            extentTest.Value.Info("Delete user request executed and user is deleted successfully");
            extentTest.Value.Info("<b><FONT COLOR='BLUE'>" + "Test case started" + "</FONT></b>");
        }
    }
}
