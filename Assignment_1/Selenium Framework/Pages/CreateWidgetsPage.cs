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
    class CreateWidgetsPage
    {

        public CreateWidgetsPage()
        {
            PageFactory.InitElements(PropertiesCollection.Driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//button[@class='ws-floating-action__button']")]
        public IWebElement btnAdd { get; set; }

        [FindsBy(How = How.XPath, Using = "//ul[@class='ws-tag-list__list']/descendant::li[text()='Video']")]
        public IWebElement linkVideo { get; set; }

        [FindsBy(How = How.XPath, Using = "//section[@data-tag-index='17']/descendant::div/div[@data-index='0']")]
        public IWebElement imgVideo { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='editor']/descendant::iframe")]
        public IWebElement iframePage { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='ws-popover__trigger']/descendant::button[text()='Publish']")]
        public IWebElement btnPublish { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[text()='We have lift off!']")]
        public IWebElement lblsite { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='iframe-block-live-preview-viewport']/descendant::iframe")]
        public IWebElement iframeVideo { get; set; }


    }
}
