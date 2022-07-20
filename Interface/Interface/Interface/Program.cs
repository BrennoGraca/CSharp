using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            IAcesso oAcesso = new Documento();
            oAcesso.Ler();
            oAcesso.Escrever();

            IComprimir oComprimir = new Documento();
            oComprimir.Comprimir();
            oComprimir.Descomprimir();

            Console.ReadLine();
        }
    }
}
