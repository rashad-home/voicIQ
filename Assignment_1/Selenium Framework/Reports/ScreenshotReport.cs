using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 @name: rashad rouzdeen
 @author: mrmrashad88@gmail.com
 */

namespace Selenium_Framework
{
	class ScreenshotReport
	{

		public static string Capture(IWebDriver driver, string screenShotName)
		{
			ITakesScreenshot ts = (ITakesScreenshot)driver;
			Screenshot screenshot = ts.GetScreenshot();
			string pth = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
			string finalpth = "C:\\Users\\User\\Downloads\\Selenium Framework\\Reports\\Screenshots\\" + screenShotName + ".png";
			string localpath = new Uri(finalpth).LocalPath;
			screenshot.SaveAsFile(localpath, ScreenshotImageFormat.Png);
			return localpath;
		}

	}
}
