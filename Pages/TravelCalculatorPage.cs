using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;
using System;

namespace Shop.VSK.ru.Pages
{
	class TravelCalculatorPage : InitPage
	{
		public TravelCalculatorPage(IWebDriver driver) : base(driver) { }

		[FindsBy(How = How.Id, Using = "something")]
		private IWebElement CountryInput;
		
		[FindsBy(How = How.XPath, Using = "(//div[contains(@class,'travel-period')]//input[contains(@id,'mat-input') and contains(@class, 'value')])[1]")]
		private IWebElement StartDateInput;

		[FindsBy(How = How.XPath, Using = "(//div[contains(@class,'travel-period')]//input[contains(@id,'mat-input') and contains(@class, 'value')])[2]")]
		private IWebElement EndDateInput;

		[FindsBy(How = How.Id, Using = "next_step")]
		private IWebElement СheckoutButton;

		[FindsBy(How = How.ClassName, Using = "app-footer")]
		private IWebElement FooterContainer;

		public void InputValuesAndCheckoutPolicy(string country, int countDaysForStartDate, int countDaysForEndDate)
		{
			Console.WriteLine(DateTime.Today);
			SetCountry(country);

			SetDate(StartDateInput, Helper.AddAnyDays(countDaysForStartDate));
			SetDate(EndDateInput, Helper.AddAnyDays(countDaysForEndDate));

			Helper.WaitUntilElementIsClicalble(wait, СheckoutButton);

			MoveMouseToFooter();

			ClickOnCheckoutButton();
		}

		public void SetCountry(string country)
		{
			CountryInput.SendKeys(country);
			CountryInput.SendKeys(Keys.Enter);
		}

		public void SetDate(IWebElement element, DateTime date)
		{
			element.Clear();
			element.SendKeys(date.ToString());
		}

		public void ClickOnCheckoutButton()
		{
			СheckoutButton.Click();
		}

		public void MoveMouseToFooter()
		{
			Actions actions = new Actions(driver);
			actions.MoveToElement(FooterContainer).Perform();
		}
	}
}
