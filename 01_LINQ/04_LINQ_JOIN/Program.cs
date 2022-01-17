﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_LINQ_JOIN
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Autor> listaAutor = new List<Autor>();
            listaAutor.Add( new Autor() { Id = 1, Nome = "Russel Crown" });
            listaAutor.Add( new Autor() { Id = 2, Nome = "Maria Maria" });
            listaAutor.Add( new Autor() { Id = 3, Nome = "Joseph" });

            List<Livro> listaLivro = new List<Livro>();
            listaLivro.Add( new Livro() { Id = 1, AutorId = 2, Titulo = "Amor Amado" });
            listaLivro.Add( new Livro() { Id = 2, AutorId = 2, Titulo = "Bem Amado" });
            listaLivro.Add( new Livro() { Id = 3, AutorId = 3, Titulo = "Um espião em Washigton" });
            listaLivro.Add( new Livro() { Id = 4, AutorId = 1, Titulo = "Vida da Terra" });

            var ListaJoin = from livros in listaLivro join autor in listaAutor
                            on livros.AutorId equals autor.Id
                            select new {livros, autor};
            
            foreach(var item in ListaJoin)
                Console.WriteLine($"Livro: {item.livros.Titulo} - Autor: {item.autor.Nome}");

            Console.ReadKey();
            
        }
    }
}
