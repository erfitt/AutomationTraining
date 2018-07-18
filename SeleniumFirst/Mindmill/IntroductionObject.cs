using AutomationTraining;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class IntroductionObject
    {
        public IntroductionObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[text()='Continue']")]
        public IWebElement popup { get; set; }

        [FindsBy(How = How.Id, Using = "greenstop")]
        public IWebElement fir { get; set; }

        [FindsBy(How = How.Id, Using = "green2stop")]
        public IWebElement sec { get; set; }

        [FindsBy(How = How.Id, Using = "bluestop")]
        public IWebElement thi { get; set; }

        [FindsBy(How = How.Id, Using = "blue2stop")]
        public IWebElement fou { get; set; }

        [FindsBy(How = How.Id, Using = "redstop")]
        public IWebElement fif { get; set; }

        [FindsBy(How = How.Id, Using = "drkbluestop")]
        public IWebElement six { get; set; }

        [FindsBy(How = How.Id, Using = "purple2stop")]
        public IWebElement sev { get; set; }

        [FindsBy(How = How.Id, Using = "blackstop")]
        public IWebElement eig { get; set; }

        [FindsBy(How = How.Id, Using = "fillBeaker")]
        public IWebElement start { get; set; }
      
        public ErrorGuessingPage StartTest()
        {
            Thread.Sleep(300);
            popup.Clicks();
            Actions actions = new Actions(PropertiesCollection.driver);
            actions.MoveToElement(fir).Click().Perform();
            actions.MoveToElement(sec).Click().Perform();
            actions.MoveToElement(thi).Click().Perform();
            actions.MoveToElement(fou).Click().Perform();
            actions.MoveToElement(fif).Click().Perform();
            actions.MoveToElement(six).Click().Perform();
            actions.MoveToElement(sev).Click().Perform();
            actions.MoveToElement(eig).Click().Perform();
            start.Clicks();
            PropertiesCollection.driver.Navigate().GoToUrl("http://mindmill.softjourn.if.ua/MyMindMill/ContinueAssessment");

            return new ErrorGuessingPage();
        }
    }
}
