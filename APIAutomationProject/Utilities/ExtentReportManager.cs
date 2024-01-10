using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace APIAutomationProject.Utilities
{
    public class ExtentReportManager
    {
        public static ExtentReports extent;
        public static ExtentHtmlReporter extentHtmlReporter;
        public static ExtentTest test;

        public static ExtentReports SetExtentReport()
        {
            var reportPath = GetPaths.GetExtentReportPath();

            extentHtmlReporter = new ExtentHtmlReporter(reportPath);

            extent = new ExtentReports();

            extent.AttachReporter(extentHtmlReporter);
            extent.AddSystemInfo("User", "AutomationUser");

            return extent;
        }

        public static void WriteExtentReport(ExtentReports extent)
        {
            extent.Flush();
        }
    }
}
