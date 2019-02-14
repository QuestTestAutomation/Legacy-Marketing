using System;
using System.Net;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using NUnit.Framework;
using ParallelSelenium.Utils;
using System.Collections.Generic;
using System.IO;
using Microsoft.Office.Interop.Excel;
using System.Data;
using System.Runtime.InteropServices;
using System.Diagnostics;
using ParallelSelenium.Common;
using OpenQA.Selenium.Chrome;
using System.Linq;



namespace ParallelSelenium
{


    [TestFixture("internet explorer", "", "Windows 7", "", "")]
    [TestFixture("firefox", "", "Windows 7", "", "")]
    [TestFixture("chrome", "", "Windows 7", "", "")]
    [TestFixture("internet explorer", "11", "Windows 10", "", "")]
    [TestFixture("chrome", "60", "Windows 10", "", "")]
    [Parallelizable(ParallelScope.Fixtures)]



    public class Parallel_Quest
    {
        public IWebDriver driver;
        private String version;
        private String os;
        private String deviceName;
        private String deviceOrientation;
        public static string ImagePath { get; set; }
        public static string targetdir { get; set; }
        Logger logging = new Logger();
        FileHandler Path = new FileHandler();
        String username = "";
        List<string> modules;


        public Parallel_Quest(String browser, String version, String os, String deviceName, String deviceOrientation)
        {
            this.version = version;
            this.os = os;
            this.deviceName = deviceName;
            this.deviceOrientation = deviceOrientation;

        }

        [Test, Property("Description", "Test_suite")]

        public void Test_Suite()
        {
           
            ProcessCall();
            ParallelSelenium.clsPieChartCreation.PieChartReport(totalNoOfPassTestcase, totalNoOfFailTestcase, totalNoOfNotRunTestcase);

        }
        
