using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web.Script.Serialization;

namespace _01_Generics
{
    class Serializador
    {

        private const string diretorio =
               @"C:\Projetos\Treinamentos\Cursos\CursoCSharp_Avancado\Diretorio\";

        public static void Serializar(object obj)
        {
            StreamWriter sw = new StreamWriter(diretorio + obj.GetType().Name + ".json");

            JavaScriptSerializer serializador = new JavaScriptSerializer();
            string objSerializado = serializador.Serialize(obj);

            sw.Write(objSerializado);
            sw.Close();

        }

        public static T Deserializar<T>()
        {
            StreamReader sr = new StreamReader(diretorio + typeof(T).Name + ".json");

            string conteudo = sr.ReadToEnd();

            JavaScriptSerializer deselizador = new JavaScriptSerializer();

            return (T) deselizador.Deserialize(conteudo, typeof(T));

        }

    }
}
