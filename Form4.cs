using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaporsForms
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Multiselect = true;
            openFileDialog1.ShowDialog();
  
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            for (int i = 0; i < openFileDialog1.FileNames.Length; i++)
            {
                string[] words = openFileDialog1.FileNames[i].Split('\\');
                textBox3.AppendLine(words[words.Length - 1]);
            }

       
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Reset();
            textBox3.Clear();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            RaporSlice slicer = new RaporSlice();
            slicer.SliceTxt(openFileDialog1.FileName, textBox1.Text,checkBox1.Checked);
        }
    }
}
