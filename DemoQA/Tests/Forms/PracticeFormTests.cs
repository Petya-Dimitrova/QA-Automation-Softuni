using DemoQA.Factories;
using DemoQA.Models;
using DemoQA.Pages.PracticeForm;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Tests.Forms
{
    [TestFixture]
    public class PracticeFormTests : BaseTest
    {
        private PracticeFormPage _practiceFormPage;
        private PracticeFormModel _user;

        [SetUp]
        public void Setup()
        {
            Initialize();
            Driver.Navigate().GoToUrl("http://demoqa.com/automation-practice-form");
            _practiceFormPage = new PracticeFormPage(Driver);
            _user = PracticeFormFactory.Create();
            
        }

        [Test]
        public void ThanksMessageDisplayed_When_FillFormWithValidData()
        { 
            _practiceFormPage.FillForm(_user);

            var actualMessage = _practiceFormPage.Popup.Message.Text;
            Assert.AreEqual("Thanks for submitting the form", actualMessage);
        }


        [Test]
        public void ErrorDisplayed_When_FillFormWithoutFirstName()
        {
            //Arange
            _user.FirstName = string.Empty;

            //Act
            _practiceFormPage.FillForm(_user);

            //Assert
            _practiceFormPage.AssertErrorBorderColor(_practiceFormPage.FirstName); 

        }


        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
