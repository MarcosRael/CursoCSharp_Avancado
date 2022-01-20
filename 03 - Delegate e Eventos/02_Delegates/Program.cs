using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_Delegates.Lib;

namespace _02_Delegates
{
    class Program
    {
        static void Main(string[] args)
        {

            //Tela - Cadastro de Usuario: Thumb (Foto de Perfil)
            Foto foto1 = new Foto() { Nome = "perfil.jpg", TamanhoX = 1920, TamanhoY = 1080 };
            FotoProcessador.filtros = new FotoFiltro().GerarThumb;
            FotoProcessador.Processador(foto1);

            //Tela - Cadastro de Produtos: Colorir + TamanhoMed
            Foto foto2 = new Foto() { Nome = "produto.jpg", TamanhoX = 1920, TamanhoY = 1080 };
            FotoProcessador.filtros = new FotoFiltro().Colorir;
            FotoProcessador.filtros += new FotoFiltro().RedimensionarTamMedio;
            FotoProcessador.Processador(foto2);

            //Tela - Cadastro de Albuns do Usuario - Retro: Preto e Branco
            Foto foto3 = new Foto() { Nome = "Album.jpg", TamanhoX = 1920, TamanhoY = 1080 };
            FotoProcessador.filtros = new FotoFiltro().PretoBranco;
            FotoProcessador.Processador(foto3);

            Console.ReadKey();
        }
    }
}
