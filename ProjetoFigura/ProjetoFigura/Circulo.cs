using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFigura
{
    class Circulo:Figura
    {
        private double raio;

        public double Raio { get => raio; set => raio = value; }

        public override double Area()
        {
           return 3.14 * Math.Pow(raio, 2);
        }

    }   
}
