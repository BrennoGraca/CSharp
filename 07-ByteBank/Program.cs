using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(867, 86712540);
            //ContaCorrente.TotalDeContasCriadas++; 

            Console.WriteLine("Agência: " + conta.Agencia);
            Console.WriteLine("Conta: " + conta.Numero);

            ContaCorrente contaDaGabriela = new ContaCorrente(867, 86712520);
            //ContaCorrente.TotalDeContasCriadas++;

            Console.WriteLine("Agência: {0} e Conta: {1}", contaDaGabriela.Agencia, contaDaGabriela.Numero);

            Console.WriteLine("Total de contas criadas: " + ContaCorrente.TotalDeContasCriadas);

            Console.ReadLine();
        }
    }
}
