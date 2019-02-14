using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelSelenium.Utils
{
    public class WebDriverFactory
    {
       // private static IWebDriver driver;
       

        private static string mainWindowHandle;
       


        /// <summary>
        /// The driver to be used for testing the application
        /// </summary>
       

        public static string MainWindowHandle
        {
            get
            {
                return mainWindowHandle;
            }
            set
            {
                mainWindowHandle = value;
            }
        }

        public static ITakesScreenshot Driver { get; set; }
    }
}
