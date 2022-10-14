using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaListaEx7
{
    internal class Pedido
    {
        public Cliente Cliente { get; set; }
        public List<Produto> Itens { get; set; }
        public string TipoPagamento { get; set; }
        public Pedido(Cliente c, List<Produto> itens, string tipoPagamento)
        {
            Cliente = c;
            Itens = itens;
            TipoPagamento = tipoPagamento;
        }
    }
}
