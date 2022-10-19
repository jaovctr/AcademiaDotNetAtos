using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaListaEx8
{

    internal class ObjetoNoPlano
    {
        double pos_x, pos_y;

        public double Pos_x { get => pos_x; set => pos_x = value; }
        public double Pos_y { get => pos_y; set => pos_y = value; }

        public ObjetoNoPlano() { }
        public ObjetoNoPlano(double pos_x, double pos_y)
        {
            Pos_x = pos_x;
            Pos_y = pos_y;
        }
    }
}
