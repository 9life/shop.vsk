using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace Shop.VSK.ru
{
	public static class Helper
	{
		public static void WaitUntilElementIsClicalble(WebDriverWait wait, IWebElement element)
		{
			try
			{
				wait.Until(ExpectedConditions.ElementToBeClickable(element));
			}
			catch (NoSuchElementException)
			{
				Console.WriteLine("Элемент: '" + element + "' не был найден на странице.");
				throw;
			}
		}
		public static DateTime AddAnyDays(int countOfDays)
		{
			return DateTime.Today.AddDays(countOfDays);
		}
	}
}
