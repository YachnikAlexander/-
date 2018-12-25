using AirlinesTestingApp.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;

namespace AirlinesTestingApp.Tests
{
    [TestClass]
    public class CheckSearchResultsAppeared
    {
        private SearchResultsPage searchResultsPage;

        [TestMethod]
        public void SearchTicketsToParisAndAssertResultsAppeared()
        {
            _1_OpenSearchPageResultsForParis();

            _2_AssertSearchResultsText();
        }

        private void _1_OpenSearchPageResultsForParis()
        {
            searchResultsPage = new SearchResultsPage();
            searchResultsPage.GoToSearchResultsForSpecifiedWord("Paris");
        }

        private void _2_AssertSearchResultsText()
        {
            var result = searchResultsPage.GetSearchResultsText();
            Assert.AreNotEqual("0", result.Substring(0, result.IndexOf("R")).Trim());
        }
    }
}
