using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor da aresta do quadrado: ");
            double valorAresta = Convert.ToDouble(Console.ReadLine());

            Quadrado quadrado = new Quadrado();
            quadrado.Aresta = valorAresta;

            double area = quadrado.CalcularArea();

            Console.WriteLine($"A área do quadrado é: {area}");
        }
    }
}
