using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;
using System.Net;
using System.Net.Mail;
using Ionic.Zip;
using System.Data;
using Outlook = Microsoft.Office.Interop.Excel;

namespace ParallelSelenium.Common
{
    public sealed class BasicActions
    {

        //Data data;


        public BasicActions()
        {
            //data = new Data();

        }



        //function library method start...

        public void BasicActionsMethod()
        {

        }

        public String[] String_Array(string Text)
        {
            String[] Stringarray = Text.Split(',');
            return Stringarray;
        }

        public string Zip_Results()
        {
            ZipFile zip = new ZipFile();
            string results_name = Parallel_Quest.targetdir.Substring(Parallel_Quest.targetdir.LastIndexOf("\\"));
            try
            {
                zip.AddDirectory(Parallel_Quest.targetdir, "");
                zip.Save(Parallel_Quest.targetdir + ".zip");
                return results_name;
            }

            catch (System.Exception)
            {
                return "false";
            }
        }


        public void SendEmail()
        {
            FileHandler file = new FileHandler();
            DataTable Global = file.Get_DT_Global_Value();
            string senderID = file.Get_Global_Value(Global, 0);
            string senderPassword = file.Get_Global_Value(Global, 1); // sender password here…
            string toAddress = file.Get_Global_Value(Global, 2);
            string subject = file.Get_Global_Value(Global, 3);
            string s = file.Get_Global_Value(Global, 4);
            s = s.Replace("\n", "<br/> ");
            string body = "Hi Team, <br/><br/>" + s;
            body += " <br/><br/> Thanks, <br/> Brian & Mukesh <br/> Dell Team";
            try
            {

                SmtpClient smtp = new SmtpClient

                {

                    Host = file.Get_Global_Value(Global, 5),
                    Port = Convert.ToInt32(file.Get_Global_Value(Global, 6)),
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    Credentials = new System.Net.NetworkCredential(senderID, senderPassword),
                    Timeout = 30000,
                };
                MailMessage mail = new MailMessage(senderID, toAddress, subject, body);
                string results_name = Zip_Results();
                string pathss = GetRelativePath();
                Attachment _attachment = new Attachment(pathss + "Test_Results\\Test_Report" + results_name + ".zip");
                mail.IsBodyHtml = true;
                mail.Attachments.Add(_attachment);

                smtp.Send(mail);
            }
            catch (System.Exception)
            {


            }

        }


        public String GetDateTime()
        {
            String date1, time1;
            DateTime now = DateTime.Now;
            String d = now.ToString("d");
            String[] dateSplit = d.Split("/"[0]);
            String dateSplit1 = dateSplit[0];
            String dateSplit2 = dateSplit[1];
            String dateSplit3 = dateSplit[2];
            String t = now.ToString("T");
            String[] timeSplit = t.Split(":"[0]);
            String timeSplit1 = timeSplit[0];
            String timeSplit2 = timeSplit[1];
            String timeSplit3 = timeSplit[2];
            try
            {
                date1 = dateSplit2 + dateSplit1 + dateSplit3;
                time1 = timeSplit1 + timeSplit2;
                return date1 + time1;
            }
            catch (System.Exception)
            {
                return "false";
            }
        }

        public String GetFutureDate()
        {
            String date1;
            String now = DateTime.Today.AddDays(7).ToString();
            String[] dateSplit = now.Split("/"[0]);
            String dateSplit1 = dateSplit[0];
            String dateSplit2 = dateSplit[1];
            String[] year = dateSplit[2].Split(" "[0]);
            String dateSplit3 = year[0];

            date1 = dateSplit1 + "/" + dateSplit2 + "/" + dateSplit3;
            return date1;
        }

        public string GetRandomString()
        {
            string path = Path.GetRandomFileName();
            path = path.Replace(".", ""); // Remove period.
            return path;
        }

        public String GetDate()
        {
            String date1;
            DateTime now = DateTime.Now;
            String d = now.ToString("d");
            String[] dateSplit = d.Split("/"[0]);
            String dateSplit1 = dateSplit[0];
            String dateSplit2 = dateSplit[1];
            String dateSplit3 = dateSplit[2];
            date1 = dateSplit1 + "/" + dateSplit2 + "/" + dateSplit3;

            return date1;
        }


        public String GetRelativePath()
        {
            //string c = System.IO.Directory.GetCurrentDirectory();
            //if (c.Contains("TestResults"))
            //{
            //    string[] stringSeparators = new string[] { "TestResults" };
            //    string[] str1 = c.Split(stringSeparators, StringSplitOptions.None);
            //    return str1[0];
            //}
            //else
            //{
            //    string[] stringSeparators = new string[] { "bin" };
            //    string[] str1 = c.Split(stringSeparators, StringSplitOptions.None);
            //    return str1[0];
            //}


            string c = System.IO.Directory.GetCurrentDirectory();
            string[] stringSeparators = new string[] { "Do_Not_Touch" };
            string[] str1 = c.Split(stringSeparators, StringSplitOptions.None);
            return str1[0];


        }


    }
}
