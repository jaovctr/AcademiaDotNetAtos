using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaListaEx7
{   /*O supermercado vende diferentes	tipos de produtos.
     * Cada	produto	tem	um preço e uma quantidade em estoque.
     * Um pedido de	um cliente é composto de itens,	onde cada item especifica o produto	que	o cliente deseja e a
     * respectiva quantidade. Esse pedido pode ser pago	em dinheiro, cheque ou cartão."
     */
    internal class Supermercado
    {
        public List<Produto> produtos = new List<Produto>();
        public List<Pedido> pedidos = new List<Pedido>();
       
        
        
        public void CadastraProduto(Produto p)
        {
            produtos.Add(p);
        }
        public void listarProdutos()
        {
            foreach (Produto p in produtos)
            {
                Console.WriteLine(produtos.IndexOf(p)+" "+p.Descricao +" "+p.Preco);
            }
        }

        public void Vendeu(Pedido p)
        {
            pedidos.Add(p);
        }

    }
}
