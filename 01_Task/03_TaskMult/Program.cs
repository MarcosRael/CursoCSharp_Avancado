using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace _03_TaskMult
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Task> listaTask = new List<Task>();

            listaTask.Add(Task.Factory.StartNew(Metodo01));
            listaTask.Add(Task.Factory.StartNew(Metodo01));
            listaTask.Add(Task.Factory.StartNew(Metodo01));
            listaTask.Add(Task.Factory.StartNew(Metodo01));

            Task.WaitAll(listaTask.ToArray());

            string[] enderecos = new string[]
            {
                "http://www.google.com.br",
                "http://www.microsoft.com.br",
                "http://www.g1.com.br"
            };

            var listEnd = from end in enderecos select DownloadPagina(end);

            Task.WaitAll(listEnd.ToArray());

            Console.WriteLine("Programa finalizado!");
            Console.ReadKey();
        }

        static void Metodo01()
        {
            for (int i = 0; i < 1000; i++)
                Console.WriteLine($"Valor: {i}, ID Task: {Task.CurrentId}");
        }

        static async Task DownloadPagina(string end)
        {
            WebClient web = new WebClient();

            string html = await web.DownloadStringTaskAsync(end);

            Console.WriteLine($"Download realizado para a página: {end}");
        }
    }
}
