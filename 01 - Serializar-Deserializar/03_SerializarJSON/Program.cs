using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using _00_Biblioteca;
using System.IO;

namespace _03_SerializarJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            string diretorioJSON = @"C:\Projetos\Treinamentos\Cursos\CursoCSharp_Avancado\Diretorio\03_SerializarJSON.json";

            Usuario usuario = new Usuario()
            {
                Nome = "Maria",
                CPF = "333.333.333-33",
                Email = "maria@hotmail.com"
            };

            JavaScriptSerializer serializador = new JavaScriptSerializer();
            string stringObjSerializador = serializador.Serialize(usuario);

            StreamWriter sw = new StreamWriter(diretorioJSON);
            
            sw.WriteLine(stringObjSerializador);
            sw.Close();

        }
    }
}
