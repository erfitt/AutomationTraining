using AutomationTraining;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class UserBioData
    {
        public UserBioData()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);           
        }

        [FindsBy(How = How.Id, Using = "FirstName")]
        public IWebElement txtFirst { get; set; }

        [FindsBy(How = How.Id, Using = "LastName")]
        public IWebElement txtLast { get; set; }

        [FindsBy(How = How.Id, Using = "Age")]
        public IWebElement txtAge { get; set; }

        [FindsBy(How = How.Id, Using = "Email")]
        public IWebElement txtEmail { get; set; }

        //DropDowns
        [FindsBy(How = How.Id, Using = "Gender")]
        public IWebElement ddlGender { get; set; }

        [FindsBy(How = How.Id, Using = "uae")]
        public IWebElement ddlCountry{ get; set; }

        [FindsBy(How = How.Id, Using = "Custom2")]
        public IWebElement ddlExperiance { get; set; }

        [FindsBy(How = How.Id, Using = "Highest_Education_Level")]
        public IWebElement ddlEducation { get; set; }

        [FindsBy(How = How.Id, Using = "Current_Work_Status")]
        public IWebElement ddlWork { get; set; }

        [FindsBy(How = How.Id, Using = "Prior_Job_Level")]
        public IWebElement ddlLevel { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@value='Save']")]
        public IWebElement btnSave { get; set; }

        public IntroductionObject fillUserBioData(string firstName, string lastName, string age, string email, string gender, string country, string experiance, string education, string work, string level)
        {
            if (txtFirst == null)
            {
                txtFirst.EnterText(firstName);
                txtLast.EnterText(lastName);
                txtAge.EnterText(age);
                txtEmail.EnterText(email);
                ddlGender.SelectDropDown(gender);
                ddlCountry.SelectDropDown(country);
                ddlExperiance.SelectDropDown(experiance);
                ddlEducation.SelectDropDown(education);
                ddlWork.SelectDropDown(work);
                ddlLevel.SelectDropDown(level);
                btnSave.Submit();
            }
            else
                btnSave.Submit();

            return new IntroductionObject();
        }


    }
}
