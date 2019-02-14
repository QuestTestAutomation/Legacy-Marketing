using System.Data.SqlClient;
using System.Data;
using OpenQA.Selenium;

namespace ParallelSelenium.Utils
{
    public class Database_testing
    {
        public IWebDriver driver;
            string connectionString = null;
            SqlConnection cnn ;
           
            public string FirstName { get; set; }
           
           
              
            public DataTable connect()
        {


            if (driver.Url.Contains("stage"))
                {
                    //stage database
                    string ServerName = "stage-reporting-wwwdb2012";
                    string UserName = "IUSR_QA_Report";
                    string Password = "tester@QA%";
                    string DatabaseName = "WebReport";
                    return db_connection(ServerName, UserName, Password, DatabaseName);
                }
                else
                {
                    
                    string ServerName = "reporting-wwwdb2012";
                    string UserName = "IUSR_QA_Report";
                    string Password = "6gzWpm0OiCTKYwbosYVn";
                    string DatabaseName = "WebReport";
                    return db_connection(ServerName, UserName, Password, DatabaseName);
                }
 
            
            
        }

            private DataTable db_connection(string ServerName, string UserName, string Password, string DatabaseName)
            {
                connectionString = "Data Source=" + ServerName + ";Initial Catalog=" + DatabaseName + ";User ID=" + UserName + ";Password=" + Password;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter();
                    using (SqlCommand command = new SqlCommand(
                                 "SELECT top 1 *  FROM [WebReport].[dbo].[vw_QA_Report_Prospect] where timestamp > DATEADD(minute, -5, getdate()) and email='Mukesh.jha@quest.com' order by timestamp desc", connection))
                    {

                        connection.Open();
                        da.SelectCommand = command;
                        DataTable dt = new DataTable();
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        dt = ds.Tables[0];
                        return dt;


                        /* */
                        //i have to close data base

                    }

                }
            }
			
    }

}
