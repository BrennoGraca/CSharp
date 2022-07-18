using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Funcionario
    {
        //0 - funcionario
        //1 - diretor
        //2 - designer
        //3 - gerente de conta corrente
        //4 - coordernador
        //N...
        private int _tipo;
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }

        public double GetBonificacao()
        {
            return Salario * 0.10;
        }
    }
}
