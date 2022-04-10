using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RaporsForms
{
    public class Form3Func
    {
        Form3 wait;
        Thread loadthread;
        Form3Func form3;

        public void Show()
        {
            loadthread = new Thread(new ThreadStart(LoadingProcess));
            loadthread.Start();
            
        }

        public void Show(Form1 parent, Form3Func aForm3)
        {
            form3 = aForm3;
            loadthread = new Thread(new ParameterizedThreadStart(LoadingProcess));
            loadthread.Start(parent);
        }
        public void Close()   
        {
            
            if (wait!=null)
            {
                wait.BeginInvoke(new ThreadStart(wait.CloseForm3));
                wait = null;
                loadthread = null;

            }
        }
        private void LoadingProcess()
        {
            wait = new Form3(form3);
            wait.ShowDialog();
        }
        private void LoadingProcess(object parent)
        {
            Form3 parent1 = parent as Form3;
            wait = new Form3(parent1, form3);
            wait.ShowDialog();
        }
    }
}
