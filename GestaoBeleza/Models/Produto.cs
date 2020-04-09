

using System;
using System.Collections.Generic;

namespace GestaoBeleza.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }
        public DateTime Validade { get; set; }
        public int Quantidade { get; set; }
        
        /*
        public void AddProduct (int quantidade )
        {
            Quantidade += quantidade;
        }

        public void RemoveProduct(int quantidade)
        {
            Quantidade -= quantidade;
        }
        */


    }
}
