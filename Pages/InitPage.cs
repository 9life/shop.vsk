using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;

namespace Shop.VSK.ru.Pages
{
	public class InitPage
	{
		protected IWebDriver driver;
		protected WebDriverWait wait;

		protected InitPage(IWebDriver _driver)
		{
			this.driver = _driver;
			wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

			PageFactory.InitElements(driver, this);
		}
	}
}
