using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_LINQ_OBJ
{
    class Usuario
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }

        public Usuario(string nome, DateTime dataNascimento ,string email)
        {
            this.Nome = nome;
            this.Email = email;
            this.DataNascimento = dataNascimento;
            this.Idade = DateTime.Now.Year - dataNascimento.Year;
        }


    }
}
