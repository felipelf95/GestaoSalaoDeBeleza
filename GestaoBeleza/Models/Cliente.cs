using System;


namespace GestaoBeleza.Models.Cliente
{
    public class Cliente : Pessoa
    {
        
        public int ClienteId { get; set; }
        public string Instagram { get; set; }
        public string Facebook { get; set; }

        public Cliente(int clienteId, string nome, string sexo, DateTime dataNascimento, string telefone, string email, string instagram, string facebook, string cpf, int enderecoId, string cep, string logradouro, string bairro, string cidade, string estado, string numeroCasa, string complemento)
            : base(nome, sexo, dataNascimento, telefone, email, cpf, enderecoId, cep, logradouro, bairro, cidade, estado, numeroCasa, complemento)
        {
            ClienteId = clienteId;
            Instagram = instagram;
            Facebook = facebook;
        }
    }
}
