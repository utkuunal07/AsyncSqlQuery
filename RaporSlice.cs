using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaporsForms
{
    class RaporSlice
    {
        List<int> ayracIndex = new List<int>();
        public void SliceTxt(string yer,string ayrac,bool include)
        {
            string[] text = File.ReadAllLines(yer);
            text = text.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            text = text.Select(x => x.Trim()).ToArray();


            for (int f = 0; f < text.Length; f++)
            {
                if (text[f].Contains("--"))
                {
                    int index = Int32.Parse(text[f].IndexOf("--") + Environment.NewLine);

                    text[f] = text[f].Remove(index);
                }
               
            }

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].Contains(ayrac))
                {
                    ayracIndex.Add(i);
                }
            }

            for (int i = 0; i < ayracIndex.Count-1; i++)
            {

                IEnumerable<int> squares = Enumerable.Range(ayracIndex[i], ayracIndex[i+1]);




            }            


        }
    }
}
