using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HomePage_Page_Object
{
    class Homepage_Page_Object
    {
        public IWebDriver driver;
        By Email = By.CssSelector("input[placeholder='Email']");
        By InitialSignUp = By.XPath("//a[@href='#/register']");
        By Username = By.CssSelector("input[placeholder='Username']");
        By Password = By.CssSelector("input[placeholder='Password']");
        By SignUpClick = By.CssSelector("button[type='submit']");
        By CheckUserName = By.CssSelector("[ui-sref='app.profile.main({ username: $ctrl.currentUser.username })']");

        public Homepage_Page_Object()
        {
            driver = new ChromeDriver();
        }

        public IWebDriver Getdriver()
        {
            if (driver == null)
            {
                driver = new ChromeDriver();
                return driver;
            }
            else
            {
                return driver;
            }
        }

        public void Open_Homepage()
        {
            driver.Navigate().GoToUrl("https://angularjs.realworld.io/");
        }

        public void Click_Signup()
        {
            IWebElement Initialise = driver.FindElement(InitialSignUp);
            Initialise.Click();
        }

        public void InputUsername()
        {
            driver.FindElement(Username).SendKeys("ErkanErenExpleo");
        }

        public void InputEmail()
        {
            driver.FindElement(Email).SendKeys("Erkan.Eren@expleogroup.com");
        }

        public void InputPassword()
        {
            driver.FindElement(Password).SendKeys("ErkanErenPassword");
        }

        public void ClickSubmit()
        {
            driver.FindElement(SignUpClick).Click();
        }

        public void CheckUser()
        {
            bool Username_Exists = driver.FindElement(CheckUserName).Displayed;
            Assert.True(Username_Exists);
        }
    
    }   
}


    
