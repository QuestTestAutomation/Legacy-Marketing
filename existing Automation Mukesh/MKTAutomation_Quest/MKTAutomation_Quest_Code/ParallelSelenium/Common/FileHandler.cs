using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.OleDb;
using System.Globalization;
using System.Reflection;
using Microsoft.VisualBasic.FileIO;
using NUnit.Framework;

namespace ParallelSelenium.Common
{
    public class FileHandler
    {
        private static Microsoft.Office.Interop.Excel.Workbook mWorkBook;
        private static Microsoft.Office.Interop.Excel.Sheets mWorkSheets;
        private static Microsoft.Office.Interop.Excel.Worksheet mWSheet1;
        private static Microsoft.Office.Interop.Excel.Application oXL;
       

        public String GetRelativePath()
        {


          //  string c = System.IO.Directory.GetCurrentDirectory();
            string c = TestContext.CurrentContext.TestDirectory;
        
            string[] stringSeparators = new string[] { "ParallelSelenium" };
            string[] str1 = c.Split(stringSeparators, StringSplitOptions.None);
            return str1[0];
        }
        public List<string> Get_ModuleSetup_Sheets(string filePath)
        {


            DataTable dtexcel = new DataTable();
            bool hasHeaders = false;
            string HDR = hasHeaders ? "Yes" : "No";
            string strConn;
            if (filePath.Substring(filePath.LastIndexOf('.')).ToLower() == ".xlsx")
                strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath + ";Extended Properties=\"Excel 12.0;HDR=" + HDR + ";IMEX=0\"";
            else
                strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath + ";Extended Properties=\"Excel 8.0;HDR=" + HDR + ";IMEX=0\"";
            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();
            DataTable schemaTable = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
            DataRow schemaRow = schemaTable.Rows[1];

            string query = "SELECT  * FROM [" + "TestSetup$" + "]";
            OleDbDataAdapter daexcel = new OleDbDataAdapter(query, conn);
            dtexcel.Locale = CultureInfo.CurrentCulture;
            daexcel.Fill(dtexcel);

            List<string> modules = (from row in dtexcel.AsEnumerable()
                                    where row.Field<string>("ToRun").ToLower() == "Y".ToLower()
                                    select row.Field<string>("Module Name")).ToList();


            conn.Close();

            return modules;

        }
        public List<string> Get_credentialDetails(string filePath)
        {


            DataTable dtexcel = new DataTable();
            bool hasHeaders = false;
            string HDR = hasHeaders ? "Yes" : "No";
            string strConn;
            if (filePath.Substring(filePath.LastIndexOf('.')).ToLower() == ".xlsx")
                strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath + ";Extended Properties=\"Excel 12.0;HDR=" + HDR + ";IMEX=0\"";
            else
                strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath + ";Extended Properties=\"Excel 8.0;HDR=" + HDR + ";IMEX=0\"";
            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();
            DataTable schemaTable = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
            DataRow schemaRow = schemaTable.Rows[1];

            string query = "SELECT  * FROM [" + "CrendentialSetup$" + "]";
            OleDbDataAdapter daexcel = new OleDbDataAdapter(query, conn);
            dtexcel.Locale = CultureInfo.CurrentCulture;
            daexcel.Fill(dtexcel);

            var modules = (from row in dtexcel.AsEnumerable() select row.Field<string>("Values")).ToList();
            conn.Close();
            return modules;

        }
        public string Get_Global_Value(DataTable Global, int rowval)
        {
            return Global.Rows[rowval].ItemArray[2].ToString();

        }
        public DataTable Get_DT_Global_Value()
        {
            string filepath = GetRelativePath() + "Do_Not_Touch\\Global.csv";
            System.Data.DataTable xyz = DT_CSV(filepath);
            return xyz;

        }
       
        public DataTable DT_CSV(string csv_file_path)
        {
            DataTable csvData = new DataTable();
            try
            {
                using (TextFieldParser csvReader = new TextFieldParser(csv_file_path))
                {
                    csvReader.SetDelimiters(new string[] { "," });
                    csvReader.HasFieldsEnclosedInQuotes = true;
                    //read column names
                    string[] colFields = csvReader.ReadFields();
                    foreach (string column in colFields)
                    {
                        DataColumn datecolumn = new DataColumn(column);
                        datecolumn.AllowDBNull = true;
                        csvData.Columns.Add(datecolumn);
                    }
                    while (!csvReader.EndOfData)
                    {
                        string[] fieldData = csvReader.ReadFields();
                        //Making empty value as null
                        for (int i = 0; i < fieldData.Length; i++)
                        {
                            if (fieldData[i] == "")
                            {
                                fieldData[i] = null;
                            }
                        }
                        csvData.Rows.Add(fieldData);
                    }
                }
            }
            catch (System.Exception)
            {

            }
            return csvData;
        }
       
