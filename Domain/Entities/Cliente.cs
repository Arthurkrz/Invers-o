using System;
using System.Collections.Generic;
using System.Text;

namespace Inversão.Domain.Entities
{
    internal class Cliente
    {
        public Cliente(string nome, string email, string cpf, int idade)
        {
            this.Nome = nome;
            this.Email = email;
            this.CPF = cpf;
            this.Idade = idade;
        }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public int Idade { get; set; }
        public int ID { get; set; }
    }
}
