using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftwareLocker;

namespace RaporsForms
{
    static class MainProgram
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static Form MainForm = null;

        [STAThread]
        static void Main()
        {
            bool IsTrial;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            TrialMaker t = new TrialMaker("TMTest1", Application.StartupPath + "\\RegFile.reg", Application.StartupPath + "\\TMSetp.dbf", "Mail atarak şifrenize ulaşabilirsiniz ",
                0, 0, "158");

            byte[] MyOwnKey = { 97, 250,  1,  5,  84, 21,   7, 63,
                         4,  54, 87, 56, 123, 10,   3, 62,
                         7,   9, 20, 36,  37, 21, 101, 57};
            t.TripleDESKey = MyOwnKey;
            // if you don't call this part the program will
            //use default key to encryption

            TrialMaker.RunTypes RT = t.ShowDialog();


            if (RT != TrialMaker.RunTypes.Expired)
            {
                if (RT == TrialMaker.RunTypes.Full)
                    IsTrial = false;
                else
                    IsTrial = true;
                
                Application.Run(new Form1(IsTrial, t.MaxRaporCount));
            }

            //Application.ThreadException += Application_ThreadException;
            //Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            //MainForm = new Form1(IsTrial);
            //Application.Run(MainForm);

            //Application.Run(new Form1(IsTrial));

        }

        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            ((Form3)MainForm).Application_ThreadException(sender, e);
        }
    }
}
