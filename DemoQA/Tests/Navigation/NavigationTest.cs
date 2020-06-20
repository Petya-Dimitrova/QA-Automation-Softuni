using DemoQA.Pages.Navigation;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Tests.Navigation
{
    [TestFixture]
    public class NavigationTest :BaseTest
    {
        public NavigationPage _navigationPage;

        [SetUp]
        public void Setup()
        {
            Initialize();
            _navigationPage = new NavigationPage(Driver);
            _navigationPage.NavigateTo();
        }


        [Test]
        [TestCase("Sortable")]
        [TestCase("Selectable")]
        [TestCase("Resizable")]
        [TestCase("Droppable")]
        [TestCase("Dragabble")]
        public void InteractionSectionNameDisplayed_When_NavigationToInteractions(string sectionName)
        {
            _navigationPage.Navigation(sectionName);

            _navigationPage.AssertCorrectTitleSection(sectionName, _navigationPage.PageHeader);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }


}
