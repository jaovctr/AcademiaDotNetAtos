using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaListaEx9
{

    internal class Figurinha
    {
        private string codigo_figurinha;
        private string selecao;
        private string nome_jogador;

        public string Codigo_figurinha { get => codigo_figurinha; set => codigo_figurinha = value; }
        public string Selecao { get => selecao; set => selecao = value; }
        public string Nome_jogador { get => nome_jogador; set => nome_jogador = value; }

        public Figurinha(string codigo_figurinha, string selecao, string nome_jogador)
        {
            Codigo_figurinha = codigo_figurinha;
            Selecao = selecao;
            Nome_jogador = nome_jogador;
            
        }
    }
}
