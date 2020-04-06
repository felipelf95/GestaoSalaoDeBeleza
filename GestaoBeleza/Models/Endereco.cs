
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestaoBeleza.Models
{
    public class Endereco
    {
        [Key]
        public int EnderecoId { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string NumeroCasa { get; set; }
        public string Complemento { get; set; }

       
        public Endereco(int enderecoId, string cep, string logradouro, string bairro, string cidade, string estado, string numeroCasa, string complemento)
        {
            EnderecoId = enderecoId;
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
