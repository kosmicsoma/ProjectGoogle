using Google.Bdd.PageObjects;
using Google.Bdd.SeleniumHelper;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Google.Bdd.StepDefinitions
{
    [Binding]
    public class SearchPageStep
    {
        private SearchPage searchPage = new SearchPage();

        [BeforeScenario]
        public void BeforeScenario()
        {
            BrowserPage.InstantiateDriver();
        }

        [Given(@"I am on Google search page")]
        public void GivenIAmOnGoogleSearchPage()
        {
            BrowserPage.GotoUrl("http://google.com");
        }

        [When(@"I enter ""(.*)"" in the search text box")]
        public void WhenIEnterInTheSearchTextBox(string searchText)
        {
            searchPage.DoSearch(searchText);
        }

        [When(@"click the Search Button")]
        public void WhenClickTheSearchButton()
        {
            searchPage.ClickOnSearchButton();
        }

        [Then(@"I should see (.*) links in th search page")]
        public void ThenIShouldSeeLinksInThSearchPage(int linkCount)
        {
            Assert.AreEqual(linkCount, searchPage.GetLinkCount());
        }

        [Then(@"I should see ""(.*)""th link text")]
        public void ThenIShouldSeeThLinkText(int linkIndex)
        {
            searchPage.DisplayLinkText(linkIndex);
        }

        [Then(@"I should not see (.*) links in th search page")]
        public void ThenIShouldNotSeeLinksInThSearchPage(int linkCount)
        {
            Assert.AreNotEqual(linkCount, searchPage.GetLinkCount());
        }

        [AfterScenario]
        public void AfterMethod()
        {
            BrowserPage.Close();
        }
    }
}

