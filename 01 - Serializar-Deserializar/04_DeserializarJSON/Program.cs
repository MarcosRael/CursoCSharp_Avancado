using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.IO;
using _00_Biblioteca;

namespace _04_DeserializarJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            string diretorioJSON = @"C:\Projetos\Treinamentos\Cursos\CursoCSharp_Avancado\Diretorio\03_SerializarJSON.json";

            StreamReader stream = new StreamReader(diretorioJSON);
            string linhasDoArquivo = stream.ReadToEnd();

            JavaScriptSerializer deserializador = new JavaScriptSerializer();
            Usuario usuario = (Usuario) deserializador.Deserialize(linhasDoArquivo, typeof(Usuario));

            Console.WriteLine(
                "Usuario(Nome): {0}, CPF: {1}, Email: {2}",
                usuario.Nome, usuario.CPF, usuario.Email);

            Console.ReadKey();

        }
    }
}
