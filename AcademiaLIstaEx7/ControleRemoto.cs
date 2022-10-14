using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaListaEx7
{
    internal class ControleRemoto
    {
        Televisao tv = new Televisao();
        public void SubirCanal()
        {
            tv.Canal++;
            Console.WriteLine("Canal atual: " + tv.Canal);
        }
        public void DiminuirCanal()
        {
            tv.Canal--;
            Console.WriteLine("Canal atual: " + tv.Canal);
        }
        public void EscolherCanal(int canal)
        {
            tv.Canal=canal;
            Console.WriteLine("Canal atual: "+ tv.Canal);
        }

        public void CanalAtual()
        {
            Console.WriteLine("Canal :" + tv.Canal);
        }

        public void AumentarVolume()
        {
            tv.Volume++;
            Console.WriteLine("Volume atual: "+ tv.Volume);
        }
        public void DiminuirVolume()
        {
            tv.Volume--;
            Console.WriteLine("Volume atual: " + tv.Volume);
        }
        
        public void VolumeAtual()
        {
            Console.WriteLine("Volume: "+tv.Volume);
        }
        public void BotaoLigar()
        {
            if (!tv.Ligado)
            {
                tv.Ligado = true;
                Console.WriteLine("Ligada");
            }
            else
            {
                tv.Ligado = false;
                Console.WriteLine("Desligada");
            }

        }

    }
}
