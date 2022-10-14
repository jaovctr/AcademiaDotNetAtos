using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaListaEx7
{ 
    internal class Produto
    {
 
        public string Descricao { get ; set ; }
        public double Preco { get ; set; }
        public int QuantEstoque { get; set; }

        public Produto(string descricao, double preco, int quantEstoque)
        {
           
            this.Descricao = descricao;
            this.Preco = preco;
            this.QuantEstoque = quantEstoque;
        }
        
        public void vendeuProduto(int quant)
        {
            QuantEstoque -= quant;
           
        }
    }
}
