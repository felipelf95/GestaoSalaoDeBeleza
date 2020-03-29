using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoBeleza.Models.Cliente
{
    public class Cliente : Pessoa
    {
        public string Instagram { get; set; }
        public string Facebook { get; set; }

        public Cliente(string nome, string sexo, DateTime dataNascimento, string telefone, string email,string instagram, string facebook, string cpf, string cep, string logradouro, string bairro, string cidade, string estado, string numeroCasa, string complemento)
            : base(nome,sexo,dataNascimento,telefone,email,cpf,cep,logradouro,bairro,cidade,estado,numeroCasa,complemento)
        {
            Instagram = instagram;
            Facebook = facebook;
        }
    }
}
