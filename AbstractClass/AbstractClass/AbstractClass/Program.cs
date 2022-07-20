using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Quadrado q = new Quadrado();

            Console.Write("Informe o valor do lado do quadrado em metros: ");
            q.Lado = Convert.ToInt32(Console.ReadLine());

            q.CalcularArea();
            q.CalcularPerimetro();

            Console.WriteLine("A área do quadrado é de {0} m²", q.Area);
            Console.WriteLine("O perímetro do quadrado é de {0} m²", q.Perimetro);

            Console.ReadLine();
        }
    }
}
