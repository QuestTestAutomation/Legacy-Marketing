using DellQA.Common.Enums;
using DellQA.Utils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelSelenium.BusinessObject
{
    public class ResistrationData
    {
        public static string db_env { get; set; }
        public static string ssod_availble { get; set; }
        public static string db_ProspectOrigin { get; set; }
        public static string db_leadfor { get; set; }
        public static string db_latitude { get; set; }
        public static string db_logitude { get; set; }
        public static string db_industry { get; set; }
        public static string db_subindustry { get; set; }
        
        
        public static string CutomerDataCheck(DataTable dt)
        {
           

            String FirstName = dt.Rows[0]["FirstName"].ToString();
            String LastName = dt.Rows[0]["LastName"].ToString();
            String Email = dt.Rows[0]["Email"].ToString();
            String Phone = dt.Rows[0]["Phone"].ToString();
            String Company = dt.Rows[0]["Company"].ToString();
            String Comments = dt.Rows[0]["Comments"].ToString();
            String LeadFor = dt.Rows[0]["LeadFor"].ToString();
            string LeadStatus = dt.Rows[0]["LeadStatus"].ToString();
            string ProspectOrigin = dt.Rows[0]["ProspectOrigin"].ToString();
            string Env = dt.Rows[0]["Env"].ToString();
            String CountryCode = dt.Rows[0]["CountryCode"].ToString();
            if (FirstName == Verify_Details.userfirstname)
            {
                if (LastName == Verify_Details.userlastname)
                {
                    if (Email == Verify_Details.useremail)
                    {
                        if (Phone == Verify_Details.userphone)
                        {
                        }
                        else
                        {
                            return "User phone isn't matched in database";
                        }
                    }
                    else
                    {
                        return "User email isn't matched in database";
                    }
                }
                else
                {
                    return "User Last name isn't matched in database";
                }
            }
            else
            {
                return "User First Name isn't matched in database";
            }

            if (Comments.Contains(db_latitude))
            {
                if (Comments.Contains(db_logitude))
                {
                    if (Comments.Contains(db_industry))
                    {
                        if (Comments.Contains(db_subindustry))
                        {

                        }
                        else
                        {
                            return "db_subindustry isn't matched in database";
                        }
                    }
                    else
                    {
                        return "db_industry isn't matched in database";
                    }
                }
                else
                {
                    return "db_logitude isn't matched in database";
                }
            }
            else
            {
                return "db_latitude isn't matched in database";
            }
            if (LeadStatus == "Processing Queue")
            {
                
            }
            else if (LeadStatus == "DQM_BATCH_CLEANSE")
            {

            }
            else
            {
                return "LeadStatus isn't matched in Database";
            }
            if (LeadFor == db_leadfor)
            {

            }
            else
            {
                return "db_latitude isn't matched in Database";
            }
            if (ProspectOrigin == db_ProspectOrigin)
            {
            }
            else
            {
                return "ProspectOrigin isn't matched in database";
            }

            if (Env == db_env)
            {
            }
            else
            {
                return "db_env isn't matched in database";
            }

            if (CountryCode == Verify_Details.usercountry)
            {

            }
            else
            {
                return "CountryCode isn't matched in database";
            }

            if (Company == Verify_Details.usercompany)
            {

            }
            else
            {
                return "Company isn't matched in database";
            }
            bool allPass = true;
            foreach (var item in DbFields.Fields)
            {
                Thread.Sleep(2000);
                if (dt.Rows[0][item.Key].ToString() != formValues[item.Key])
                {
                    allPass = false;
                    break;
                }
            }
            if (allPass)
            {

                return "Pass";
            }
            else
            {
                return "Dictionary value isn't matached in database";
            }
        }


        public static Dictionary<string, string> formValues = new Dictionary<string, string>();

        public static string PageVale(IWebDriver driver)
        {
            foreach (var item in DbFields.Fields)
            {
                formValues.Add(item.Key, driver.FindElement(By.Id(item.Value)).GetAttribute("Value"));
            }
            if (driver.FindElements(By.Id("DB_Latitude")).Count > 0)
            {
                var DB_Latitude = driver.FindElement(By.Id("DB_Latitude")).GetAttribute("Value");
                db_latitude = DB_Latitude;
            }
            else
            {
                return "db_latitude  isn't available";
            }
            if (driver.FindElements(By.Id("DB_Longitude")).Count > 0)
            {
                var DB_Longitude = driver.FindElement(By.Id("DB_Longitude")).GetAttribute("Value");
                db_logitude = DB_Longitude;
            }
            else
            {
                return "DB_longitude isn't available";
            }
            if (driver.FindElements(By.Id("DB_Industry")).Count > 0)
            {
                var DB_Industry = driver.FindElement(By.Id("DB_Industry")).GetAttribute("Value");
                db_industry = DB_Industry;
            }
            else
            {
                return "DB_Industry isn;t available";
            }
            if (driver.FindElements(By.Id("DB_SubIndustry")).Count > 0)
            {
                var DB_SubIndustry = driver.FindElement(By.Id("DB_SubIndustry")).GetAttribute("Value");
                db_subindustry = DB_SubIndustry;
            }
            else
            {
                return "DB_SubIndustry isn't available";
            }
            if (driver.Url.Contains("quest"))
            {
                db_leadfor = "Quest";
            }
            else if (driver.Url.Contains("oneidentity"))
            {
                db_leadfor = "Quest";
            }
            else
            {
                return "db_leadfor isn't available";
            }
            if (driver.Url.Contains("https://www.quest.com/"))           
            {
                db_ProspectOrigin = "quest-en-us";
            }
            else if (driver.Url.Contains("stage.quest.com")) 
            {
            db_ProspectOrigin = "quest-en-us";
            }
            else if (driver.Url.Contains("https://www.oneidentity.com/"))
            {
                db_ProspectOrigin = "oneidentity-en-us";
            }
            else
            {
                return "db_ProspectOrigin isn't available";
            }
            if (driver.Url.Contains("www.quest.com"))
            {
                db_env = "Live";
                return "Pass";
            }
            else if (driver.Url.Contains("stage.quest.com"))
            {
                
                db_env = "Live";
                return "Pass";
            }
            else if (driver.Url.Contains("wwww.oneidentity.com"))
            {
                
                db_env = "Live";
                return "Pass";
            }
            else
            {
                return "DB_ENV isn't available";
            }
        }
    }
}
