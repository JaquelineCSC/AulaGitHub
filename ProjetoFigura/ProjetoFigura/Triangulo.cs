using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFigura
{
    class Triangulo:Figura
    {
        private double alturaT, baseT;

        public double AlturaT { set => alturaT = value; }
        public double BaseT { set => baseT = value; }

        public override double Area()
        {
            return alturaT * baseT / 2;
        }

    }
}
