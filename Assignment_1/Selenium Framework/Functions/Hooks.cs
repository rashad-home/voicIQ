using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
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
	public enum BrowserType
	{
		Chrome,
		Firefox,
		IE
	}

	[TestFixture]
	class Hooks : PropertiesCollection
	{
		private BrowserType _browserType;

		public Hooks(BrowserType browser)
		{
			_browserType = browser;
		}

		[SetUp]
		public void InitializeTest()
		{
			chooseDriverInstance(_browserType);
		}

		private void chooseDriverInstance(BrowserType browserType)
		{
			if (browserType == BrowserType.Chrome)
				Driver = new ChromeDriver();
			else if (browserType == BrowserType.Firefox)
				Driver = new FirefoxDriver();
		}



	}
}
