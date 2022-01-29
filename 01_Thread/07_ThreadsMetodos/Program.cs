using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _07_ThreadsMetodos
{
    class Program
    {
        static void Main(string[] args)
        {

            //Thread Sleep() = Determina quanto tempo o nosso fluxo precisa esperar para prosseguir
            Console.WriteLine("Inicio do nosso programa.");
            Thread.Sleep(3000);
            Console.WriteLine("Termino do nosso programa.");

            //Thread join = Aguarda o termino para prosseguir
            Thread t1 = new Thread(ThreadRepeticao);
            t1.Start();
            t1.Join();

            Console.WriteLine("Termino do nosso programa.");
            Console.WriteLine("Termino do nosso programa.");
            Console.WriteLine("Termino do nosso programa.");
            Console.WriteLine("Termino do nosso programa.");

            Console.ReadKey();

        }

        static void ThreadRepeticao()
        {
            for (int i = 0; i < 1000; i++)
                Console.WriteLine($"Num: {i}");

            Console.WriteLine($"DataHora Inicio {DateTime.Now}");
        }
    }
}
