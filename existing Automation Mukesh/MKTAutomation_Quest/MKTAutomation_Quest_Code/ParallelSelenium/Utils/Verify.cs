using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System.Collections.ObjectModel;
using System.Collections;
using System.Net;
using System.Reflection;
using OpenQA.Selenium.Firefox;
using System.IO;
using System.Data;
using System.Diagnostics;
using System.Web;
using Microsoft.Office.Interop.Excel;
using OpenQA.Selenium.Remote;
using ParallelSelenium.Common;
using ParallelSelenium;
using OpenQA.Selenium.Chrome;
using DellQA.Common.Enums;
using ParallelSelenium;
using ParallelSelenium.Utils;

namespace DellQA.Utils
{

    class Verify_Details
    {
        public IWebDriver driver;
        ParallelSelenium.Common.FileHandler path = new ParallelSelenium.Common.FileHandler();
        ICollection<string> windowids = null;
        public static string liveurl { get; set; }
        public static string getdatetime { get; set; }
        public static string dbcompany { get; set; }
        public static string usercompany { get; set; }
        public static string usercountry { get; set; }
        public static string dbstate { get; set; }
        public static string userstate { get; set; }
        public static string useremail { get; set; }
        public static string userphone { get; set; }
        public static string usercity { get; set; }
        public static string pageText { get; set; }
        public static string userfirstname { get; set; }
        public static string userlastname { get; set; }
       
