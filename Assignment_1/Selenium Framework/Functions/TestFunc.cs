using NUnit.Framework;
using Selenium_Framework.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 @name: rashad rouzdeen
 @author: mrmrashad88@gmail.com
 */

namespace Selenium_Framework.Functions
{
    class TestFunc
    {
        public void Login()
        {
            HomePage home = new HomePage();
            home.linkLogin.Click();
            System.Threading.Thread.Sleep(2000);
            home.txtEmail.EnterText(Prop_Values.Property_values.email);
            System.Threading.Thread.Sleep(2000);
            home.txtPassword.EnterText(Prop_Values.Property_values.password);
            System.Threading.Thread.Sleep(2000);
            home.btnSubmit.Click();
            System.Threading.Thread.Sleep(2000);


        }

        public void CreateWebsite()
        {
            CreateWebsitePage createWebsitePage = new CreateWebsitePage();
            System.Threading.Thread.Sleep(5000);
            createWebsitePage.linkStartBuildingNow.Click();
            System.Threading.Thread.Sleep(10000);
            createWebsitePage.imgSelectTemplate.Click();
            System.Threading.Thread.Sleep(5000);
            createWebsitePage.btnUseThisTemplate.Click();
            System.Threading.Thread.Sleep(2000);
            createWebsitePage.txtWebsiteName.EnterText(Prop_Values.Property_values.siteName);
            System.Threading.Thread.Sleep(2000);
            createWebsitePage.btnContinue.Click();
            System.Threading.Thread.Sleep(20000);
            

        }

        public void AddVideo()
        {
            CreateWidgetsPage createWidgets = new CreateWidgetsPage();

            createWidgets.linkVideo.Click();
            System.Threading.Thread.Sleep(6000);


        }

        public void AddVideoLink()
        {
            CreateWidgetsPage createWidgets = new CreateWidgetsPage();

            System.Threading.Thread.Sleep(10000);
            createWidgets.imgVideo.Click();
            System.Threading.Thread.Sleep(6000);

        }

        public void PublishSite()
        {
            CreateWidgetsPage createWidgets = new CreateWidgetsPage();
            System.Threading.Thread.Sleep(10000);
            createWidgets.btnPublish.Click();
            System.Threading.Thread.Sleep(25000);

        }

            public void BookTitle()
        {
            CreateWidgetsPage signInPopPage = new CreateWidgetsPage();
            CreateWebsitePage createBookPage = new CreateWebsitePage();
            

            System.Threading.Thread.Sleep(2000);
         
            
        }

        public void uploadImage()
        {
            CreateWebsitePage createBookPage = new CreateWebsitePage();
            String filePath = "C:\\Users\\User\\Downloads\\Selenium Framework\\train.jpg";

           /* System.Threading.Thread.Sleep(5000);
            createBookPage.btnUploadPictures.Click();
            System.Threading.Thread.Sleep(2000);
            createBookPage.btnUploadFiles.SendKeys(filePath);
            System.Threading.Thread.Sleep(2000);
            createBookPage.btnUploadButton.Click();
            System.Threading.Thread.Sleep(10000);
           */
        }

       

    }
}
