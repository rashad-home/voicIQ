using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using Selenium_Framework.Functions;
using Selenium_Framework.Pages;
using System;

/*
 @name: rashad rouzdeen
 @author: mrmrashad88@gmail.com
 @testsase: Sign in through email and create a site
 */

namespace Selenium_Framework
{
	[TestFixture]
	class LoginEmail : Hooks
	{
		private static ExtentReports extent;
		private ExtentTest childTest1;


		public LoginEmail() : base(BrowserType.Firefox)
		{
		}
		[OneTimeSetUp]
		public void SetupReporting()
		{
			extent = ExtentManager.GetExtent();
			
			//Create Extent Test
			ExtentTest test = extent.CreateTest("Sign In Using Email", "Create book with photoes");
			childTest1 = test.CreateNode("Test signin / signout and createbook");
			
		}
		[SetUp]
		public void Initialize()
		{
			//Navigate to ASPDotNetPage from Chrome
			Driver.Navigate().GoToUrl(Prop_Values.Property_values.URL);
			Driver.Manage().Window.Maximize();
		}


		[Test]
		public void CreateSite()
		{
			try
			{
				/*Functions and Page class Initialization*/
				TestFunc testFunc = new TestFunc();
                HomePage testclasspage = new HomePage();
                CreateWidgetsPage signInPopPage = new CreateWidgetsPage();
				CreateWebsitePage createBookPage = new CreateWebsitePage();
				CreateWidgetsPage createWidgets = new CreateWidgetsPage();


				childTest1.Info("Entering to yola site");
				childTest1.Info("Click Login");
				testFunc.Login();
                System.Threading.Thread.Sleep(6000);
				childTest1.Info("Create Website");
				testFunc.CreateWebsite();
                System.Threading.Thread.Sleep(25000);
				childTest1.Info("Enter Page iFrame");
				Driver.SwitchTo().Frame(createWidgets.iframePage);
                Actions action = new Actions(Driver);
				action.MoveByOffset(200,30).Perform();
				action.Click().Build().Perform();
                System.Threading.Thread.Sleep(3000);
				childTest1.Info("Click add button");
				action.MoveToElement(createWidgets.btnAdd).Perform();
				action.Click().Build().Perform();

                System.Threading.Thread.Sleep(10000);
				childTest1.Info("Add Video");
				testFunc.AddVideo();
                System.Threading.Thread.Sleep(5000);
				
				Driver.SwitchTo().Frame(createWidgets.iframeVideo);
				System.Threading.Thread.Sleep(3000);
				testFunc.AddVideoLink();

                Driver.SwitchTo().DefaultContent();
                System.Threading.Thread.Sleep(3000);
                Driver.SwitchTo().Frame(createWidgets.iframePage);
                System.Threading.Thread.Sleep(3000);
				childTest1.Info("Publish Site");
				testFunc.PublishSite();
				Driver.SwitchTo().DefaultContent();
				System.Threading.Thread.Sleep(3000);

				try
				{
						Assert.IsTrue(createWidgets.lblsite.Displayed);
						childTest1.Info("User Should be able to create a site succussfully");
						childTest1.Pass("Assertion passed");

						string screenShotPath = ScreenshotReport.Capture(Driver, "EmailLoginPassed");
						childTest1.Log(childTest1.Status, "Snapshot below: " + childTest1.AddScreenCaptureFromPath(screenShotPath));
					}
					catch (AssertionException)
					{
						childTest1.Info("User cannot create a site");
						childTest1.Fail("Assertion failed");
						string screenShotPath = ScreenshotReport.Capture(Driver, "EmailLoginFailed");
						childTest1.Log(childTest1.Status, "Snapshot below: " + childTest1.AddScreenCaptureFromPath(screenShotPath));
						throw;
					}

					


					

				extent.Flush();
			}
			catch (Exception e)
			{
				childTest1.Fail("Test Exception Failed");
				childTest1.Fail(e.Message);
				string screenShotPath = ScreenshotReport.Capture(Driver, "SiteCreationFailed");
				childTest1.Log(childTest1.Status, "Snapshot below: " + childTest1.AddScreenCaptureFromPath(screenShotPath));
				extent.Flush();
				throw new Exception(e.Message);
			}
		}
		[TearDown]
		public void CleanUp()
		{
			// Closing Chrome Driver
			extent.Flush();
			Driver.Close();
		}
		
	}


}
