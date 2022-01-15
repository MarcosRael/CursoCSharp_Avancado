using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_LINQ_OBJ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Usuario> Usuarios = new List<Usuario>();
            Usuarios.Add(new Usuario("Jose", Convert.ToDateTime("03-09-1996"),"jose@gmail.com"));
            Usuarios.Add(new Usuario("Maria", Convert.ToDateTime("03-03-1996"), "maria@hotmail.com"));
            Usuarios.Add(new Usuario("João", Convert.ToDateTime("08-11-1991"), "joao@ig.com"));
            Usuarios.Add(new Usuario("Felipe", Convert.ToDateTime("01-01-2005"), "felipe@gmail.com"));
            Usuarios.Add(new Usuario("Elias", Convert.ToDateTime("23-12-1999"), "elias@gmail.com"));

            var usuariosFiltrada = Usuarios.Where(a => a.Email.Contains("@gmail.com"));

            foreach (var usuario in usuariosFiltrada)
            {
                Console.WriteLine($"Nome: {usuario.Nome}, " +
                                  $"Data Nascimento:{usuario.DataNascimento.ToString("d")}, " +
                                  $"Idade: {usuario.Idade}, " +
                                  $"Email: {usuario.Email}.");
            }

            Console.ReadKey();
            
        }
    }
}
