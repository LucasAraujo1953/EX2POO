using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2POO
{
    internal class Quadrado
    {
        private double aresta;

        public double Aresta
        {
            get { return aresta; }
            set { aresta = value; }
        }

        public double CalcularArea()
        {
            return aresta * aresta;
        }
    }
}
