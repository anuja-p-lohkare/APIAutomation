using APIAutomationProject.Utilities;
using AventStack.ExtentReports;

[SetUpFixture]
public class OneTimeSetUp
{
    public static ExtentReports extent;

    [OneTimeSetUp]
    public void OneTimeSetup()
    {
        extent = ExtentReportManager.SetExtentReport();
    }

    public static ExtentReports GetExtentInstance()
    {
        return extent;
    }

    [OneTimeTearDown]
    public void CleanUp()
    {
        ExtentReportManager.WriteExtentReport(extent);

        GetPaths.SaveExtentReport("AutomationTestReport");
    }            
}

