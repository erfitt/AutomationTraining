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
    class ErrorGuessingPage
    {
        public ErrorGuessingPage()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[text()='Continue']")]
        public IWebElement popup { get; set; }

        [FindsBy(How = How.Id, Using = "tinextstage")]
        public IWebElement nextStep { get; set; }

        [FindsBy(How = How.Id, Using = "sentenceval1")]
        public IWebElement sentence1 { get; set; }

        [FindsBy(How = How.Id, Using = "sentence2")]
        public IWebElement sentence2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[text()='START']")]
        public IWebElement startReal { get; set; }

        public ErrorGuessingPage FirstTest(int count)
        {
            Thread.Sleep(500);
            try { popup.Click(); }
            catch { }

            Actions actions = new Actions(PropertiesCollection.driver);            
            Loop(actions, count);

            try { startReal.Click(); }
            catch { }
            Thread.Sleep(100);

            return new ErrorGuessingPage();
        }

        private void Loop(Actions actions, int loopLength)
        {           
            for (int i = 0; i < loopLength; i++)
            {
                string firstSent = sentence1.Text;
                string secondSent = sentence2.Text;

                int count = 0;
                for (int j = 0; j < firstSent.Length; j++)
                {
                    if (firstSent[j] != secondSent[j])
                        count++;
                }
                
                actions.MoveToElement(nextStep).Click().Perform();
                Thread.Sleep(50);
                Switcher(count);
                Thread.Sleep(50);
            }
        }

        private void Switcher(int count)
        {
            switch (count)
            {
                case 0:
                    PropertiesCollection.driver.FindElement(By.XPath("//input[@value='0']")).Click();
                    break;
                case 1:
                    PropertiesCollection.driver.FindElement(By.XPath("//input[@value='1']")).Click();
                    break;
                case 2:
                    PropertiesCollection.driver.FindElement(By.XPath("//input[@value='2']")).Click();
                    break;
                case 3:
                    PropertiesCollection.driver.FindElement(By.XPath("//input[@value='3']")).Click();
                    break;
                case 4:
                    PropertiesCollection.driver.FindElement(By.XPath("//input[@value='4']")).Click();
                    break;
            }
        }
    }
}
