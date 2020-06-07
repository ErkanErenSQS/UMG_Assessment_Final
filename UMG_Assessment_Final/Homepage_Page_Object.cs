using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HomePage_Page
{
    class Homepage_Page_Object
    {
        private IWebDriver driver = new ChromeDriver();
        By Email = By.CssSelector("input[placeholder='Email']");
        By InitialSignUp = By.XPath("//a[@href='#/register']");
        By Username = By.CssSelector("input[placeholder='Username']");
        By Password = By.CssSelector("input[placeholder='Password']");
        By SignUpClick = By.CssSelector("button[type='submit']");
        By CheckUserPostLogin = By.CssSelector("[ui-sref='app.profile.main({ username: $ctrl.currentUser.username })']");

        public Homepage_Page_Object(IWebDriver driver)
        {
            this.driver = driver;
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
            IWebElement Finalise = driver.FindElement(SignUpClick);
            Finalise.Click();
        }

        public void CheckUser()
        {
            IWebElement user = driver.FindElement(CheckUserPostLogin);
            bool isElementDisplayed = user.Displayed;
            Assert.True(isElementDisplayed);
            user.Click();
        }
    
    }   
}


    
