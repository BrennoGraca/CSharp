using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGrabriela = new ContaCorrente();

            contaDaGrabriela.titular = "Gabriela";
            contaDaGrabriela.agencia = 863;
            contaDaGrabriela.numero = 863452;

            ContaCorrente contaDaGrabrielaCosta = new ContaCorrente();
            contaDaGrabrielaCosta.titular = "Gabriela Costa";
            contaDaGrabrielaCosta.agencia = 863;
            contaDaGrabrielaCosta.numero = 863452;

            Console.WriteLine(contaDaGrabriela == contaDaGrabrielaCosta);

            contaDaGrabrielaCosta = contaDaGrabriela;

            Console.WriteLine(contaDaGrabriela == contaDaGrabrielaCosta);

            contaDaGrabriela.saldo = 300;
            Console.WriteLine(contaDaGrabriela.saldo);
            Console.WriteLine(contaDaGrabrielaCosta.saldo);

            Console.ReadLine();
        }
    }
}
