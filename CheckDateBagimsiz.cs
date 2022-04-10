using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaporsForms
{
    class CheckDateBagimsiz
    {
      
        public List<int> dateList = new List<int>();
        public List<int> endDateList = new List<int>();
        public void CheckDatesBagimsiz(string[] adresler)
        {
            for (int i = 0; i < adresler.Length; i++)
            {
                bool checkDATE = false;
                bool checkENDDATE = false;
                string[] text = File.ReadAllLines(adresler[i]);
                text = text.Where(x => !string.IsNullOrEmpty(x)).ToArray();
                text = text.Select(x => x.Trim()).ToArray();

                string[] temp = text;
                for (int f = 0; f < temp.Length; f++)
                {
                    temp = text;

                    if (temp[f].Contains("--"))
                    {
                        int index = Int32.Parse(temp[f].IndexOf("--") + Environment.NewLine);

                        temp[f] = temp[f].Remove(index);
                    }
                    if (checkDATE == false)
                    {
                        checkDATE = temp[f].Contains("P_DATE");
                    }

                    if (checkENDDATE == false)
                    {
                        checkENDDATE = temp[f].Contains("P_ENDDATE");
                    }
                    
                }
                if (checkDATE)
                {
                    dateList.Add(i);
                }
                if (checkENDDATE)
                {
                    endDateList.Add(i);
                }
            }   
        }
    }
}
