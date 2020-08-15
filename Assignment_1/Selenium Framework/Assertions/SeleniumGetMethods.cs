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
	class SeleniumGetMethods
	{

		public static string GetText(IWebElement element, PropertyType elementType)
		{
			//if (elementType == PropertyType.id)
			//    return PropertiesCollection.driver.FindElement(By.Id(element)).GetAttribute("value");
			//if (elementType == PropertyType.Name)
			//    return PropertiesCollection.driver.FindElement(By.Name(element)).GetAttribute("value");
			//else return String.Empty;

			return element.GetAttribute("value");

		}

		public static string GetUserEmail(IWebElement element, PropertyType elementType)
		{

			return element.Text;
		}

	}
}
