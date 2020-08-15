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
	enum PropertyType
	{

		id,
		Name,
		LinkText,
		ClassName,
		XPath

	}


	class PropertiesCollection
	{
		//Auto Implemented Property Chrome
		public static IWebDriver Driver { set; get; }

        
    }
}