        int totalNoOfPassTestcase;
        int totalNoOfFailTestcase;
        int totalNoOfNotRunTestcase;
        string piechartpathloction;
        private void ProcessCall()
        {
            #region Intitialize
            List<string> list = new List<string>();
            List<string> TC_Final_Result = new List<string>();
            List<string> DashBoard = new List<string>();
            int notRunTestCase;
            string output = "fail";
            string dirPath = Path.GetRelativePath() + "Test_Library\\";           
            DateTime now = DateTime.Now;
            string date = now.ToString();
            date = date.Replace(":", "-");
            date = date.Replace("/", "-");
            date = date.Replace(" ", "-");
            String resultsname = "Test_Results_" + date;
            piechartpathloction = resultsname;
            targetdir = Path.GetRelativePath() + "Test_Results\\" + username + "\\Test_Report\\" + resultsname;
            string imagefolder = Path.GetRelativePath() + "Test_Results\\" + username + "\\Snapshots\\" + "Snapshots_" + date + "\\";
          
            if (!Directory.Exists(targetdir))
            {
                Directory.CreateDirectory(targetdir);
            }
            if (!Directory.Exists(imagefolder))
            {
                Directory.CreateDirectory(imagefolder);
                ImagePath = imagefolder;
            }
            #endregion
            #region Copy Test Cases To Result Folder
            Copy(dirPath, targetdir);
            string[] filename = Directory.GetFiles(targetdir, "*.*", System.IO.SearchOption.AllDirectories);
            Application app = new Application();
            int passcasecount = 0;
            int failcasecount = 0;
            for (int a = 0; a < filename.Length; a++)
            {
                if (!filename[a].Contains("~"))
                {
                    string path = filename[a];
                    Workbook wb = logging.ExcelWorkbook(app, path);
                    {
                        ProcessElements ProcessRow = new ProcessElements(driver);
                        String[] names = Path.GetExcelSheetNames(path);
                        List<string> name = new List<string>();
                        for (int n = 0; n < names.Length; n++)
                        {
                            if (names[n].ToLower().Contains("dashboard"))
                            {
                                name = Path.Get_Executable_Sheets(path, out notRunTestCase);
                                totalNoOfNotRunTestcase += notRunTestCase;
                            }
                        }
                        for (int i = 0; i < name.Count; i++)
                        {
                            int rowcount = 2;
                            Worksheet ws = logging.ExcelWorkSheet(wb, name[i]);
                            System.Data.DataTable xyz = Path.exceldata(path, name[i] + "$");
                            foreach (DataRow row in xyz.Rows)
                            {
                                List<string> param = Process_row_Column(row);
                                output = ProcessRow.ProcessRow(param[1], param[2], param[3], param[4], param[5]);
                                TC_Final_Result.Add(output);
                                ws = logging.Write_Result_Excel(ws, output, rowcount);
                                rowcount = rowcount + 1;
                            }
                            rowcount = Path.Set_Executable_Sheets(path, name[i].Replace("$", ""));
                            int passcount = 0;
                            int failcount = 0;
                            

                            for (int m = 0; m < TC_Final_Result.Count; m++)
                            {

                                if (TC_Final_Result[m].ToLower().Contains("pass"))
                                {
                                    passcount = passcount + 1;
                                }
                                else
                                {
                                    failcount = failcount + 1;
                                }

                            }

                            DashBoard.Add(TC_Final_Result.Count.ToString());
                            DashBoard.Add(passcount.ToString());
                            DashBoard.Add(failcount.ToString());

                            if (!TC_Final_Result.All(x => x.ToLower().Contains("pass")))
                            {
                                DashBoard.Add("FAIL");
                                failcasecount = failcasecount + 1;
                                totalNoOfFailTestcase += failcasecount;
                                logging.DashBoard_Update(path, wb, rowcount, DashBoard);
                                DashBoard.Clear();
                            }
                            else
                            {
                                DashBoard.Add("PASS");

                                passcasecount = passcasecount + 1;
                                totalNoOfPassTestcase += passcasecount;
                                logging.DashBoard_Update(path, wb, rowcount, DashBoard);
                                DashBoard.Clear();
                            }
                            totalNoOfPassTestcase = passcasecount;
                            totalNoOfFailTestcase = failcasecount;
                            logging.Save_WorkSheet(ws);

                            TC_Final_Result.Clear();


                        }
                      

                        wb = logging.Save_WorkBook(wb);

            #endregion
                    }
                }
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
        void Copy(string sourceDir, string targetDir)
        {
            Directory.CreateDirectory(targetDir);

            foreach (var file in Directory.GetFiles(sourceDir))
            {
                File.Copy(file, System.IO.Path.Combine(targetDir, System.IO.Path.GetFileName(file)));
            }


            foreach (var directory in Directory.GetDirectories(sourceDir))
            {
                if (modules.Any(x => directory.Contains(x)))
                    Copy(directory, System.IO.Path.Combine(targetDir, System.IO.Path.GetFileName(directory)));
            }
        }
        [SetUp]
        public void Init()
        {
            string paths = Path.GetRelativePath() + "TestSetup\\ConfigurationSetup.xlsx";
            
            modules = new FileHandler().Get_ModuleSetup_Sheets(paths);
            string modulename = modules[0];

            #region Close All Existing Excel instances
            Process[] procs = Process.GetProcessesByName("Excel");
            for (int proccount = 0; proccount < procs.Length; proccount++)
            {
                procs[proccount].Kill();
            }
            #endregion

            string path = Path.GetRelativePath() + "TestSetup\\ConfigurationSetup.xlsx";         
            var credential = new FileHandler().Get_credentialDetails(path);
            username = credential[0].Trim();
            Process.Start(Path.GetRelativePath() + @"packages\extensions\Upload_File\UploadFileToSauce.exe");
        

            ChromeOptions options = new ChromeOptions();
            options.AddExtensions(Path.GetRelativePath() + @"packages\extensions\extension_4_8.crx");
            options.AddExtensions(Path.GetRelativePath() + @"packages\extensions\extension_2_6.crx");

            options.AddAdditionalCapability(CapabilityType.Version, "", true);
            options.AddAdditionalCapability("name", TestContext.CurrentContext.Test.Properties.Get("Descriptions"), true);
            options.AddAdditionalCapability("username", username, true);
            options.AddAdditionalCapability("accessKey", credential[1].Trim(), true);
            DesiredCapabilities capabilities = new DesiredCapabilities();
            options.SetLoggingPreference(LogType.Browser, LogLevel.All);
            capabilities = options.ToCapabilities() as DesiredCapabilities;
            driver = new RemoteWebDriver(new Uri("http://ondemand.saucelabs.com:80/wd/hub"), capabilities, TimeSpan.FromSeconds(600));

        }

        [TearDown]
        public void Cleanup()
        {
            #region Close All Existing Excel instances
            Process[] procs = Process.GetProcessesByName("Excel");
            for (int proccount = 0; proccount < procs.Length; proccount++)
            {
                procs[proccount].Kill();
            }
            bool passed = TestContext.CurrentContext.Result.Outcome.Status == NUnit.Framework.Interfaces.TestStatus.Passed;
            try
            {
                // Logs the result to Sauce Labs
                ((IJavaScriptExecutor)driver).ExecuteScript("sauce:job-result=" + (passed ? "passed" : "failed"));
            }
            finally
            {
                driver.Quit();
            }
            #endregion
        }

    }
}

