using CalculatorUITestFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;

namespace CalculatorUITests
{
    [TestClass]
    public class NavigationMenuTests
    {
        private static UnitConverterPage page = new UnitConverterPage();

        /// <summary>
        /// Initializes the WinAppDriver web driver session.
        /// </summary>
        /// <param name="context"></param>
        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            WinAppDriver.Instance.SetupCalculatorSession(context);

            // Check if not currently in currency converter.
            string header = CalculatorApp.GetCalculatorHeaderText();
            if (header != "Currency")
            {
                // Navigate to currency converter.
                page.EnsureCalculatorIsCurrencyMode();
                // Tear down any previous sessions and start a new one.
                WinAppDriver.Instance.TearDownCalculatorSession();
                WinAppDriver.Instance.SetupCalculatorSession(context);
            }
        }

        /// <summary>
        /// Closes the app and WinAppDriver web driver session.
        /// </summary>
        [ClassCleanup]
        public static void ClassCleanup()
        {
            // Tear down Calculator session.
            WinAppDriver.Instance.TearDownCalculatorSession();
        }

        [TestInitialize]
        public void TestInit()
        {
        }

        [TestCleanup]
        public void TestCleanup()
        {
        }

        #region Navigation menu visibility test

        /// <summary>
        /// Ensure that the navigation menu is not open on application startup.
        /// </summary>
        [TestMethod]
        [Priority(0)]
        public void NavigationMenuNotVisibleOnStartup()
        {
            // Set timeout to zero seconds to skip waiting for element.
            CalculatorApp.Window.WrappedDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0);
            // Assert that navigation menu does not exist.
            Assert.ThrowsException<WebDriverException>(() => CalculatorApp.Window.FindElementByClassName("SplitViewPane"));
        }
        #endregion
    }
}
