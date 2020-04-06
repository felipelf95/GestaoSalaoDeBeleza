using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestaoBeleza.Models.Cliente
{
    public class Cliente : Pessoa
    {
        [Key]
        public int ClienteId { get; set; }
        public string Instagram { get; set; }
        public string Facebook { get; set; }

        //[ForeignKey("Endereco")]
        //public int EnderecoId { get; set; }
        //public virtual Endereco Endereco { get; set; }

        [ForeignKey("InformacaoTecnica")]
        public int InformacaoTecnicaId { get; set; }
        public virtual InformacaoTecnica InformacaoTecnica { get; set; }

        
        public Cliente(int clienteId, string nome, string sexo, DateTime dataNascimento, string telefone, string email, string instagram, string facebook, string cpf, int enderecoId, string cep, string logradouro, string bairro, string cidade, string estado, string numeroCasa, string complemento)
            : base(nome, sexo, dataNascimento, telefone, email, cpf, enderecoId, cep, logradouro, bairro, cidade, estado, numeroCasa, complemento)
        {
            ClienteId = clienteId;
            Instagram = instagram;
            Facebook = facebook;
        }
    }
}
