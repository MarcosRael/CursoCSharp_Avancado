using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _00_Biblioteca;
using System.Xml.Serialization;
using System.IO;

namespace _02_DeserializarXML
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlSerializer serializador = new XmlSerializer(typeof(Usuario));
            string diretorioXML = @"C:\Projetos\Treinamentos\Cursos\CursoCSharp_Avancado\Diretorio\01_SerializarXML.xml";

            StreamReader stream = new StreamReader(diretorioXML);

            Usuario usuario = (Usuario) serializador.Deserialize(stream);

            Console.WriteLine("Usuario(Nome): {0}", usuario.Nome);
            Console.WriteLine("CPF: {0}", usuario.CPF);
            Console.WriteLine("Email: {0}", usuario.Email);
            Console.ReadKey();

        }
    }
}
