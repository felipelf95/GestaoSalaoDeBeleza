using System;


namespace GestaoBeleza.Models
{
    public class Pessoa : Endereco
    {
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        

        public Pessoa(string nome, string sexo, DateTime dataNascimento, string telefone, string email, string cpf,int enderecoId, string cep, string logradouro, string bairro, string cidade, string estado, string numeroCasa, string complemento)
            :base (enderecoId,cep,logradouro,bairro,cidade,estado,numeroCasa,complemento)
        {
            Nome = nome;
            Sexo = sexo;
            DataNascimento = dataNascimento;
            Telefone = telefone;
            Email = email;
            Cpf = cpf;
        }
    }
}
