using System;
using TechTalk.SpecFlow;
using HomePage_Page_Object;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace StepBindings
{
    [Binding]
    public class SignUpTest {

        Homepage_Page_Object step = new Homepage_Page_Object();

        [SetUp]
        public void SetUp()
        {
            step.driver.Manage().Window.Maximize();
        }

        [Test]
        [Given(@"I am not logged in")]
        public void GivenIAmNotLoggedIn()
        {
       
            step.driver.Navigate().GoToUrl("https://angularjs.realworld.io/");
            step.Click_Signup();
        }
        
        [Test]
        [When(@"I complete the signup form")]
        public void WhenICompleteTheSignupForm()
        {
            step.InputUsername();
            step.InputEmail();
            step.InputPassword();
        }
        
        [Test]
        [Then(@"I am logged in")]
        public void ThenIAmLoggedIn()
        {
            step.ClickSubmit();
            Thread.Sleep(5000);
        }

        [Test]
        [Then(@"Username is displayed")]
        public void ThenUsernameIsDisplayed()
        {
            step.CheckUser();
        }

        [TearDown]
        public void TearDown()
        {
            step.driver.Close();
        }
    }
}
