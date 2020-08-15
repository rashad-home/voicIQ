using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;
using System;

/*
 @name: rashad rouzdeen
 @author: mrmrashad88@gmail.com
 */

namespace Selenium_Framework
{
	class ExtentManager
	{
		private static ExtentReports extent;
		private static ExtentTest test;
		private static ExtentHtmlReporter htmlReporter;
		private static String filePath = "C:\\Users\\User\\Downloads\\Selenium Framework\\Reports\\Report.html";

		public static ExtentReports GetExtent()
		{
			if (extent != null)
				return extent; //avoid creating new instance of html file
			extent = new ExtentReports();

			var htmlReporter = new ExtentHtmlReporter(filePath);
			extent.AttachReporter(htmlReporter);


			return extent;
		}


	


		public static ExtentTest createTest(String name, String description)
		{
			test = extent.CreateTest(name, description);
			return test;
		}



	}
}
