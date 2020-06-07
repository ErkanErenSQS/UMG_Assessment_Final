using System;
using TechTalk.SpecFlow;
using HomePage_Page;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace StepBindings
{
    [Binding]
    public class SignUpTest {

        private IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]
        [Given(@"I am not logged in")]
        public void GivenIAmNotLoggedIn()
        {
            driver.Navigate().GoToUrl("https://angularjs.realworld.io/");
        }
        
        [Test]
        [When(@"I complete the signup form")]
        public void WhenICompleteTheSignupForm()
        {
            Homepage_Page_Object step = new Homepage_Page_Object(driver);
            step.Click_Signup();
            step.InputUsername();
            step.InputEmail();
            step.InputPassword();
        }
        
        [Test]
        [Then(@"i am logged in")]
        public void ThenIAmLoggedIn()
        {
            Homepage_Page_Object step = new Homepage_Page_Object(driver);
            step.ClickSubmit();
            Thread.Sleep(5000);
            step.CheckUser();
            driver.Quit();
        }

        [Test]
        [Then(@"username is displayed")]
        public void ThenUsernameIsDisplayed()
        {
            Ass

        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}
