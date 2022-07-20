using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Documento: IAcesso, IComprimir
    {
        public void Ler()
        {
            Console.WriteLine("Executando o método Ler da classe Documento para IAcesso");
        }

        public void Escrever()
        {
            Console.WriteLine("Executando o método Escrever da classe Documento para IAcesso");
        }

        public void Comprimir()
        {
            Console.WriteLine("Executando o método Comprimir da classe Documento para IComprimir");
        }

        public void Descomprimir()
        {
            Console.WriteLine("Executando o método Descomprimir da classe Documento para IComprimir");
        }
    }
}
