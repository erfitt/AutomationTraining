using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumFirst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining
{
    class LoginPageObject
    {
        public LoginPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.Name, Using = "ApplicantID")]
        public IWebElement txtUserName { get; set; }

        [FindsBy(How = How.Name, Using = "UserPassword")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@value='Log On']")]
        public IWebElement btnLogin { get; set; }

        public UserBioData Login (string userName, string password)
        {
            txtUserName.EnterText(userName);
            txtPassword.EnterText(password);
            btnLogin.Submit();

            return new UserBioData();
        }
    }
}
