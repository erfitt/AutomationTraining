﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
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
            PropertiesCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");           
        }


        [Test]
        public void ExecuteTest()
        {

            LoginPageObject pageLogin = new LoginPageObject();
            EAPageObject pageEA = pageLogin.Login("execute", "automation");

            pageEA.fillUserForm("KK", "Karthik", "Automation");








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
