using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //  LINQ E LAMBDA
            // LAMBDA - (ENTRADA => (EXPRESSÃO)

            int[] lista = { 3, 9, 4, 6, 20, 10, 60, 90, 80, 50 };

            //var listaFilrtada = lista.Where(a => a > 6).OrderByDescending(a => a).Select(a => a);

            var listaFilrtada = from a in lista where a > 10 orderby a select a;

            foreach (var index in listaFilrtada)
                Console.WriteLine(index);

            Console.ReadKey();

        }
    }
}
