using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaporsForms
{
    class CheckDate
    {
        public bool checkDATE;
        public bool checkENDDATE;

        public void CheckDates(string adres)
        {
            string[] text = File.ReadAllLines(adres);
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
                    checkDATE = temp[f].Contains(":P_DATE");
                }

                if (checkENDDATE == false)
                {
                    checkENDDATE = temp[f].Contains(":P_ENDDATE");
                }
            }
        }
    }
}
