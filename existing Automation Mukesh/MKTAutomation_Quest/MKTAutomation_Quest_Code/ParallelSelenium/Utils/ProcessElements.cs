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
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Interactions.Internal;
using ParallelSelenium.Common;
using ParallelSelenium;
using OpenQA.Selenium.Chrome;
using DellQA.Common.Enums;
using DellQA.Utils;
using ParallelSelenium.Utils;
using ParallelSelenium.BusinessObject;


namespace ParallelSelenium.Utils
{
    class ProcessElements
    {
        public IWebDriver driver;
        ParallelSelenium.Common.FileHandler path = new ParallelSelenium.Common.FileHandler();

        public void trigger(String script, IWebElement element)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript(script, element);
        }
        public Object trigger(String script)
        {
            return ((IJavaScriptExecutor)driver).ExecuteScript(script);
        }


        public ProcessElements(IWebDriver driver)
        {
            this.driver = driver;
        }

        public string ProcessRow(string firstcol, string secondcol, string thirdcol, string fourthcol, string fifthcol)
        {
            string command = firstcol;
            string objectId = secondcol.ToLower();
            string pageData = thirdcol;
            string testData = fourthcol;
            Verify_Details _Process = new Verify_Details();
            switch (firstcol.ToLower())
            {
                #region navigate
                case Commands.Navigate:
                    {
                        var process = _Process.navigate(driver, pageData);
                        return process;
                    }
                #endregion
                #region Verify
                case Commands.Verify:
                    {
                        try
                        {
                            switch (objectId)
                            {
                                case ObjectType.VERIFYBYTEXT:
                                    {
                                        var process = _Process.Verify(driver, pageData);
                                        return process;
                                    }
                                case ObjectType.VERIFYBYFIELD:
                                    {
                                        var textForVerification = VerifyFields.Fields[pageData];
                                        var process = _Process.Verify(driver, textForVerification);
                                        return process;
                                    }
                                case ObjectType.VERYIFYCOUNTRY:
                                    {
                                        var process = _Process.verifycountry(driver, pageData);
                                        return process;
                                    }
                                case ObjectType.VERYIFYSTATE:
                                    {
                                        var process = _Process.verifystate(driver, pageData);
                                        return process;
                                    }
                                case ObjectType.EVENTS:
                                    {
                                        var process = _Process.sitecat(driver, pageData);
                                        return process;
                                    }
                                case ObjectType.PAGENAME:
                                case ObjectType.SERVER:
                                case ObjectType.CAMPAIGN:
                                case ObjectType.PROP1:
                                case ObjectType.EVAR1:
                                case ObjectType.LIST1:
                                case ObjectType.PROP2:
                                case ObjectType.EVAR2:
                                case ObjectType.LIST2:
                                case ObjectType.PROP3:
                                case ObjectType.EVAR3:
                                case ObjectType.LIST3:
                                case ObjectType.EVAR8:
                                case ObjectType.PROP8:
                                case ObjectType.PROP9:
                                case ObjectType.EVAR12:
                                case ObjectType.PROP16:
                                case ObjectType.EVAR16:
                                case ObjectType.PROP20:
                                case ObjectType.PROP26:
                                case ObjectType.EVAR26:
                                case ObjectType.EVAR33:
                                case ObjectType.EVAR34:
                                    {
                                        var process = _Process.sitecatall(driver, pageData);
                                        return process;
                                    }
                            }
                        }
                        catch (System.Exception)
                        {
                            return "fail";
                        }
                        return "fail";
                    }
                #endregion
                #region pagerefresh
                case Commands.pagerefresh:
                    {
                        var process = _Process.Pageregresh(driver);
                        return process;
                    }
                #endregion
                #region compareurl
                case Commands.COMPAREURL:
                    {
                        var process = _Process.comparecurrenturl(driver, pageData);
                        return process;
                    }
                #endregion
                #region Click
                case Commands.CLICK:
                    {
                        switch (objectId)
                        {
                            case ObjectType.LINK:
                                {
                                    var process = _Process.link(driver, pageData);
                                    return process;
                                }
                            case ObjectType.ID:
                                {
                                    var process = _Process.id(driver, pageData);
                                    return process;
                                }
                            case ObjectType.CSS:
                                {
                                    var process = _Process.css(driver, pageData);
                                    return process;
                                }

                            case ObjectType.XPATH:
                                {
                                    var process = _Process.xpath(driver, pageData);
                                    return process;
                                }
                            case ObjectType.NAME:
                                {
                                    var process = _Process.name(driver, pageData);
                                    return process;
                                }
                            case ObjectType.TAGNAME:
                                {
                                    var process = _Process.tagname(driver, pageData);
                                    return process;
                                }
                            case ObjectType.CLASSNAME:
                                {
                                    var process = _Process.classname(driver, pageData);
                                    return process;
                                }
                        }
                        return "fail";
                    }
                #endregion
                #region db_check
                case Commands.DB_CHECK:
                    {
                        try
                        {
                            Database_testing db = new Database_testing();
                            System.Data.DataTable dt = db.connect();
                            return ResistrationData.CutomerDataCheck(dt);

                        }
                        catch (System.Exception ex)
                        {
                            return ex.Message;

                        }

                    }


                #endregion
                #region Type
                case Commands.TYPE:
                    {
                        switch (objectId)
                        {
                            case ObjectType.LINK:
                                {
                                    var process = _Process.typebylink(driver, pageData, testData);
                                    return process;
                                }
                            case ObjectType.ID:
                                {
                                    var process = _Process.typebyid(driver, pageData, testData);
                                    return process;
                                }
                            case ObjectType.CSS:
                                {
                                    var process = _Process.typebycss(driver, pageData, testData);
                                    return process;
                                }
                            case ObjectType.XPATH:
                                {
                                    var process = _Process.typebyxpath(driver, pageData, testData);
                                    return process;
                                }
                            case ObjectType.NAME:
                                {
                                    var process = _Process.typebyname(driver, pageData, testData);
                                    return process;
                                }
                            case ObjectType.CLASSNAME:
                                {
                                    var process = _Process.typebyclassname(driver, pageData, testData);
                                    return process;
                                }
                        }

                        return "fail";
                    }

                #endregion
                #region CLICKANDTYPEBYID
                case Commands.CLICKANDTYPEBYID:
                    {
                        var process = _Process.clickandtypebyid(driver, pageData, testData);
                        return process;
                    }
                #endregion
                #region switch_To
                case Commands.SWITCH_TO:
                    {
                        var process = _Process.switch_to(driver, pageData);
                        return process;
                    }
                #endregion
                #region wait until
                case "wait until":
                    {
                        Thread.Sleep(Convert.ToInt32(thirdcol));
                        return "pass";
                    }
                #endregion
                #region newtab
                case Commands.NEWTAB:
                    {
                        var process = newtab(driver, thirdcol);
                        return process;
                    }
                #endregion
                #region statuscode
                case Commands.STATUSCODE:
                    {
                        var process = _Process.statuscode(driver, pageData);
                        return process;
                    }
                #endregion
                #region iframe
                case Commands.IFRAME:
                    {
                        var process = _Process.iframe(driver, pageData, testData);
                        return process;
                    }
                #endregion
                #region partiallink
                case Commands.PARTIALLINK:
                    {
                        var process = _Process.partiallink(driver, pageData);
                        return process;
                    }
                #endregion
                #region get_dbvalues
                case "get_dbvalues":
                    {
                        try
                        {
                            return ResistrationData.PageVale(driver);

                        }
                        catch (System.Exception)
                        {
                            return "fail";
                        }
                    }
                #endregion
                #region clearcookies
                case Commands.CLEARCOOKIES:
                    {
                        var process = _Process.clearcookies(driver, pageData);
                        return process;
                    }
                #endregion
                #region closecurrenttab
                case Commands.CLOSECURRENTTAB:
                    {
                        var process = _Process.closecurrenttab(driver, pageData);
                        return process;
                    }
                #endregion
                #region curwindhandle
                case Commands.CURWINDHANDLE:
                    {
                        var process = _Process.curwindhandle(driver, pageData);
                        return process;
                    }
                #endregion
                #region gettext
                case Commands.GETTEXT:
                    {
                        var process = _Process.gettext(driver, pageData);
                        return process;
                    }
                #endregion
                #region pastetext
                case Commands.PASTETEXT:
                    {
                        var process = _Process.pastetext(driver, pageData);
                        return process;
                    }
                #endregion
                #region verifyemail_gurlla
                case Commands.VERIFYEMAIL_GURLLA:
                    {
                        var process = _Process.verifyemail_gurlla(driver, pageData);
                        return process;
                    }
                #endregion
                #region searchbymail
                case Commands.SEARCHBYMAIL:
                    {
                        var process = _Process.searchbymail(driver, pageData);
                        return process;
                    }
                #endregion
                #region selectbytext
                case Commands.SELECTBYTEXT:
                    {
                        var process = _Process.selectbytext(driver, pageData, testData);
                        return process;
                    }
                #endregion
                #region selectbyvalue
                case Commands.SELECTBYVALUE:
                    {
                        var process = _Process.selectbyvalue(driver, pageData, testData);
                        return process;
                    }
                #endregion
                #region selectautofill
                case Commands.SELECTAUTOFILL:
                    {
                        var process = _Process.selectautofill(driver, pageData, testData);
                        return process;
                    }
                #endregion
                #region datetime
                case Commands.DATETIME:
                    {
                        switch (objectId)
                        {
                            case ObjectType.DATETIME:
                                {
                                    var process = _Process.datetime(driver, pageData);
                                    return process;
                                }
                            case ObjectType.LOCWHITEPAPER_DTIME:
                                {
                                    var process = _Process.locwhitepaper_dtime(driver, pageData);
                                    return process;
                                }
                            case ObjectType.ENAMEWHITEPAPER_DTIME:
                                {
                                    var process = _Process.enamewhitepaper_dtime(driver, pageData);
                                    return process;
                                }
                            case ObjectType.LOCTECHRIEF_DTIME:
                                {
                                    var process = _Process.loctechtrief_dtime(driver, pageData);
                                    return process;
                                }
                            case ObjectType.ENAMETECHBRIEF_DTIME:
                                {
                                    var process = _Process.enametechbrief_dtime(driver, pageData);
                                    return process;
                                }
                            case ObjectType.LOCINFOGRAPHIC_DTIME:
                                {
                                    var process = _Process.locinfographic_dtime(driver, pageData);
                                    return process;
                                }
                            case ObjectType.ENAMEINFOGRAPHIC_DTIME:
                                {
                                    var process = _Process.enameinfographic_dtime(driver, pageData);
                                    return process;
                                }
                            case ObjectType.LOCCASESTUDY_DTIME:
                                {
                                    var process = _Process.loccasestudy_dtime(driver, pageData);
                                    return process;
                                }
                            case ObjectType.ENAMECASESTUDY_DTIME:
                                {
                                    var process = _Process.enamecasestudy_dtime(driver, pageData);
                                    return process;
                                }
                            case ObjectType.LOCEBOOK_DTIME:
                                {
                                    var process = _Process.locebook_dtime(driver, pageData);
                                    return process;
                                }
                            case ObjectType.ENAMEEBOOK_DTIME:
                                {
                                    var process = _Process.enameebook_dtime(driver, pageData);
                                    return process;
                                }
                            case ObjectType.LOCDATASHEET_DTIME:
                                {
                                    var process = _Process.locdatasheet_dtime(driver, pageData);
                                    return process;
                                }
                            case ObjectType.ENAMEDATASHEET_DTIME:
                                {
                                    var process = _Process.enamedatasheet_dtime(driver, pageData);
                                    return process;
                                }
                            case ObjectType.GETDATETIMENEW:
                                {
                                    var process = _Process.getdatetimenew(driver, pageData);
                                    return process;
                                }
                        }

                        return "fail";
                    }

                #endregion
                #region switchto
                case Commands.SWITCHTO:
                    {
                        var process = _Process.switchto(driver, pageData);
                        return process;
                    }
                #endregion
                #region silverlight
                case Commands.SILVERLIGHT:
                    {
                        var process = _Process.silverlight(driver, pageData);
                        return process;
                    }
                #endregion
                #region fileupload
                case Commands.FILEUPLOAD:
                    {
                        var process = _Process.fileupload(driver, pageData);
                        return process;
                    }
                #endregion
                #region alertclose
                case Commands.ALERTCLOSE:
                    {
                        var process = _Process.alertclose(driver, pageData);
                        return process;
                    }
                #endregion
                #region digievent
                case Commands.DIGIEVENT:
                    {
                        var process = _Process.digievent(driver, pageData);
                        return process;
                    }
                #endregion
                #region gatrackingid
                case Commands.GETRACKINGID:
                    {
                        var process = _Process.gatrackingid(driver, pageData);
                        return process;
                    }
                #endregion
            }
            return "fail";
        }


        private void FailureReasons(string process, string forthcol, string fifthcol)
        {
            if (process.Contains("UI"))
            {
                forthcol = "fail";
                fifthcol = "Test step has been failed";
            }
            else if (process.Contains("exection"))
            {
                forthcol = "fail";
                fifthcol = process.Split(' ')[0];
            }
        }
        public string newtab(IWebDriver driver, string thirdcol)
        {
            try
            {
                String script = "var d=document,a=d.createElement('a');a.target='_blank';a.href=" + "'" + thirdcol + "'" + ";a.innerHTML='.';d.body.appendChild(a);return a";
                Object element = trigger(script);
                IWebElement anchor = (IWebElement)element;
                String url = anchor.GetAttribute("href");
                anchor.Click();
                return "Pass";

            }
            catch (System.Exception)
            {
                return "fail";
            }

        }
        public List<string> Process_row_Column(DataRow row)
        {
            List<string> list = new List<string>();
            foreach (object item in row.ItemArray)
            {
                list.Add(item.ToString());
            }
            return list;
        }
    }
}