        public List<string> Get_Executable_Sheets(string filePath , out int notRunTestCase)
        {


            DataTable dtexcel = new DataTable();
            bool hasHeaders = false;
            string HDR = hasHeaders ? "Yes" : "No";
            string strConn;
            if (filePath.Substring(filePath.LastIndexOf('.')).ToLower() == ".xlsx")
                strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath + ";Extended Properties=\"Excel 12.0;HDR=" + HDR + ";IMEX=0\"";
            else
                strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath + ";Extended Properties=\"Excel 8.0;HDR=" + HDR + ";IMEX=0\"";
            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();
            DataTable schemaTable = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
            DataRow schemaRow = schemaTable.Rows[1];


            {
                string query = "SELECT  * FROM [" + "DashBoard$" + "]";
                OleDbDataAdapter daexcel = new OleDbDataAdapter(query, conn);
                dtexcel.Locale = CultureInfo.CurrentCulture;
                daexcel.Fill(dtexcel);
            }
            List<string> visible = (from row in dtexcel.AsEnumerable()
                                    where row.Field<string>("Execution").ToLower() == "Y".ToLower()
                                    select row.Field<string>("Sheet_Name")).ToList();
             notRunTestCase = (from row in dtexcel.AsEnumerable()
                                    where row.Field<string>("Execution").ToLower() == "N".ToLower()
                                    select row.Field<string>("Sheet_Name")).ToList().Count;


            conn.Close();

            return visible;

        }
        public int Set_Executable_Sheets(string filePath, string Sheet_Name)
        {


            DataTable dtexcel = new DataTable();
            bool hasHeaders = false;
            string HDR = hasHeaders ? "Yes" : "No";
            string strConn;
            if (filePath.Substring(filePath.LastIndexOf('.')).ToLower() == ".xlsx")
                strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath + ";Extended Properties=\"Excel 12.0;HDR=" + HDR + ";IMEX=0\"";
            else
                strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath + ";Extended Properties=\"Excel 8.0;HDR=" + HDR + ";IMEX=0\"";
            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();
            DataTable schemaTable = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
            DataRow schemaRow = schemaTable.Rows[1];


            {
                string query = "SELECT  * FROM [" + "DashBoard$" + "]";
                OleDbDataAdapter daexcel = new OleDbDataAdapter(query, conn);
                dtexcel.Locale = CultureInfo.CurrentCulture;
                daexcel.Fill(dtexcel);
            }
            List<string> vis = (from row in dtexcel.AsEnumerable()
                                where row.Field<string>("Sheet_Name").ToLower() == Sheet_Name.ToLower()
                                select row.Field<string>("S_No")).ToList();


            conn.Close();

            int rowcount = Convert.ToInt32(vis[0]) + 1;
            return rowcount;

        }              
        public String[] GetExcelSheetNames(string filePath)
        {
            OleDbConnection objConn = null;
            System.Data.DataTable dt = null;

            try
            {
                // Connection String. Change the excel file to the file you
                // will search.
                string strConn;
                bool hasHeaders = false;
                string HDR = hasHeaders ? "Yes" : "No";

                if (filePath.Substring(filePath.LastIndexOf('.')).ToLower() == ".xlsx")
                    strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath + ";Extended Properties=\"Excel 12.0;HDR=" + HDR + ";IMEX=0\"";
                else
                    strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath + ";Extended Properties=\"Excel 8.0;HDR=" + HDR + ";IMEX=0\"";
                // Create connection object by using the preceding connection string.
                objConn = new OleDbConnection(strConn);
                // Open connection with the database.
                objConn.Open();
                // Get the data table containg the schema guid.
                dt = objConn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

                if (dt == null)
                {
                    return null;
                }

                String[] excelSheets = new String[dt.Rows.Count];
                int i = 0;

                // Add the sheet name to the string array.
                foreach (DataRow row in dt.Rows)
                {
                    excelSheets[i] = row["TABLE_NAME"].ToString();
                    i++;
                }

                // Loop through all of the sheets if you want too...
                for (int j = 0; j < excelSheets.Length; j++)
                {
                    // Query each excel sheet.
                }

                return excelSheets;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                // Clean up.
                if (objConn != null)
                {
                    objConn.Close();
                    objConn.Dispose();
                }
                if (dt != null)
                {
                    dt.Dispose();
                }
            }
        }     
        public DataTable exceldata(string filePath, string sheet)
        {
            DataTable dtexcel = new DataTable();

            bool hasHeaders = false;
            string HDR = hasHeaders ? "Yes" : "No";
            string strConn;
            if (filePath.Substring(filePath.LastIndexOf('.')).ToLower() == ".xlsx")
                strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath + ";Extended Properties=\"Excel 12.0;HDR=" + HDR + ";IMEX=0\"";
            else
                strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath + ";Extended Properties=\"Excel 8.0;HDR=" + HDR + ";IMEX=0\"";
            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();
            //DataTable schemaTable = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
            //Looping Total Sheet of Xl File
            /*foreach (DataRow schemaRow in schemaTable.Rows)
            {
            }*/
            //Looping a first Sheet of Xl File
            // DataRow schemaRow = schemaTable.Rows[0];

            if (!sheet.EndsWith("_"))
            {
                string query = "SELECT  * FROM [" + sheet + "]";
                OleDbDataAdapter daexcel = new OleDbDataAdapter(query, conn);
                dtexcel.Locale = CultureInfo.CurrentCulture;
                daexcel.Fill(dtexcel);
            }

            conn.Close();
            return dtexcel;



        }
               
    }
}
