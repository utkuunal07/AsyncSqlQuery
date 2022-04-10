using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;
using System.Diagnostics;

namespace RaporsForms
{
    class Program
    {
        Excelyaz excel = new Excelyaz();
        
        Thread t;
        string now;
        Exception expection;
        Form3Func form3;
        static int raporcheck;
        static int raporcheck2;
        static string connectionString;
        static Label raporbasladitext;
        static Stopwatch stopWatch;
        static List<string> sqlquery;
        static DataTable[] TaskMyDataTable;

      
        public Program(string aConnectionString, List<string> aSqlquery , int aRaporcheck, int aRaporcheck2, Label aRaporbasladitext,Stopwatch aStopwatch, Form3Func aForm3)
        {
            connectionString = aConnectionString;
            sqlquery = aSqlquery;
            raporcheck = aRaporcheck;
            raporcheck2 = aRaporcheck2;
            raporbasladitext = aRaporbasladitext;
            stopWatch = aStopwatch;
            form3 = aForm3;
            TaskMyDataTable = new DataTable[sqlquery.Count];
            now = DateTime.Now.ToString("MM.dd.yyyy HH.mm");

        }

        public void Async()
        {
            OracleDataAdapter[] adapterList = new OracleDataAdapter[sqlquery.Count];
            OracleDataReader[] drList = new OracleDataReader[sqlquery.Count];
            OracleConnection[] connList = new OracleConnection[sqlquery.Count];

            ManualResetEvent[] events = new ManualResetEvent[sqlquery.Count];//Create a wait handle
            for (int i = 0; i < events.Length; i++)
            {
                events[i] = new ManualResetEvent(false);
                
            }
            for (int i = 0; i < sqlquery.Count; i++)
            {

                OracleConnection conn = new OracleConnection(connectionString);
                connList[i] = conn;

                adapterList[i] = new OracleDataAdapter(sqlquery[i], connList[i]);

                connList[i].Open();
                
            }
            
            for (int i = 0; i < sqlquery.Count; i++)
            {
                var index = i;
                //TaskMyDataTable[index] = Task.Run(() => Read2<OracleDataAdapter>(sqlquery[index], connList[index], adapterList[index]));

                t = new Thread(() => Read2(sqlquery[index], connList[index], adapterList[index], events[index], index));
                t.Start();
                
            }

            //Console.WriteLine("Raporlar Çekiliyor...");

            int nthloop = 0;
            raporbasladitext.Text = "Rapor Sorgusu Başladı!";
            raporbasladitext.Visible = true;

            while (events.Any(x => x != null))//while events have elements
            {
                List<int> donetables=new List<int>();
                ManualResetEvent[] nonnullevents = events.Where(x => x != null).ToArray();

                
                int first = WaitHandle.WaitAny(nonnullevents); //isEmpty =  events.All(x => x!=null)
                if (expection!=null)
                {
                    form3.Close();
                    throw new InvalidOperationException(expection.Message);

                }
                excel.ExceleYaz(TaskMyDataTable, sqlquery.Count, raporcheck, raporcheck2, nthloop,now);

                for (int i = 0; i < TaskMyDataTable.Length; i++)
                {
                    if (TaskMyDataTable[i]!=null)
                    {
                        donetables.Add(i);
                        TaskMyDataTable[i] = null;
                        //events = events.Where((source, index) => index != i).ToArray();
                        events[i] = null;
                    }
                }

                nthloop++;
            }
            for (int i = 0; i < sqlquery.Count; i++)
            {
                connList[i].Close();
            }

            form3.Close();
            stopWatch.Stop();
            raporbasladitext.Text = "Rapor Sorgusu Bitti!";
        }
        public void Read2(string query, OracleConnection connectionList, OracleDataAdapter da, EventWaitHandle i,int indx)
        {
            try
            {
                DataSet ds = new DataSet();
                da.Fill(ds);
                TaskMyDataTable[indx] = ds.Tables[0];

                i.Set();
            }
            catch (Exception ex)
            {
                expection = ex;
                
                i.Set();
            }
        }
    }
}