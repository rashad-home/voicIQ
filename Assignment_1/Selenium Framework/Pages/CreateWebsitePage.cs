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
    class CreateWebsitePage
    {

        public CreateWebsitePage()
        {
            PageFactory.InitElements(PropertiesCollection.Driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[@class='create-site']")]
        public IWebElement linkStartBuildingNow { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='template-thumb']/descendant::img[@src='https://cdn.ws-platform.net/template-build-previews/4245c21db4afef0f7022004a8b0ee62c.jpg']")]
        public IWebElement imgSelectTemplate { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='header--right-container']/descendant::button[text()='Use this template']")]
        public IWebElement btnUseThisTemplate { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='prompt-modal__content']/descendant::input[@class='prompt-modal__field']")]
        public IWebElement txtWebsiteName { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@class='prompt-modal__submit']")]
        public IWebElement btnContinue { get; set; }



    }
}
