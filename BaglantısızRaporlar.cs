using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaporsForms
{
    class BaglantısızRaporlar
    {
        public string date;
        public string enddate;
        public List<string> RepeatTxt(OpenFileDialog rapor,List<int> datelist, List<int> enddatelist)
        {
            List<string> queries = new List<string>();
            Console.WriteLine("Kaç Farklı Rapor Çekeceksiniz");

            bool birkere = true;
            bool birkere2 = true;

            //string[][] arrayoftextarrays = new string[raporcount][];
            for (int i = 0; i < rapor.FileNames.Length; i++)
            {

                string[] text = File.ReadAllLines(rapor.FileNames[i]);
                text = text.Where(x => !string.IsNullOrEmpty(x)).ToArray();
                text = text.Select(x => x.Trim()).ToArray();
                //arrayoftextarrays[i] = text;

                StringBuilder sb = new StringBuilder();


                string[] temp = text;
                for (int z = 0; z < text.Length; z++)
                {
                    temp = text;
                    if (temp[z].Contains("--"))
                    {
                        int index = Int32.Parse(temp[z].IndexOf("--") + Environment.NewLine);

                        temp[z] = temp[z].Remove(index);
                    }
                    
                }

                if (datelist.Contains(i))
                {

                    if (birkere)
                    {

                        birkere = false;
                    }
                    temp = temp.Select(x => x.Replace(":P_DATE", "'"+date+"'")).ToArray();
                    
                }
                if (enddatelist.Contains(i))
                {
                    
                    if (birkere2)
                    {

                        birkere2 = false;
                    }
                    temp = temp.Select(x => x.Replace(":P_ENDDATE", "'" + enddate+ "'" )).ToArray();
                    
                }
               
                for (int z = 0; z < temp.Length; z++)
                {
                    string temp1 = temp[z] + " ";
                    sb.Append(temp1);

                }

                queries.Add(sb.ToString());

            }
            return (queries);


        }

    }
}