        public Object trigger(String script)
        {
            return ((IJavaScriptExecutor)driver).ExecuteScript(script);
        }
        public string Verify(IWebDriver driver, string pageData)
        {
            try
            {
                if (driver.PageSource.Contains(pageData))
                {
                    usercity = pageData;
                    return "Pass";
                }
                else
                {
                    return "Dat not found";
                }                
            }
            catch (System.Exception ex)
            {
                return ex.Message;
            }

        }
        public string Pageregresh(IWebDriver driver)
        {
            try
            {
                driver.Navigate().Refresh();

                if (driver.Title != null)
                {
                    return "pass";
                }
                else
                {
                    return "Page title is null";
                }
               
            }
            catch (System.Exception ex)
            {
                return ex.Message;
            }
        }
        public string navigate(IWebDriver driver, string pageData)
        {
            try
            {

                driver.Navigate().GoToUrl(pageData);
                
                if (driver.Title != null)
                {
                    return "pass";
                }
                else
                {
                    return "Page Title is null";
                }
            }
            catch (System.Exception ex)
            {
                return ex.Message;
            }
        }
        public string comparecurrenturl(IWebDriver driver, string pageData)
        {
            try
            {
                String currentURL = driver.Url;

                if (currentURL.Contains(pageData))
                {
                    return "pass";
                }
                else
                {
                    return "URL isn't matched";
                }
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        public string link(IWebDriver driver, string pageData)
        {
            try
            {
                WebDriverWait longwait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
                IWebElement element = longwait.Until(ExpectedConditions.ElementToBeClickable(By.LinkText(pageData)));

                if (element != null)
                {

                    element.Click();
                    return "pass";
                }
                else
                {
                    return "Link isn't clickable";
                }
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        public string id(IWebDriver driver, string pageData)
        {
            try
            {
                WebDriverWait longwait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
                IWebElement element = longwait.Until(ExpectedConditions.ElementToBeClickable(By.Id(pageData)));

                if (element != null)
                {

                    element.Click();
                    return "pass";
                }
                else
                {
                    return "ID isn't availble";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string css(IWebDriver driver, string pageData)
        {
            try
            {
                WebDriverWait longwait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
                IWebElement element = longwait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(pageData)));

                if (element != null)
                {

                    element.Click();
                    return "pass";
                }
                else
                {
                    return "CSS isn't clickable";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string sitecat(IWebDriver driver, string pageData)
        {
            try
            {
                Thread.Sleep(7000);
                if (driver.FindElement(By.XPath(pageData)) != null)
                {
                    return "pass";
                }
                else
                {
                    return "Sitecat isn't availble";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string sitecatall(IWebDriver driver, string pageData)
        {
            try
            {

                if (driver.FindElement(By.XPath(pageData)) != null)
                {
                    return "pass";
                }
                else
                {
                    return "Sitecat isn't availble";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string xpath(IWebDriver driver, string pageData)
        {
            try
            {
                WebDriverWait longwait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
                IWebElement element = longwait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(pageData)));

                if (element != null)
                {

                    element.Click();
                    return "pass";
                }
                else
                {
                    return "Xpath isn't clickable";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string name(IWebDriver driver, string pageData)
        {
            try
            {
                WebDriverWait longwait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
                IWebElement element = longwait.Until(ExpectedConditions.ElementToBeClickable(By.Name(pageData)));

                if (element != null)
                {

                    element.Click();
                    return "pass";
                }
                else
                {
                    return "Name isn't clickable";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string tagname(IWebDriver driver, string pageData)
        {
            try
            {
                WebDriverWait longwait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
                IWebElement element = longwait.Until(ExpectedConditions.ElementToBeClickable(By.TagName(pageData)));

                if (element != null)
                {

                    element.Click();
                    return "pass";
                }
                else
                {
                    return "Tagname isn't clickable";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string classname(IWebDriver driver, string pageData)
        {
            try
            {
                WebDriverWait longwait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
                IWebElement element = longwait.Until(ExpectedConditions.ElementToBeClickable(By.ClassName(pageData)));

                if (element != null)
                {

                    element.Click();
                    return "pass";
                }
                else
                {
                    return "Class name isn't clickable";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string verifycountry(IWebDriver driver, string pageData)
        {
            try
            {

                if (driver.PageSource.Contains("class=\"active\">" + pageData))
                {
                    dbcompany = pageData;
                    string[] words = dbcompany.Split(' ');
                    var firststr = words[0];
                    var hellostr = words[1];
                    char firstchar = firststr[0];
                    char Secondchar = hellostr[0];
                    char[] chars = { firstchar, Secondchar };
                    string s = new string(chars);
                    usercountry = s;
                    return "Pass";

                }
                else
                {
                    return "Country isn't availble";
                }
            }
            
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
        public string verifystate(IWebDriver driver, string pageData)
        {
            try
            {

                if (driver.PageSource.Contains(pageData))
                {
                    dbstate = pageData;
                    string[] words = dbstate.Split(' ');
                    var firststr = words[0];
                    char firstchar = firststr[0];
                    char[] chars = { firstchar };
                    string s = new string(chars);
                    userstate = s;
                    return "Pass";

                }
                else
                {
                    return "State data isn't availble";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
        public string typebylink(IWebDriver driver, string pageData, string testData)
        {
            try
            {
                WebDriverWait longwait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
                IWebElement element = longwait.Until(ExpectedConditions.ElementToBeClickable(By.LinkText(pageData)));

                if (element != null)
                {

                    element.SendKeys(testData);
                    return "pass";
                }
                else
                {
                    return "Link isn't available for type";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string typebyid(IWebDriver driver, string pageData, string testData)
        {
            try
            {
                WebDriverWait longwait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                IWebElement element = longwait.Until(ExpectedConditions.ElementToBeClickable(By.Id(pageData)));
                if (pageData.Contains("FirstName"))
                {
                    userfirstname = testData;
                }
                if (pageData.Contains("LastName"))
                {
                    userlastname = testData;
                }
                if (pageData.Contains("Email"))
                {
                    useremail = testData;
                }
                if (pageData.Contains("Phone"))
                {
                    userphone = testData;
                }
                if (element != null)
                {

                    element.SendKeys(testData);
                    return "pass";
                }
                else
                {
                    return "Id isn't clickable";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string typebycss(IWebDriver driver, string pageData, string testData)
        {
            try
            {
                WebDriverWait longwait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
                IWebElement element = longwait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(pageData)));

                if (element != null)
                {

                    element.SendKeys(testData);
                    return "pass";
                }
                else
                {
                    return "CSS isn't avilabel for type";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string typebyxpath(IWebDriver driver, string pageData, string testData)
        {
            try
            {
                WebDriverWait longwait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
                IWebElement element = longwait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(pageData)));

                if (element != null)
                {

                    element.SendKeys(testData);
                    return "pass";
                }
                else
                {
                    return "Xpath isn't available";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string typebyname(IWebDriver driver, string pageData, string testData)
        {
            try
            {
                WebDriverWait longwait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
                IWebElement element = longwait.Until(ExpectedConditions.ElementToBeClickable(By.Name(pageData)));

                if (element != null)
                {

                    element.SendKeys(testData);
                    return "pass";
                }
                else
                {
                    return "Name isn't availble for type";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string typebyclassname(IWebDriver driver, string pageData, string testData)
        {
            try
            {
                WebDriverWait longwait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
                IWebElement element = longwait.Until(ExpectedConditions.ElementToBeClickable(By.ClassName(pageData)));

                if (element != null)
                {

                    element.SendKeys(testData);
                    return "pass";
                }
                else
                {
                    return "Class name isn't available for type";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string clickandtypebyid(IWebDriver driver, string pageData, string testData)
        {
            try
            {
                WebDriverWait longwait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
                IWebElement element = longwait.Until(ExpectedConditions.ElementToBeClickable(By.Id(pageData)));

                if (element != null)
                {
                    element.Click();
                    element.SendKeys(testData);
                    return "pass";
                }
                else
                {
                    return "ID isn't availble for type and clic";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string switch_to(IWebDriver driver, string pageData)
        {
            try
            {
                windowids = driver.WindowHandles;
                for (int i = 0; i < windowids.Count; i = i + 1)
                {
                    String hwnd = windowids.ElementAt(i);
                    driver = driver.SwitchTo().Window(hwnd);
                    string currentUrl = driver.Url;
                    if (currentUrl.ToUpper().Contains(pageData.ToUpper()))
                    {
                        break;

                    }

                }
                return "Pass";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
        public string statuscode(IWebDriver driver, string pageData)
        {
            try
            {
                string currentUrl = driver.Url;
                HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(currentUrl);
                HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
                if (myHttpWebResponse.StatusCode == HttpStatusCode.OK)

                    myHttpWebResponse.Close();
                return "Pass";

            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
        public string iframe(IWebDriver driver, string pageData, string testData)
        {
            try
            {
                WebDriverWait longwait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
                IWebElement element = longwait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(pageData)));
                if (element != null)
                {
                    element.Click();
                    element.SendKeys(testData);
                    driver.SwitchTo().DefaultContent();
                    return "pass";
                }
                else
                {
                    return "Iframe isn't availble";
                }
            }

            catch (Exception ex)
            {
                return ex.Message;
            }

        }
        public string clearcookies(IWebDriver driver, string pageData)
        {
            try
            {
                driver.Manage().Cookies.DeleteAllCookies();
                driver.Navigate().Refresh();
                driver.Manage().Cookies.DeleteAllCookies();
                driver.Navigate().Refresh();
                return "pass";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string partiallink(IWebDriver driver, string pageData)
        {
            try
            {
                WebDriverWait longwait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
                IWebElement element = longwait.Until(ExpectedConditions.ElementToBeClickable(By.PartialLinkText(pageData)));

                if (element != null)
                {

                    element.Click();
                    return "pass";
                }
                else
                {
                    return "Partial link isn't available for click";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string closecurrenttab(IWebDriver driver, string pageData)
        {
            try
            {
                driver.Close();
                return "pass";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string curwindhandle(IWebDriver driver, string pageData)
        {
            try
            {
                List<string> handles = driver.WindowHandles.ToList<string>();
                Thread.Sleep(1000);
                driver.SwitchTo().Window(handles.Last());
                return "pass";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string getcurrenturl(IWebDriver driver, string pageData)
        {
            try
            {
                liveurl = driver.Url;
                return "pass";
            }

            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string gettext(IWebDriver driver, string pageData)
        {
            try
            {
                Thread.Sleep(2000);
                pageText = driver.FindElement(By.Id(pageData)).Text;
                return "pass";

            }
            catch (System.Exception)
            {
                return "fail";
            }
        }
        public string pastetext(IWebDriver driver, string pageData)
        {
            try
            {
                WebDriverWait longwait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
                IWebElement element = longwait.Until(ExpectedConditions.ElementToBeClickable(By.Id(pageData)));
                if (element != null)
                {
                    element.SendKeys(pageText);
                    return "pass";
                }
                else
                {
                    return "PAste text isn't available";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string verifyemail_gurlla(IWebDriver driver, string pageData)
        {
            try
            {

                if (driver.PageSource.Contains(pageText))
                {
                    Thread.Sleep(1000);
                    return "Pass";
                }
                else
                {
                    return "Gurrilla mail isn't available";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string searchbymail(IWebDriver driver, string pageData)
        {
            try
            {
                WebDriverWait longwait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                IWebElement element = longwait.Until(ExpectedConditions.ElementToBeClickable(By.Id(pageData)));

                if (element != null)
                {
                    element.Clear();
                    element.SendKeys(pageText);
                    Thread.Sleep(1000);
                    return "pass";
                }
                else
                {
                    return "search by email isn't working";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string selectbytext(IWebDriver driver, string pageData, string testData)
        {
            try
            {
                WebDriverWait longwait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
                IWebElement element = longwait.Until(ExpectedConditions.ElementToBeClickable(By.Id(pageData)));
                SelectElement selectElement = new SelectElement(element);
                if (element != null)
                {
                    selectElement.SelectByText(testData);
                    return "pass";
                }
                else
                {
                    return "Select by text isn't working";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string selectbyvalue(IWebDriver driver, string pageData, string testData)
        {
            try
            {
                WebDriverWait longwait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
                IWebElement element = longwait.Until(ExpectedConditions.ElementToBeClickable(By.Id(pageData)));
                SelectElement selectElement = new SelectElement(element);
                if (element != null)
                {
                    selectElement.SelectByValue(testData);
                    return "pass";
                }
                else
                {
                    return "Select by value isn't working";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string selectautofill(IWebDriver driver, string pageData, string testData)
        {
            try
            {
                WebDriverWait longwait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
                IWebElement element = longwait.Until(ExpectedConditions.ElementToBeClickable(By.Id(pageData)));
                if (pageData.Contains("Company"))
                {
                    usercompany = testData;
                }
                if (element != null)
                {

                    element.Clear();
                    element.SendKeys(testData);
                    Thread.Sleep(2000);
                    element.SendKeys(Keys.Down);
                    Thread.Sleep(2000);
                    element.SendKeys(Keys.Enter);
                    Thread.Sleep(2000);
                    return "pass";
                }
                else
                {
                    return "Select by autofill isn't working";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string datetime(IWebDriver driver, string pageData)
        {
            try
            {
                WebDriverWait longwait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
                IWebElement element = longwait.Until(ExpectedConditions.ElementToBeClickable(By.Id(pageData)));
                if (element != null)
                {
                    element.Clear();
                    DateTime now = DateTime.Now;
                    string date = now.ToString();
                    date = date.Replace(":", "-");
                    date = date.Replace("/", "-");
                    date = date.Replace(" ", "-");
                    element.SendKeys(date);
                    getdatetime = date;
                    return "pass";
                }
                else
                {
                    return "fail";
                }
            }
             catch (System.Exception)
            {
                return "fail";
            }
        }
        public string locwhitepaper_dtime(IWebDriver driver, string pageData)
        {
            try
            {
                WebDriverWait longwait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
                IWebElement element = longwait.Until(ExpectedConditions.ElementToBeClickable(By.Id(pageData)));
                if (element != null)
                {

                    element.Clear();
                    DateTime now = DateTime.Now;
                    string date = now.ToString();
                    date = date.Replace(":", "-");
                    date = date.Replace("/", "-");
                    date = date.Replace(" ", "-");
                    element.SendKeys("QaTeam whitepaper Registration Test" + date);
                    getdatetime = date;
                    return "pass";
                }
                else
                {
                    return "White paper isn't working";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string enamewhitepaper_dtime(IWebDriver driver, string pageData)
        {
            try
            {
                WebDriverWait longwait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
                IWebElement element = longwait.Until(ExpectedConditions.ElementToBeClickable(By.Id(pageData)));
                if (element != null)
                {

                    element.Clear();
                    DateTime now = DateTime.Now;
                    string date = now.ToString();
                    date = date.Replace(":", "-");
                    date = date.Replace("/", "-");
                    date = date.Replace(" ", "-");
                    element.SendKeys("QaTeam whitepaper Registration Test" + date);
                    getdatetime = date;
                    return "pass";
                }
                else
                {
                    return "fail";
                }
          }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string loctechtrief_dtime(IWebDriver driver, string pageData)
        {
            try
            {
                WebDriverWait longwait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
                IWebElement element = longwait.Until(ExpectedConditions.ElementToBeClickable(By.Id(pageData)));
                if (element != null)
                {

                    element.Clear();
                    DateTime now = DateTime.Now;
                    string date = now.ToString();
                    date = date.Replace(":", "-");
                    date = date.Replace("/", "-");
                    date = date.Replace(" ", "-");
                    element.SendKeys("QaTeam TechBrief Registration Test" + date);
                    getdatetime = date;
                    return "pass";
                }
                else
                {
                    return "Local techbrief date time isn't working";
                }
           }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string enametechbrief_dtime(IWebDriver driver, string pageData)
        {
            try
            {
                WebDriverWait longwait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
                IWebElement element = longwait.Until(ExpectedConditions.ElementToBeClickable(By.Id(pageData)));
                if (element != null)
                {

                    element.Clear();
                    DateTime now = DateTime.Now;
                    string date = now.ToString();
                    date = date.Replace(":", "-");
                    date = date.Replace("/", "-");
                    date = date.Replace(" ", "-");
                    element.SendKeys("TechBrief Registration Test" + date);
                    getdatetime = date;
                    return "pass";
                }
                else
                {
                    return "English Name techbrief isn;t working";
                }

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string locinfographic_dtime(IWebDriver driver, string pageData)
        {
            try
            {
                WebDriverWait longwait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
                IWebElement element = longwait.Until(ExpectedConditions.ElementToBeClickable(By.Id(pageData)));
                if (element != null)
                {

                    element.Clear();
                    DateTime now = DateTime.Now;
                    string date = now.ToString();
                    date = date.Replace(":", "-");
                    date = date.Replace("/", "-");
                    date = date.Replace(" ", "-");
                    element.SendKeys("QaTeam Infographic Registration Test" + date);
                    getdatetime = date;
                    return "pass";
                }
                else
                {
                    return "local infographic isn't working";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string enameinfographic_dtime(IWebDriver driver, string pageData)
        {
            try
            {
                WebDriverWait longwait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
                IWebElement element = longwait.Until(ExpectedConditions.ElementToBeClickable(By.Id(pageData)));
                if (element != null)
                {

                    element.Clear();
                    DateTime now = DateTime.Now;
                    string date = now.ToString();
                    date = date.Replace(":", "-");
                    date = date.Replace("/", "-");
                    date = date.Replace(" ", "-");
                    element.SendKeys("Infographic Registration Test" + date); ;
                    getdatetime = date;
                    return "pass";
                }
                else
                {
                    return "fail";
                }
          }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string loccasestudy_dtime(IWebDriver driver, string pageData)
        {
            try
            {
                WebDriverWait longwait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
                IWebElement element = longwait.Until(ExpectedConditions.ElementToBeClickable(By.Id(pageData)));
                if (element != null)
                {
                    element.Clear();
                    DateTime now = DateTime.Now;
                    string date = now.ToString();
                    date = date.Replace(":", "-");
                    date = date.Replace("/", "-");
                    date = date.Replace(" ", "-");
                    element.SendKeys("QaTeam casestudy Registration Test" + date);
                    getdatetime = date;
                    return "pass";
                }
                else
                {
                    return "Local case study date time";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string enamecasestudy_dtime(IWebDriver driver, string pageData)
        {
            try
            {
                WebDriverWait longwait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
                IWebElement element = longwait.Until(ExpectedConditions.ElementToBeClickable(By.Id(pageData)));
                if (element != null)
                {

                    element.Clear();
                    DateTime now = DateTime.Now;
                    string date = now.ToString();
                    date = date.Replace(":", "-");
                    date = date.Replace("/", "-");
                    date = date.Replace(" ", "-");
                    element.SendKeys("QaTeam casestudy Registration Test" + date);
                    getdatetime = date;
                    return "pass";
                }
                else
                {
                    return "English name case study isn't working";
                }
          }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string locebook_dtime(IWebDriver driver, string pageData)
        {
            try
            {
                WebDriverWait longwait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
                IWebElement element = longwait.Until(ExpectedConditions.ElementToBeClickable(By.Id(pageData)));
                if (element != null)
                {

                    element.Clear();
                    DateTime now = DateTime.Now;
                    string date = now.ToString();
                    date = date.Replace(":", "-");
                    date = date.Replace("/", "-");
                    date = date.Replace(" ", "-");
                    element.SendKeys("QaTeam ebook Registration Test" + date);
                    getdatetime = date;
                    return "pass";
                }
                else
                {
                    return "local ebook isn't working";
                }

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string enameebook_dtime(IWebDriver driver, string pageData)
        {
            try
            {
                WebDriverWait longwait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
                IWebElement element = longwait.Until(ExpectedConditions.ElementToBeClickable(By.Id(pageData)));
                if (element != null)
                {

                    element.Clear();
                    DateTime now = DateTime.Now;
                    string date = now.ToString();
                    date = date.Replace(":", "-");
                    date = date.Replace("/", "-");
                    date = date.Replace(" ", "-");
                    element.SendKeys("ebook Registration Test" + date);
                    getdatetime = date;
                    return "pass";
                }
                else
                {
                    return "English ebook isn't working";
                }

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string locdatasheet_dtime(IWebDriver driver, string pageData)
        {
            try
            {
                WebDriverWait longwait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
                IWebElement element = longwait.Until(ExpectedConditions.ElementToBeClickable(By.Id(pageData)));
                if (element != null)
                {

                    element.Clear();
                    DateTime now = DateTime.Now;
                    string date = now.ToString();
                    date = date.Replace(":", "-");
                    date = date.Replace("/", "-");
                    date = date.Replace(" ", "-");
                    element.SendKeys("QaTeam ebook Registration Test" + date);
                    getdatetime = date;
                    return "pass";
                }
                else
                {
                    return "Local datesheet isn't working";
                }

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string enamedatasheet_dtime(IWebDriver driver, string pageData)
        {
            try
            {
                WebDriverWait longwait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
                IWebElement element = longwait.Until(ExpectedConditions.ElementToBeClickable(By.Id(pageData)));
                if (element != null)
                {

                    element.Clear();
                    DateTime now = DateTime.Now;
                    string date = now.ToString();
                    date = date.Replace(":", "-");
                    date = date.Replace("/", "-");
                    date = date.Replace(" ", "-");
                    element.SendKeys("ebook Registration Test" + date);
                    getdatetime = date;
                    return "pass";
                }
                else
                {
                    return "English datasheet isn't working";
                }

            }
            catch (System.Exception)
            {
                return "fail";
            }
        }
        public string getdatetimenew(IWebDriver driver, string pageData)
        {
            try
            {
                WebDriverWait longwait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
                IWebElement element = longwait.Until(ExpectedConditions.ElementToBeClickable(By.Id(pageData)));
                if (element != null)
                {

                    element.SendKeys(getdatetime);
                    return "pass";
                }
                else
                {
                    return "fail";
                }
            }
            catch (System.Exception)
            {
                return "fail";
            }
        }
        public string switchto(IWebDriver driver, string pageData)
        {
            try
            {
                string existingWindowHandle = driver.CurrentWindowHandle;
                string popupHandle = string.Empty;
                ReadOnlyCollection<string> windowHandles = driver.WindowHandles;

                foreach (string handle in windowHandles)
                {
                    if (handle != existingWindowHandle)
                    {
                        popupHandle = handle; break;
                    }
                }

                //switch to new window 
                driver.SwitchTo().Window(popupHandle);
                return "Pass";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string silverlight(IWebDriver driver, string pageData)
        {
            try
            {
                System.Diagnostics.Process bitsadmin_process = new System.Diagnostics.Process();
                bitsadmin_process.StartInfo = new System.Diagnostics.ProcessStartInfo("bitsadmin.exe", "move" + "https://www.quest.com//filedownload.exe" + " " + "C:\\Users\\Administrator\\Desktop\\filedownload.exe");
                bitsadmin_process.Start();
                bitsadmin_process.WaitForExit();
                bitsadmin_process = null;
                Thread.Sleep(13000);
                Process.Start(path.GetRelativePath() + "Do_Not_Touch\\silverlighttab.exe");
                Thread.Sleep(10000);

                return "Pass";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string fileupload(IWebDriver driver, string pageData)
        {
            try
            {
                OpenQA.Selenium.Interactions.Actions actions = new OpenQA.Selenium.Interactions.Actions(driver);
                actions.MoveToElement(driver.FindElement(By.XPath("//div[@class='k-button k-upload-button']")));
                actions.Click();
                actions.Build().Perform();
                Thread.Sleep(24000);
                return "Pass";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string alertclose(IWebDriver driver, string pageData)
        {
            try
            {
                Thread.Sleep(2000);
                driver.SwitchTo().Alert().Accept();
                return "pass";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string digievent(IWebDriver driver, string pageData)
        {
            try
            {
                IJavaScriptExecutor js = driver as IJavaScriptExecutor;
                js.ExecuteScript("void(window.open('','dp_debugger','width=600,height=600, location=0,menubar=0,status=1,toolbar=0,resizable=1,scrollbars=1'));");
                var popupwinhl = driver.WindowHandles;
                driver.SwitchTo().Window(popupwinhl[1]);

                js.ExecuteScript("void(document.write(\"<script language='JavaScript' id=dbg src='https://www.adobetag.com/d1/digitalpulsedebugger/live/DPD.js'></" + "script>\"))");
                if (driver.PageSource.Contains(pageData))
                {

                    Thread.Sleep(1000);
                    driver.Close();
                    driver.SwitchTo().Window(popupwinhl[0]);
                    return "pass";
                }
                else
                {
                    Thread.Sleep(1000);
                    driver.Close();
                    driver.SwitchTo().Window(popupwinhl[0]);
                    return "fail";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string gatrackingid(IWebDriver driver, string pageData)
        {
            try
            {
                List<LogEntry> logs = driver.Manage().Logs.GetLog(LogType.Browser).ToList();
                foreach (var value in logs)
                {
                    if (value.ToString().Contains(pageData))
                    {
                        return "pass";
                    }
                }
                return "GA locater isn't found";
            }
            catch (Exception ex)
            {
                string x = ex.ToString();
                return "fail";
            }
        }
        public string pagename(IWebDriver driver, string pageData)
        {
            try
            {
                Thread.Sleep(1000);
                if (driver.FindElement(By.XPath(pageData)) != null)
                {
                    return "pass";
                }
                else
                {
                    return "Pagename isn't available";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

    }
}
