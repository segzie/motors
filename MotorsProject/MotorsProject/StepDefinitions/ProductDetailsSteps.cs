using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using TechTalk.SpecFlow;
using System.Linq;

namespace MotorsProject.StepDefinitions
{
    [Binding]
    public sealed class ProductDetailsSteps
    {
        IWebDriver driver;
        IWebElement agreeButton;
        IWebElement postcodeField;
        IWebElement carMake;
        IWebElement carModel;
        IWebElement searchButton;
        IWebElement price;
        IList<IWebElement> result;

        [Given(@"I navigate to Motors homepage")]
        public void GivenINavigateToMotorsHomepage()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.motors.co.uk/");
            driver.Manage().Window.Maximize();

            agreeButton = driver.FindElement(By.ClassName("banner_continue--2NyXA"));
            agreeButton.Click();
        }

        [When(@"I enter postcode")]
        public void WhenIEnterPostcode()
        {
            postcodeField = driver.FindElement(By.Name("PostCode"));
            postcodeField.SendKeys("M3 1EY");
        }

        [When(@"I select my car make")]
        public void WhenISelectMyCarMake()
        {
            carMake = driver.FindElement(By.Id("Make"));
            SelectElement select = new SelectElement(carMake);
            select.SelectByText("Audi");
        }

        [When(@"I select my car model")]
        public void WhenISelectMyCarModel()
        {
            carModel = driver.FindElement(By.Id("Model"));
            SelectElement select = new SelectElement(carModel);
            select.SelectByText("Q7");
            
        }

        [When(@"i click on search button")]
        public void WhenIClickOnSearchButton()
        {            
            searchButton = driver.FindElement(By.ClassName("sp__btn-title"));
            searchButton.Click();
        }

        [When(@"I click on the first car from thwe result")]
        public void WhenIClickOnTheFirstCarFromThweResult()
        {
            result = driver.FindElements(By.CssSelector("image__photo"));
            result.ElementAt(0).Click();

        }

        [Then(@"the price of the car selected is displayed")]
        public void ThenThePriceOfTheCarSelectedIsDisplayed()
        {
            price = driver.FindElement(By.ClassName("vdp-header__full-price"));
            Assert.True(price.Displayed);

        }

    }
}
