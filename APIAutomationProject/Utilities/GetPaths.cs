using AventStack.ExtentReports.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIAutomationProject.Utilities
{
    public class GetPaths
    {
        public static string workingDirectory = Environment.CurrentDirectory;

        public static string GetExtentReportPath()
        {
            var path = Path.Combine(workingDirectory, "Index.html");
            return path;
        }

        public static void SaveExtentReport(string fileName)
        {
            var reportname = fileName +"_"+ DateTime.Now.ToString("hh_MM_ss");
            var extentReportFolder = Path.Combine(workingDirectory, "ExtentReports");            
            var destinationPath = Path.Combine(workingDirectory, "ExtentReports" + Path.DirectorySeparatorChar + reportname + ".html");
            var sourcePath = GetExtentReportPath();

            Directory.CreateDirectory(extentReportFolder);           

            try 
            {
                File.Move(sourcePath, destinationPath);
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
