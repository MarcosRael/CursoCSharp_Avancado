using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using _00_Biblioteca;
using System.Xml.Serialization;

namespace _01_SerializarXML
{
    class Program
    {
        static void Main(string[] args)
        {
            string diretorioXML = @"C:\Projetos\Treinamentos\Cursos\CursoCSharp_Avancado\Diretorio\01_SerializarXML.xml";

            Usuario usuario = new Usuario() { 
                Nome = "Jose", 
                CPF = "222.222.222-22", 
                Email = "jose@gmail.com" };

            XmlSerializer serializador = new XmlSerializer(typeof(Usuario));
            //XmlSerializer serializador = new XmlSerializer(usuario.GetType()); Pode ser assim também

            StreamWriter stream = new StreamWriter(diretorioXML); 

            serializador.Serialize(stream, usuario);

        }
    }
}
