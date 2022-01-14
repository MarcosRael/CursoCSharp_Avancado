using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ExtensionMethods //É possivel colocar no namespace System para não precisar importar sempre
{
    public static class StringExtension //: String  -> Não pode ser herdada pq é uma classe Sealed
    {

        public static string FirstToupper(this String str)
        {
            string[] palavras = str.Split(' ');
            string res = string.Empty;

            foreach (var pv in palavras)
            {
                string p1 = pv.Substring(0, 1).ToUpper();
                string p2 = pv.Substring(1).ToLower();

                res += p1 + p2 + " ";
            }
            
            return res;
        }

    }
}
