using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
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
    class clsPieChartCreation
    {
        public static void PieChartReport(int pass , int fail , int notRun)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            int totalNumberOfTestcase = pass + fail + notRun;
            //add data 
            xlWorkSheet.Cells[1, 1] = "Status";
            xlWorkSheet.Cells[1, 2] = "Result";
            

            xlWorkSheet.Cells[2, 1] = "Pass";
            xlWorkSheet.Cells[2, 2] = pass;
           

            xlWorkSheet.Cells[3, 1] = "Fail";
            xlWorkSheet.Cells[3, 2] = fail;
            

            xlWorkSheet.Cells[4, 1] = "NotRun";
            xlWorkSheet.Cells[4, 2] = notRun;
            


            Excel.Range chartRange;

            Excel.ChartObjects xlCharts = (Excel.ChartObjects)xlWorkSheet.ChartObjects(Type.Missing);
            Excel.ChartObject myChart = (Excel.ChartObject)xlCharts.Add(10, 80, 300, 250);
            Excel.Chart chartPage = myChart.Chart;

            chartRange = xlWorkSheet.get_Range("A1", "B4");
            chartPage.SetSourceData(chartRange, misValue);
            chartPage.ChartType = Excel.XlChartType.xl3DPie;
         
            
            xlWorkBook.SaveAs(ParallelSelenium.Parallel_Quest.targetdir + "\\" + "Rrsult_Piechart.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);;
            releaseObject(xlApp);


        }
        private static void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
            
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
