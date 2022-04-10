
using SQLforloop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace RaporsForms
{
    
    public partial class Form1 : Form
    {

        CancellationTokenSource tokenSource2 = new CancellationTokenSource();
        

        Login LoginHandler = new Login();
        Textfile kontrol = new Textfile();
        BaglantısızRaporlar tekrar = new BaglantısızRaporlar();
        CheckDate datecheck = new CheckDate();
        CheckDateBagimsiz datecheckbagimsiz = new CheckDateBagimsiz();
        public Form3Func waitForm = new Form3Func();
        List<int> DateList1;
        List<int> endDateList1;

        Stopwatch stopWatch;
        public  List<string> sqlquery;

        //DateTime x;
        //private static System.Timers.Timer aTimer;

        //CancellationTokenSource source = new CancellationTokenSource();
        //CancellationToken token;

        //private bool _Trial;

        string[] loginDurum;
        bool tumhastaneler;
        bool tumtipmerkezleri;
        bool tumu;
        int raporcheck;
        int raporcheck2;
        string kullanıcıadı;
        string sifre;
        int dbindex;
        string maxraporcount;
        public Form1(bool IsTrial, string MaxRaporCount)
        {
            InitializeComponent();
            maxraporcount = MaxRaporCount;
            
            //if (!IsTrial)
            //{
            //    this.label3.Text = "LİSANSLI SÜRÜM";
            //    this.label3.ForeColor = Color.Blue;
            //}
            //this._Trial = IsTrial;
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            kullanıcıadı = textBox1.Text;
            sifre = textBox2.Text;
            dbindex = comboBox1.SelectedIndex;

            loginDurum = LoginHandler.LoginDB(dbindex, kullanıcıadı, sifre);
            logindisplay.Text = loginDurum[0];

            if ("Bağlantı Başarılı" == "Bağlantı Başarılı")
            {
                if (dbindex==2)
                {
                    label16.Enabled = true;
                    checkBox7.Enabled = true;
                    checkBox6.Enabled = true;
                    button12.Enabled = true;
                    
                }
                
                logindisplay.Visible = true;

                panel1.Enabled = true;
                panel1.BackColor = Color.FromArgb(0, 0, 0, 0);
                panel2.BackColor = Color.FromArgb(100, 0, 0, 0);

                if (checkBox5.Checked)
                {
                    Properties.Settings.Default.userName = kullanıcıadı;
                    Properties.Settings.Default.passUser = sifre;
                    Properties.Settings.Default.Save();
                }
            }
            else
            {
                panel1.Enabled = true;
                panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
                panel2.BackColor = Color.FromArgb(0, 0, 0, 0);

            }
        }

        internal void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            string message = e.ToString();
            string title = "HATA!";
            MessageBox.Show(message, title);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //var c = IntPtr.Size;
            //button14.Visible=false;
            label9.Visible = false;
            label15.Visible = false;
            label13.Visible = false;

            
            label12.Text = String.Format("Max Rapor Sayınız: {0}", maxraporcount);

            textBox2.PasswordChar = '*';
            stopWatch = new Stopwatch();
            if (Properties.Settings.Default.userName != string.Empty)
            {
                textBox1.Text = Properties.Settings.Default.userName;
                textBox2.Text = Properties.Settings.Default.passUser;
            }
            tumhastaneler = true;

            pictureBox1.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox2.BackColor = Color.FromArgb(0, 0, 0, 0);

            panel1.BackColor = Color.FromArgb(100, 0, 0,0);
            panel2.BackColor = Color.FromArgb(0, 0, 0, 0);

            label11.BackColor = Color.FromArgb(0, 0, 0, 0);
            label10.BackColor = Color.FromArgb(0, 0, 0, 0);
            label8.BackColor= Color.FromArgb(0, 0, 0, 0);
            label5.BackColor = Color.FromArgb(0, 0, 0, 0);
            label7.BackColor = Color.FromArgb(0, 0, 0, 0);
            label14.BackColor = Color.FromArgb(0, 0, 0, 0);
            label16.BackColor = Color.FromArgb(0, 0, 0, 0);

            checkBox1.BackColor = Color.FromArgb(0, 0, 0, 0);
            checkBox2.BackColor = Color.FromArgb(0, 0, 0, 0);
            checkBox3.BackColor = Color.FromArgb(0, 0, 0, 0);
            checkBox4.BackColor = Color.FromArgb(0, 0, 0, 0);
            checkBox6.BackColor = Color.FromArgb(0, 0, 0, 0);
            checkBox7.BackColor = Color.FromArgb(0, 0, 0, 0);

            panel1.Enabled = false;
            panel2.Enabled = false;
        }

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Multiselect = true;
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
            button10.Enabled = true;

            
            for (int i = 0; i < openFileDialog1.FileNames.Length; i++)
            {
                string[] words = openFileDialog1.FileNames[i].Split('\\');
              
                textBox3.AppendLine(words[words.Length - 1]);
            }

            if (checkBox1.Checked)
            {
                datecheck.CheckDates(openFileDialog1.FileName);

                bool datebool = datecheck.checkDATE;
                bool enddatebool = datecheck.checkENDDATE;

                if (datebool)
                {
                    label11.Enabled = true;
                    textBox6.Enabled = true;
                }

                if (enddatebool)
                {
                    label10.Enabled = true;
                    textBox5.Enabled = true;
                }
            }
            if (checkBox2.Checked)
            {
                datecheckbagimsiz.CheckDatesBagimsiz(openFileDialog1.FileNames);

                DateList1= datecheckbagimsiz.dateList;
                endDateList1 = datecheckbagimsiz.endDateList;

                if (DateList1.Count>0)
                {
                    label11.Enabled = true;
                    textBox6.Enabled = true;
                }

                if (endDateList1.Count > 0)
                {
                    label10.Enabled = true;
                    textBox5.Enabled = true;
                }

            }

            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
            if (checkBox2.Checked)
            {
                openFileDialog1.Multiselect = true;
                panel2.BackColor = Color.FromArgb(100, 0, 0, 0);
                panel2.Enabled = false;
                checkBox1.AutoCheck = true;
                checkBox2.AutoCheck = false;
                checkBox1.Checked = false;
                raporcheck = 2;
            }

            if (checkBox2.Checked & button2.Enabled)
            {
                datecheckbagimsiz.CheckDatesBagimsiz(openFileDialog1.FileNames);

                DateList1 = datecheckbagimsiz.dateList;
                endDateList1 = datecheckbagimsiz.endDateList;

                if (DateList1.Count > 0)
                {
                    label11.Enabled = true;
                    textBox6.Enabled = true;
                }

                if (endDateList1.Count > 0)
                {
                    label10.Enabled = true;
                    textBox5.Enabled = true;
                }
            }

            if ((checkBox1.Checked | checkBox2.Checked) & (checkBox4.Checked | checkBox3.Checked))
            {
                button2.Enabled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                openFileDialog1.Multiselect = false;
                panel2.BackColor = Color.FromArgb(0, 0, 0, 0);
                panel2.Enabled = true;
                checkBox2.AutoCheck = true;
                checkBox1.AutoCheck = false;
                checkBox2.Checked = false;
                raporcheck = 1;
            }

            if (checkBox1.Checked & button2.Enabled & openFileDialog1.FileName!="")
            {
                datecheck.CheckDates(openFileDialog1.FileName);

                bool datebool = datecheck.checkDATE;
                bool enddatebool = datecheck.checkENDDATE;

                if (datebool)
                {
                    label11.Enabled = true;
                    textBox6.Enabled = true;
                }

                if (enddatebool)
                {
                    label10.Enabled = true;
                    textBox5.Enabled = true;
                }

            }

            if ((checkBox1.Checked | checkBox2.Checked) & (checkBox4.Checked | checkBox3.Checked))
            {
                button2.Enabled = true;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
           
            if (checkBox4.Checked)
            {
                
                checkBox3.AutoCheck = true;
                checkBox4.AutoCheck = false;
                checkBox3.Checked = false;
                raporcheck2 = 1;
            }

            if ((checkBox1.Checked | checkBox2.Checked) & (checkBox4.Checked | checkBox3.Checked))
            {
                button2.Enabled = true;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox4.AutoCheck = true;
                checkBox3.AutoCheck = false;
                checkBox4.Checked = false;
                raporcheck2 = 2;
            }

            if ((checkBox1.Checked | checkBox2.Checked) & (checkBox4.Checked | checkBox3.Checked))
            {
                button2.Enabled = true;
            }

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        

        private void label7_Click(object sender, EventArgs e)
        {

        }

      

        private void button3_Click(object sender, EventArgs e)
        {
            if (tumhastaneler)
            {
                tumhastaneler = false;
                
                checkedListBox1.SetItemChecked(0, true);
                checkedListBox1.SetItemChecked(1, true);
                checkedListBox1.SetItemChecked(3, true);
                checkedListBox1.SetItemChecked(4, true);
                checkedListBox1.SetItemChecked(11, true);
                checkedListBox1.SetItemChecked(12, true);
                checkedListBox1.SetItemChecked(13, true);
                checkedListBox1.SetItemChecked(15, true);
                checkedListBox1.SetItemChecked(16, true);
                checkedListBox1.SetItemChecked(17, true);
                checkedListBox1.SetItemChecked(18, true);
                checkedListBox1.SetItemChecked(19, true);
                checkedListBox1.SetItemChecked(20, true);
                checkedListBox1.SetItemChecked(21, true);
                checkedListBox1.SetItemChecked(22, true);
                checkedListBox1.SetItemChecked(23, true);
            }
            else
            {
                tumhastaneler = true;
                checkedListBox1.SetItemChecked(0, false);
                checkedListBox1.SetItemChecked(1, false);
                checkedListBox1.SetItemChecked(3, false);
                checkedListBox1.SetItemChecked(4, false);
                checkedListBox1.SetItemChecked(11, false);
                checkedListBox1.SetItemChecked(12, false);
                checkedListBox1.SetItemChecked(13, false);
                checkedListBox1.SetItemChecked(15, false);
                checkedListBox1.SetItemChecked(16, false);
                checkedListBox1.SetItemChecked(17, false);
                checkedListBox1.SetItemChecked(18, false);
                checkedListBox1.SetItemChecked(19, false);
                checkedListBox1.SetItemChecked(20, false);
                checkedListBox1.SetItemChecked(21, false);
                checkedListBox1.SetItemChecked(22, false);
                checkedListBox1.SetItemChecked(23, false);
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (tumtipmerkezleri)
            {
                tumtipmerkezleri = false;
                checkedListBox1.SetItemChecked(2, true);
                checkedListBox1.SetItemChecked(5, true);
                checkedListBox1.SetItemChecked(6, true);
                checkedListBox1.SetItemChecked(7, true);
                checkedListBox1.SetItemChecked(8, true);
                checkedListBox1.SetItemChecked(9, true);
                checkedListBox1.SetItemChecked(10, true);
                checkedListBox1.SetItemChecked(14, true);
                
            }
            else
            {
                tumtipmerkezleri = true;
                checkedListBox1.SetItemChecked(2, false);
                checkedListBox1.SetItemChecked(5, false);
                checkedListBox1.SetItemChecked(6, false);
                checkedListBox1.SetItemChecked(7, false);
                checkedListBox1.SetItemChecked(8, false);
                checkedListBox1.SetItemChecked(9, false);
                checkedListBox1.SetItemChecked(10, false);
                checkedListBox1.SetItemChecked(14, false);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tumu)
            {
                tumu = false;
                tumtipmerkezleri = false;
                tumhastaneler = false;
                checkedListBox1.SetItemChecked(0, true);
                checkedListBox1.SetItemChecked(1, true);
                checkedListBox1.SetItemChecked(3, true);
                checkedListBox1.SetItemChecked(4, true);
                checkedListBox1.SetItemChecked(11, true);
                checkedListBox1.SetItemChecked(12, true);
                checkedListBox1.SetItemChecked(13, true);
                checkedListBox1.SetItemChecked(15, true);
                checkedListBox1.SetItemChecked(16, true);
                checkedListBox1.SetItemChecked(17, true);
                checkedListBox1.SetItemChecked(18, true);
                checkedListBox1.SetItemChecked(19, true);
                checkedListBox1.SetItemChecked(20, true);
                checkedListBox1.SetItemChecked(21, true);
                checkedListBox1.SetItemChecked(22, true);
                checkedListBox1.SetItemChecked(23, true);
                checkedListBox1.SetItemChecked(2, true);
                checkedListBox1.SetItemChecked(5, true);
                checkedListBox1.SetItemChecked(6, true);
                checkedListBox1.SetItemChecked(7, true);
                checkedListBox1.SetItemChecked(8, true);
                checkedListBox1.SetItemChecked(9, true);
                checkedListBox1.SetItemChecked(10, true);
                checkedListBox1.SetItemChecked(14, true);
                checkedListBox1.SetItemChecked(25, true);
                checkedListBox1.SetItemChecked(24, true);
            }
            else
            {
                tumu = true;
                tumtipmerkezleri = true;
                tumhastaneler = true;
                checkedListBox1.SetItemChecked(0, false);
                checkedListBox1.SetItemChecked(1, false);
                checkedListBox1.SetItemChecked(3, false);
                checkedListBox1.SetItemChecked(4, false);
                checkedListBox1.SetItemChecked(11, false);
                checkedListBox1.SetItemChecked(12, false);
                checkedListBox1.SetItemChecked(13, false);
                checkedListBox1.SetItemChecked(15, false);
                checkedListBox1.SetItemChecked(16, false);
                checkedListBox1.SetItemChecked(17, false);
                checkedListBox1.SetItemChecked(18, false);
                checkedListBox1.SetItemChecked(19, false);
                checkedListBox1.SetItemChecked(20, false);
                checkedListBox1.SetItemChecked(21, false);
                checkedListBox1.SetItemChecked(22, false);
                checkedListBox1.SetItemChecked(23, false);
                checkedListBox1.SetItemChecked(2, false);
                checkedListBox1.SetItemChecked(5, false);
                checkedListBox1.SetItemChecked(6, false);
                checkedListBox1.SetItemChecked(7, false);
                checkedListBox1.SetItemChecked(8, false);
                checkedListBox1.SetItemChecked(9, false);
                checkedListBox1.SetItemChecked(10, false);
                checkedListBox1.SetItemChecked(14, false);
                checkedListBox1.SetItemChecked(25, false);
                checkedListBox1.SetItemChecked(24, false);
            }
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private  void button6_Click(object sender, EventArgs e)
        {
            try
            {
                panel3.UseWaitCursor = true;
                stopWatch.Reset();
                label4.Visible = true;
                stopWatch.Start();

                if (checkBox1.Checked)
                {
                    var v = checkedListBox1.CheckedIndices;
                    string[] hast = new string[v.Count];
                    for (int i = 0; i < v.Count; i++)
                    {
                        hast[i] = (v[i] + 1).ToString();
                    }
                    kontrol.date = textBox6.Text;
                    kontrol.enddate = textBox5.Text;
                    sqlquery = kontrol.OpenTxt(openFileDialog1.FileName, hast, checkBox7.Checked);
                }
                if (checkBox2.Checked)
                {
                    tekrar.date = textBox6.Text;
                    tekrar.enddate = textBox5.Text;
                    sqlquery = tekrar.RepeatTxt(openFileDialog1, DateList1, endDateList1);
                }
                if (sqlquery.Count > Int32.Parse(maxraporcount))
                {
                    MessageBox.Show("Rapor sayınız "+ maxraporcount+"'den(dan) büyük olamaz. Sorgulamaya çalıştığınız rapor sayınız: " +sqlquery.Count, "HızlıSQL",MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    throw new ArgumentException("Max Rapor Sayısı");
                }
                
                waitForm.Show(this, waitForm);
                Program asyncSQL = new Program(loginDurum[1], sqlquery, raporcheck, raporcheck2, label4, stopWatch, waitForm);
                try
                {
                    asyncSQL.Async();
                   
                }

                catch (Exception ex)
                {

                    stopWatch.Stop();
                    string message = ex.Message;

                    string title = "Oracle Hatası!";
                    if (ex.Message == "Bir görev iptal edildi.")
                    {
                        MessageBox.Show("Rapor Başarıyla tamamlandı, Excel masa üstünde", "Rapor Tamamlandı");
                    }
                    else
                    {
                        MessageBox.Show(message, title);
                    } 
                }
                label9.Visible = true;
                label15.Visible = true;
                label13.Visible = true;
            }
            catch (Exception)
            {

              
            }

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string message = "Raporun içinde ŞUBE_KODU, P_SCHEMA, ASTORE_KODU varsa sorugulayacağınız raporlar bağlantılıdır, yoksa değillerdir.";
            string title = "Raporlar Birbiriyle Bağlantılı mı?";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string message = "Sorgulayacağınız raporların sütun sayısı ve sütun isimleri aynı ise tek bir Excel sayfasına yazabilrisiniz." ;
            string title = "Raporlar tek bir Excel sayfasına mı yazılsın?";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label4_Click_2(object sender, EventArgs e)
        {

        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (checkedListBox1.CheckedItems.Count > 0 && textBox3.Text != "")
                {
                    button6.Enabled = true;
                }
                else
                {
                    button6.Enabled = false;
                }
            }
            if (checkBox2.Checked)
            {
                if (textBox3.Text != "")
                {
                    button6.Enabled = true;
                }
                else
                {
                    button6.Enabled = false;
                }

            }
            
            TimeSpan ts = stopWatch.Elapsed;

            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}", ts.Minutes, ts.Seconds);
            label15.Text = elapsedTime;
            panel3.Enabled = true;
            panel3.UseWaitCursor = false;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            string message = "Raporun içindeki ŞUBE_KODU, P_SCHEMA, ASTORE_KODU kısımlarının hangi hastane değerlerini alacağı buradan seçilir.";
            string title = "Raporun Sorgulanacağı Hastaneleri Seçin";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }     

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            
            //label11.Enabled = false;
            textBox6.Enabled = false;

            //label10.Enabled = false;
            textBox5.Enabled = false;
            

            openFileDialog1.Reset();
            textBox3.Clear();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click_1(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            string message = "Raporun içindeki P_DATE, P_ENDDATE kısımları hangi tarih ile değiştirilsin?";
            string title = "Rapor Tarih Seçimi";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label15_Click_2(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                checkBox6.AutoCheck = true;
                checkBox7.AutoCheck = false;
                checkBox6.Checked = false;
            }

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                checkBox7.AutoCheck = true;
                checkBox6.AutoCheck = false;
                checkBox7.Checked = false;
            }


        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog(); // Shows Form2
        }
        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            string message = "KOZ, ATK, TAKSIM hastanelerinin sorgularında, tabloların sonuna @[Hastane Kısaltması]DB.WORLD (ÖRN:Kozyatağı için tabloların sonuna @KOZDB.WORLD eklenece) eklenti yapılsın mı?";
            string title = "Rapor Tarih Seçimi";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form4 SlicerForm = new Form4();
            SlicerForm.ShowDialog();
     
        }
    }
}
