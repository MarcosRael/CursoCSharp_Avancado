using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Não aceita null - por valor
            //ERRO: int i = null;

            //Class - por referencia
            object o = null;

            //MySQL - Oracle - PostGreeSQL .... NoSQL - Informações opcionais
            //ERRO: byte = null;
            Nullable<byte> IdadeA = null;
            byte? IdadeB = null; //Também pode ser representado dessa maneira

        }
    }
}
