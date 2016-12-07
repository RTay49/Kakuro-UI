using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KakuroUI
{
    class Writer
    {
        
        public Writer(List<String> bS, List<String> aS, List<String> dS)
        {
            
            write(bS,aS,dS);
        }

        private void write(List<String> bS, List<String> aS, List<String> dS)
        {
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"C:\Users\Public\Specfiles\spec.pl"))
            {
                file.WriteLine("% black(R, C).");
                foreach(String str in bS)
                {
                    file.WriteLine(str);
                }
                file.WriteLine("\n% across(R, C, L, S)");
                foreach (String str in aS)
                {
                    file.WriteLine(str);
                }
                file.WriteLine("\n% down(R, C, L, S)");
                foreach (String str in dS)
                {
                    file.WriteLine(str);
                }
                file.Close();
            }
        }

        }
}
