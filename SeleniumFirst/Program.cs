using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using SeleniumFirst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationTraining
{
    class Program
    {
       
        static void Main(string[] args)
        {       
        }


        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.driver = new ChromeDriver();
            //PropertiesCollection.driver = new FirefoxDriver();

            PropertiesCollection.driver.Manage().Window.Maximize();
            PropertiesCollection.driver.Navigate().GoToUrl("http://mindmill.softjourn.if.ua/MyMindMill/LogOn");
        }


        [Test]
        public void ExecuteTest()
        {
            LoginPageObject pageLogin = new LoginPageObject();
            UserBioData pageUBIO = pageLogin.Login("Username999", "123");
            PropertiesCollection.driver.Navigate().GoToUrl("http://mindmill.softjourn.if.ua/MyMindMill/BioData");

            IntroductionObject startAssessment = pageUBIO.fillUserBioData("First", "Last", "23", "myEmailhello", "M", "Algeria", "2-5 years", "Masters or Doctorate Level", "Employed Private Sector", "Manager");

            ErrorGuessingPage firstTest = startAssessment.StartTest();

            var realTest = firstTest.FirstTest(5);

            realTest.FirstTest(50);







            //SeleniumSetMethods.SelectDropDown("TitleId", "Mr.", PropertyType.Id);

            //SeleniumSetMethods.EnterText("Initial", "executeautomation", PropertyType.Name);

            //Console.WriteLine("The value from my Title is: " + SeleniumGetMethods.GetTextFromDDL("TitleId", PropertyType.Id));

            //Console.WriteLine("The value from my Initial is: " + SeleniumGetMethods.GetText("Initial", PropertyType.Name));

            //SeleniumSetMethods.Click("Save", PropertyType.Name);
        }


        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.driver.Close();
        }
    }
}
