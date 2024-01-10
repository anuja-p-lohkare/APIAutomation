using NUnit.Framework.Interfaces;
using AventStack.ExtentReports;
using System.Threading;

namespace APIAutomationProject.Utilities
{
    public class BaseClass
    {
        public ExtentReports extent;
        public static ThreadLocal<ExtentReports> extentRep = new ThreadLocal<ExtentReports>();
        public ExtentTest test;
        public static ThreadLocal<ExtentTest> extentTest = new ThreadLocal<ExtentTest>();

        [SetUp]
        public void BeforeTestSetUp()
        {
            extent = OneTimeSetUp.GetExtentInstance();
            extentRep.Value = extent;
            test = extent.CreateTest(TestContext.CurrentContext.Test.Name);
            extentTest.Value = test;
        }

        [TearDown]
        public void AfterTestActions()
        {
            var testCaseStatus = TestContext.CurrentContext.Result.Outcome.Status;
            var stackTrace = TestContext.CurrentContext.Result.StackTrace;

            if(testCaseStatus == TestStatus.Failed)
            {
                extentTest.Value.Fail("<b><FONT COLOR='RED'>" + "Test case failed:" + "</FONT></b>");
                extentTest.Value.Log(Status.Fail, "Log trace for test case failed: " + stackTrace);
            }
            else if(testCaseStatus == TestStatus.Passed)
            {
                extentTest.Value.Log(Status.Pass, "<b><FONT COLOR='GREEN'>" + "Test case passed successfully" + "</FONT></b>");
            }
        }
    }
}
