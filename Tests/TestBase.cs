using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Shop.VSK.ru.Tests
{
	class TestBase
	{
		protected IWebDriver driver;
		private readonly string Url = "https://shop.vsk.ru/";

		[SetUp]
		public void Start()
		{
			driver = new ChromeDriver();
			driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
			driver.Manage().Window.Maximize();

			driver.Url = Url;
		}

		[TearDown]
		public void Stop()
		{
			driver.Quit();
		}
	}
}
