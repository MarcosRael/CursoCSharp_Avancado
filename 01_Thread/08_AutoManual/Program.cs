using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _08_AutoManual
{
    class Program
    {
        static AutoResetEvent auto01;
        static ManualResetEvent manual01;

        static void Main(string[] args)
        {
            manual01 = new ManualResetEvent(false);
            auto01 = new AutoResetEvent(false);

            Thread t1 = new Thread(Executa01);
            t1.Start();

            Thread t2 = new Thread(Executa02);
            t2.Start();


            Thread.Sleep(5000);
            manual01.Set();
            manual01.Reset();

            auto01.Set();

            Thread.Sleep(5000);
            manual01.Set();
            auto01.Set();

            Console.ReadKey();

        }


        static void Executa01()
        {
            Console.WriteLine("01 - Iniciado Execuçãoc 01.");
            manual01.WaitOne();
            Console.WriteLine("02 - Em execução 01 01.");
            Console.WriteLine("03 - Em execução 02 01.");
            manual01.WaitOne();
            Console.WriteLine("04 - Finalizado 01.");
        }
        
        static void Executa02()
        {
            Console.WriteLine("01 - Iniciado Execução 02.");
            auto01.WaitOne();
            Console.WriteLine("02 - Em execução 01 02.");
            Console.WriteLine("03 - Em execução 02 02.");
            auto01.WaitOne();
            Console.WriteLine("04 - Finalizado 02.");
        }


    }
}
