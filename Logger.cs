using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaporsForms
{
    public static class Logger
    {
        public static void WriteException(Exception exception)
        {
            string filePath = @"C:\Error.txt";

            using (StreamWriter logWriter = new StreamWriter(filePath, true))
            {
                logWriter.WriteLine("Message :" + exception.Message + "<br/>" + Environment.NewLine + "StackTrace :" + exception.StackTrace +
                   "" + Environment.NewLine + "Date :" + DateTime.Now.ToString());
                logWriter.WriteLine(Environment.NewLine + "-----------------------------------------------------------------------------" + Environment.NewLine);
            }
        }
    }
}
