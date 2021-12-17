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
            // Make sure timeout is set to zero seconds to skip waiting for element.
            CalculatorApp.Window.WrappedDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0);
        }

        [TestCleanup]
        public void TestCleanup()
        {
        }

        #region Navigation menu visibility test

        /// <summary>
        /// Test that the navigation menu is not open on application startup.
        /// </summary>
        [TestMethod]
        [Priority(0)]
        public void Menu_Not_Visible_On_Startup()
        {
            // Assert that navigation menu does not exist.
            Assert.ThrowsException<WebDriverException>(() => CalculatorApp.Window.FindElementByClassName("SplitViewPane"));
        }

        /// <summary>
        /// Test that the Standard navigation menu option is not visible on application startup.
        /// </summary>
        [TestMethod]
        [Priority(0)]
        public void Standard_Menu_Option_Not_Visible_On_Startup()
        {
            // Assert that the Standard navigation menu option is not visible.
            Assert.ThrowsException<WebDriverException>(() => CalculatorApp.Window.FindElementByAccessibilityId("Standard"));
        }

        /// <summary>
        /// Test that the Scientific navigation menu option is not visible on application startup.
        /// </summary>
        [TestMethod]
        [Priority(0)]
        public void Scientific_Menu_Option_Not_Visible_On_Startup()
        {
            // Assert that the Scientific navigation menu option is not visible.
            Assert.ThrowsException<WebDriverException>(() => CalculatorApp.Window.FindElementByAccessibilityId("Scientific"));
        }

        /// <summary>
        /// Test that the Programmer navigation menu option is not visible on application startup.
        /// </summary>
        [TestMethod]
        [Priority(0)]
        public void Programmer_Menu_Option_Not_Visible_On_Startup()
        {
            // Assert that the Programmer navigation menu option is not visible.
            Assert.ThrowsException<WebDriverException>(() => CalculatorApp.Window.FindElementByAccessibilityId("Programmer"));
        }

        /// <summary>
        /// Test that the Date navigation menu option is not visible on application startup.
        /// </summary>
        [TestMethod]
        [Priority(0)]
        public void Date_Menu_Option_Not_Visible_On_Startup()
        {
            // Assert that the Date navigation menu option is not visible.
            Assert.ThrowsException<WebDriverException>(() => CalculatorApp.Window.FindElementByAccessibilityId("Date"));
        }

        /// <summary>
        /// Test that the Currency navigation menu option is not visible on application startup.
        /// </summary>
        [TestMethod]
        [Priority(0)]
        public void Currency_Menu_Option_Not_Visible_On_Startup()
        {
            // Assert that the Currency navigation menu option is not visible.
            Assert.ThrowsException<WebDriverException>(() => CalculatorApp.Window.FindElementByAccessibilityId("Currency"));
        }

        /// <summary>
        /// Test that the Volume navigation menu option is not visible on application startup.
        /// </summary>
        [TestMethod]
        [Priority(0)]
        public void Volume_Menu_Option_Not_Visible_On_Startup()
        {
            // Assert that the Volume navigation menu option is not visible.
            Assert.ThrowsException<WebDriverException>(() => CalculatorApp.Window.FindElementByAccessibilityId("Volume"));
        }

        /// <summary>
        /// Test that the Length navigation menu option is not visible on application startup.
        /// </summary>
        [TestMethod]
        [Priority(0)]
        public void Length_Menu_Option_Not_Visible_On_Startup()
        {
            // Assert that the Length navigation menu option is not visible.
            Assert.ThrowsException<WebDriverException>(() => CalculatorApp.Window.FindElementByAccessibilityId("Length"));
        }

        /// <summary>
        /// Test that the Weight navigation menu option is not visible on application startup.
        /// </summary>
        [TestMethod]
        [Priority(0)]
        public void Weight_Menu_Option_Not_Visible_On_Startup()
        {
            // Assert that the Weight navigation menu option is not visible.
            Assert.ThrowsException<WebDriverException>(() => CalculatorApp.Window.FindElementByAccessibilityId("Weight"));
        }

        /// <summary>
        /// Test that the Temperature navigation menu option is not visible on application startup.
        /// </summary>
        [TestMethod]
        [Priority(0)]
        public void Temperature_Menu_Option_Not_Visible_On_Startup()
        {
            // Assert that the Temperature navigation menu option is not visible.
            Assert.ThrowsException<WebDriverException>(() => CalculatorApp.Window.FindElementByAccessibilityId("Temperature"));
        }

        /// <summary>
        /// Test that the Energy navigation menu option is not visible on application startup.
        /// </summary>
        [TestMethod]
        [Priority(0)]
        public void Energy_Menu_Option_Not_Visible_On_Startup()
        {
            // Assert that the Energy navigation menu option is not visible.
            Assert.ThrowsException<WebDriverException>(() => CalculatorApp.Window.FindElementByAccessibilityId("Energy"));
        }

        /// <summary>
        /// Test that the Area navigation menu option is not visible on application startup.
        /// </summary>
        [TestMethod]
        [Priority(0)]
        public void Area_Menu_Option_Not_Visible_On_Startup()
        {
            // Assert that the Area navigation menu option is not visible.
            Assert.ThrowsException<WebDriverException>(() => CalculatorApp.Window.FindElementByAccessibilityId("Area"));
        }

        /// <summary>
        /// Test that the Speed navigation menu option is not visible on application startup.
        /// </summary>
        [TestMethod]
        [Priority(0)]
        public void Speed_Menu_Option_Not_Visible_On_Startup()
        {
            // Assert that the Speed navigation menu option is not visible.
            Assert.ThrowsException<WebDriverException>(() => CalculatorApp.Window.FindElementByAccessibilityId("Speed"));
        }

        /// <summary>
        /// Test that the Time navigation menu option is not visible on application startup.
        /// </summary>
        [TestMethod]
        [Priority(0)]
        public void Time_Menu_Option_Not_Visible_On_Startup()
        {
            // Assert that the Time navigation menu option is not visible.
            Assert.ThrowsException<WebDriverException>(() => CalculatorApp.Window.FindElementByAccessibilityId("Time"));
        }

        #endregion
    }
}
