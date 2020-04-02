using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoBeleza.Models
{
    public class Funcionario : Pessoa
    {
        public int FuncionarioId { get; set; }
        public DateTime DataContratacao { get; set; }
        public double Salario { get; set; }
        public string Cargo { get; set; }
        public string Certificados { get; set; }

        public Funcionario(string nome, string sexo, DateTime dataNascimento, string telefone, string email, string cpf,int enderecoId, string cep, string logradouro, string bairro, string cidade, string estado, string numeroCasa, string complemento, int funcionarioId, DateTime dataContratacao, double salario, string cargo, string certificados)
            : base(nome, sexo, dataNascimento, telefone, email, cpf, enderecoId, cep, logradouro, bairro, cidade, estado, numeroCasa, complemento)
        {
            FuncionarioId = funcionarioId;
            DataContratacao = dataContratacao;
            Salario = salario;
            Cargo = cargo;
            Certificados = certificados;
        }


    }
}
