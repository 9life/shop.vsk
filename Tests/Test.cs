using NUnit.Framework;
using Shop.VSK.ru.Pages;

namespace Shop.VSK.ru.Tests
{
	class Test : TestBase
	{
		/*
			a.	Перейти на сайт https://shop.vsk.ru/
			b.	Перейти на вкладку «Путешествия»
			c.	Нажать кнопку «Купить полис»
			d.	Заполнить поля следующими данными:
			•	Страна или город = Египет
			•	Дата начала = Сегодня +5 дней
			•	Дата окончания = Сегодня +15 дней
			•	Нажать кнопку «Оформить полис»
		 */
		[TestCase("Египет", 5, 15)]
		[Test]
		public void Test1(string country, int countDaysForStartDate, int countDaysForEndDate)
		{
			HomePage homePage = new HomePage(driver);
			TravelPage travelPage = new TravelPage(driver);
			TravelCalculatorPage travelCalculatorPage = new TravelCalculatorPage(driver);

			homePage.WaitUntilLoadPage();
			homePage.ClickOnLinkTravel();
			travelPage.ClickOnBuyButton();
			travelCalculatorPage.InputValuesAndCheckoutPolicy(country, countDaysForStartDate, countDaysForEndDate);
		}
	}
}
