using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoBeleza.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string NumeroCasa { get; set; }
        public string Complemento { get; set; }

        public Pessoa(string nome, string sexo, DateTime dataNascimento, string telefone, string email, string cpf, string cep, string logradouro, string bairro, string cidade, string estado, string numeroCasa, string complemento)
        {
            Nome = nome;
            Sexo = sexo;
            DataNascimento = dataNascimento;
            Telefone = telefone;
            Email = email;
            Cpf = cpf;
            Cep = cep;
            Logradouro = logradouro;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            NumeroCasa = numeroCasa;
            Complemento = complemento;
        }
    }
}
