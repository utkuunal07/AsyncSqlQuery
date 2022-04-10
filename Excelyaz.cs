using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;
using System.IO;

namespace RaporsForms
{
    class Excelyaz
    {
     
        
        public void ExceleYaz(DataTable[] Tables, int sqlquerycount , int raporcheck, int raporcheck2, int loop, string now)
        {
            DataTable dataTable = new DataTable();
            Tables = Tables.Where(c => c != null).ToArray();

            //string nowStr = now.ToString().Replace(":", ".");
            //string nowStr = now.ToString();
            string strPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

            string p_strPath = strPath + "\\" + "rapor " + " " + now + ".xlsx";
            if (loop==0)
            {
                
                if (raporcheck2 == 1)
                {
                    for (int i = 0; i < Tables.Length; i++)
                    {

                        if (i != 0)
                        {
                            dataTable.Merge(Tables[i]);
                        }
                        else
                        {
                            dataTable = Tables[i];
                        }

                    }
                    Console.WriteLine(loop + 1 + ".gelen datalar Excel'e yazılıyor...");
                    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                    using (ExcelPackage pck = new ExcelPackage())
                    {
                        ExcelWorksheet workSheet = pck.Workbook.Worksheets.Add("rapor");
                        workSheet.Cells[1, 1].LoadFromDataTable(dataTable, true);
                        pck.SaveAs(new FileInfo(p_strPath));
                    }

                    Console.WriteLine(loop + 1 + ".gelen datalar Excel'e yazıldı!");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                }
                if (raporcheck2 == 2)
                {
                    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                    FileInfo exsistingFile = new FileInfo(p_strPath);
                    using (ExcelPackage pck = new ExcelPackage(exsistingFile))
                    {
                        Console.WriteLine(loop + 1 + ".gelen datalar Excel'e yazılıyor...");
                        for (int i = 0; i < Tables.Length; i++) // diffrent tables, cant merge
                        {
                            ExcelWorksheet workSheet = pck.Workbook.Worksheets.Add("rapor" + pck.Workbook.Worksheets.Count);
                            workSheet.Cells[1, 1].LoadFromDataTable(Tables[i], true);

                        }
                        pck.SaveAs(new FileInfo(p_strPath));
                    }
                    Console.WriteLine(loop + 1 + ".gelen datalar Excel'e yazıldı!");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                }   
            }
            else
            {
                
                if (raporcheck2 == 1)
                {
                    for (int i = 0; i < Tables.Length; i++)
                    {
                        //Tables[i].Rows[0].Delete();
                        //Tables[i].AcceptChanges();

                        if (i != 0)
                        {
                            dataTable.Merge(Tables[i]);
                        }
                        else
                        {
                            dataTable = Tables[i];
                        }
                    }

                    Console.WriteLine(loop + 1 + ".gelen datalar Excel'e yazılıyor...");
                    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                    FileInfo exsistingFile = new FileInfo(p_strPath);
                    using (ExcelPackage pck = new ExcelPackage(exsistingFile))
                    {
                        ExcelWorksheet workSheet = pck.Workbook.Worksheets[0];
                        int numRow = workSheet.Dimension.Rows;
                        workSheet.Cells[numRow + 1, 1].LoadFromDataTable(dataTable, false);
                        pck.SaveAs(new FileInfo(p_strPath));
                    }
                    Console.WriteLine(loop + 1 + ".gelen datalar Excel'e yazıldı!");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                }
                if (raporcheck2 == 2)
                {
                    
                    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                    FileInfo exsistingFile = new FileInfo(p_strPath);
                    using (ExcelPackage pck = new ExcelPackage(exsistingFile))
                    {
                        Console.WriteLine(loop + 1 + ".gelen datalar Excel'e yazılıyor...");
                        for (int i = 0; i < Tables.Length; i++) // diffrent tables, cant merge
                        {
                            

                            ExcelWorksheet workSheet = pck.Workbook.Worksheets.Add("rapor" + pck.Workbook.Worksheets.Count);
                            workSheet.Cells[1, 1].LoadFromDataTable(Tables[i], true);
                        }

                        pck.SaveAs(new FileInfo(p_strPath));
                    }
                    Console.WriteLine(loop + 1 + ".gelen datalar Excel'e yazıldı!");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                }
            }
        }
    }
}
