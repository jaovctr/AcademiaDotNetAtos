using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaListaEx8
{

    internal class Asteroide
    {
        private double pos_x,pos_y;
        private int tamanho;
        private int velocidade;
        private int energia;

        public double Pos_x { get => pos_x; set => pos_x = value; }
        public double Pos_y { get => pos_y; set => pos_y = value; }
        public int Tamanho { get => tamanho; set => tamanho = value; }
        public int Velocidade { get => velocidade; set => velocidade = value; }
        public int Energia { get => energia; set => energia = value; }

        public Asteroide() { }

        public Asteroide(Asteroide a)
        {
            Pos_x = a.Pos_x;
            Pos_y = a.Pos_y;
            Tamanho = a.Tamanho;
            Velocidade = a.Velocidade;
            Energia = a.energia;

        }

        public Asteroide(double pos_x,double pos_y)
        {
            Pos_x = pos_x;
            Pos_y = pos_y;
        }

    }
}
