using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace RaporsForms
{
    public partial class Form3 : Form
    {
        DateTime x;
        //CancellationTokenSource thread;
        Form3Func form3;

        private static System.Timers.Timer aTimer;
        public Form3(Form3Func aForm3)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            form3 = aForm3;
        }
        

        public Form3(Form parent, Form3Func aForm3)
        {
            form3 = aForm3;
            InitializeComponent();
            if (parent!=null)
            {
                this.StartPosition = FormStartPosition.Manual;
                this.Location = new Point(parent.Location.X + parent.Width / 2-this.Width/2,
                    parent.Location.Y+parent.Height/2-this.Height/2);
            }
            else
            {
                this.StartPosition = FormStartPosition.CenterParent;
            }
            
        }
        public void CloseForm3()
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
            if (label1.Image!=null)
            {
                label1.Image.Dispose();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            x = DateTime.Now;
            Control.CheckForIllegalCrossThreadCalls = false;
            aTimer = new System.Timers.Timer(1000);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }
        internal void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            string message = e.ToString();
            string title = "HATA2!";
            MessageBox.Show(message, title);
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            //if (token.IsCancellationRequested)
            //{
            //    aTimer.Enabled = false;
            //    this.Close();
            //}
            if (aTimer.Enabled == true)
            {
                var elapsedTime2 = e.SignalTime - x;
                string y = String.Format("{0:00}:{1:00}", elapsedTime2.Minutes, elapsedTime2.Seconds);
                label1.Text = y;
            }
            else
            {

            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            aTimer.Enabled = false;
            form3.Close();
            Application.Restart();
            Environment.Exit(0);
            //Thread.CurrentThread.Abort();

            //throw new InvalidOperationException("Logfile cannot be read-only");
            //thread.Cancel();


            //thread.Abort();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
