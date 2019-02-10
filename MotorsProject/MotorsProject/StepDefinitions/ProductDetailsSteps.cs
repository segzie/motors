using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MotorsProject.StepDefinitions
{
    [Binding]
    public sealed class ProductDetailsSteps
    {
        IWebDriver driver;
        IWebElement agreeButton;
        IWebElement postcodeField;
        IWebElement carMake;

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
            postcodeField.SendKeys("M8 8YG");
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
            
        }

        [When(@"i click on search button")]
        public void WhenIClickOnSearchButton()
        {
            
        }

        [When(@"I click on the first car from thwe result")]
        public void WhenIClickOnTheFirstCarFromThweResult()
        {
            
        }

        [Then(@"the price of the car selected is displayed")]
        public void ThenThePriceOfTheCarSelectedIsDisplayed()
        {
            
        }

    }
}
