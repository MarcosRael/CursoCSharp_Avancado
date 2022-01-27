using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _03_ThreadBackground
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"DataHora Inicio {DateTime.Now}");

            for (int i = 0; i < 5; i++)
            {
                Thread t1 = new Thread(ThreadRepeticao);
                t1.IsBackground = true; //Serve para finalizar a Thread quando o fluxo pricipal ser interrompido
                t1.Start();
            }

            Console.WriteLine("Programa Finalizado");
            //Console.ReadKey();
        }

        //IO - Tela(Monitor), Rede, Armazenamento
        static void ThreadRepeticao()
        {
            for (int i = 0; i < 1000; i++)
                Console.WriteLine($"Num: {i}");

            Console.WriteLine($"DataHora Inicio {DateTime.Now}");
        }
    }
}
