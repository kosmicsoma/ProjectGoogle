using Google.Bdd.SeleniumHelper;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;

namespace Google.Bdd.PageObjects
{
    public class SearchPage
    {
        By searchText = By.Id("lst-ib");
        By searchButton = By.Name("btnK");
        By searchLinks = By.XPath("//a/h3");

        public void DoSearch(String text)
        {
            BrowserPage.driver.FindElement(searchText).SendKeys(text);
        }

        public void ClickOnSearchButton()

        {
            BrowserPage.driver.FindElement(searchButton).Click();
        }

        public void DisplayLinkText(int linkIndex)
        {
            IList<IWebElement> totalLinks = BrowserPage.driver.FindElements(searchLinks);
            for (int i = 0; i < totalLinks.Count; i++)
            {
                if (i == linkIndex)
                {                    
                    Console.WriteLine(totalLinks[i].Text);
                    break;
                }
            }
        }

        public int GetLinkCount()
        {
             return BrowserPage.driver.FindElements(searchLinks).Count;            
        }
    }
}


