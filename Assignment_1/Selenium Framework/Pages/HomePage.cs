using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 @name: rashad rouzdeen
 @author: mrmrashad88@gmail.com
 */

namespace Selenium_Framework.Pages
{
    class HomePage
    {

        public HomePage()
        {
            PageFactory.InitElements(PropertiesCollection.Driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//li[@class='login']/descendant::a[text()='Login']")]
        public IWebElement linkLogin { get; set; }

        [FindsBy(How = How.XPath, Using = "//p[@class='form-group email']/descendant::input[@id='um-login-email']")]
        public IWebElement txtEmail { get; set; }

        [FindsBy(How = How.XPath, Using = "//p[@class='form-group password']/descendant::input[@id='um-login-password']")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        public IWebElement btnSubmit { get; set; }

    }
}
