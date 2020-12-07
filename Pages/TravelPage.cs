using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace Shop.VSK.ru.Pages
{
	class TravelPage : InitPage
	{
		public TravelPage(IWebDriver driver) : base(driver) { }

		[FindsBy(How = How.Id, Using = "travel_banner_button_buy")]
		private IWebElement BuyButton;

		public TravelCalculatorPage ClickOnBuyButton()
		{
			BuyButton.Click();
			return new TravelCalculatorPage(driver);
		}
	}
}
