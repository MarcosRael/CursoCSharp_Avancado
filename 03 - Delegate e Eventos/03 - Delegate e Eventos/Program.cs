using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Delegate_e_Eventos
{
    class Program
    {
        delegate int Calcula(int a, int b);

        static void Main(string[] args)
        {
            //var so = Soma(10, 20);
            //var su = Subtrair(20, 10);

            Calcula calc1 = new Calcula(Soma);
            var so = calc1(10, 20);

            Calcula calc2 = new Calcula(Subtrair);
            var su = calc2(20, 10);

            Console.WriteLine($"Soma: {so}, Sub: {su}");
            Console.ReadKey();

        }

        static int Soma(int a, int b)
        {
            return a + b;
        }

        static int Subtrair(int a, int b)
        {
            return a - b;
        }
    }
}
