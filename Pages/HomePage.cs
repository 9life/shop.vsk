using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Shop.VSK.ru.Pages
{
	 class HomePage : InitPage
	{
		public HomePage(IWebDriver driver) : base(driver) { }

		[FindsBy(How = How.XPath, Using = "//a[contains(text(), 'Путешествия')]")]
		private IWebElement LinkTravel;
		
		public void WaitUntilLoadPage()
		{
			Helper.WaitUntilElementIsClicalble(wait, LinkTravel);
		}

		public TravelPage ClickOnLinkTravel()
		{
			LinkTravel.Click();
			return new TravelPage(driver);
		}
	}
}
