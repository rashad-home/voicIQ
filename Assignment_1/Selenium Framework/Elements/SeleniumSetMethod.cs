using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Framework
{

	public static class SeleniumSetMethod
	{
		//Enter Text method
		public static void EnterText(this IWebElement element, string value)
		{

			/* if(elementType == PropertyType.id )
				 PropertiesCollection.driver.FindElement(By.Id(element)).SendKeys(value);

			 if (elementType == PropertyType.Name)
				 PropertiesCollection.driver.FindElement(By.Name(element)).SendKeys(value); */

			element.SendKeys(value);


		}

		//Click method
		public static void Click(this IWebElement element)
		{

			//if (elementType == PropertyType.id)
			//    PropertiesCollection.driver.FindElement(By.Id(element)).Click();

			//if (elementType == PropertyType.Name)
			//    PropertiesCollection.driver.FindElement(By.Name(element)).Click();

			element.Click();

		}

		//Select drop down method
		public static void SelectDropDown(IWebElement element, string value)
		{

			//if (elementType == PropertyType.id)
			//    new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).SelectByText(value);

			//if (elementType == PropertyType.Name)
			//    new SelectElement(PropertiesCollection.driver.FindElement(By.Name(element))).SelectByText(value);

			new SelectElement(element).SelectByText(value);

		}

		//Submit method
		public static void Submit(this IWebElement element)
		{
			element.Submit();
		}

		//Click method
		public static void Clear(this IWebElement element)
		{
			element.Clear();
		}


	}
		

	
}
