using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaListaEx11
{
    internal class GerenciaCripto
    {
        List<Criptomoeda> criptos = new List<Criptomoeda>();

        public GerenciaCripto()
        {

        }

        public void AdicionarCripto(Criptomoeda c)
        {
            if (CriptoNaLista(c))
            {
                MessageBox.Show("Moeda já cadastrada");
            } 
            else if(!c.IsNull()){
                AdicionarNaLista(c);
            }
        }
        
        private void AdicionarNaLista(Criptomoeda c)
        {
            if (!CriptoNaLista(c))
            {
                criptos.Add(c);
            }
        }
        
        private bool CriptoNaLista(Criptomoeda c)
        {
            foreach (var moeda in criptos)
            {
                if (moeda.Sigla.Equals(c.Sigla))
                {
                    return true;
                }
            }
            return false;
        }

        public List<Criptomoeda> retornaLista()
        {
            return criptos;
        }

        public void RemoverCripto(string sigla)
        {
            if(CriptoNaLista(new Criptomoeda(null, sigla, 0)))
            {
                foreach(var cripto in criptos){
                    if (cripto.Sigla.Equals(sigla))
                    {
                        criptos.Remove(cripto);
                        MessageBox.Show("Moeda apagada!");
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Moeda não encontrada");
            }
        }

    }
}
