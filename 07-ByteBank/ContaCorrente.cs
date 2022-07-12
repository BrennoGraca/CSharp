namespace _07_ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }

        public static int TotalDeContasCriadas{ get; private set; }

        public int Numero { get; set; }

        private double _saldo = 100.0;
        private int _agencia;

        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
        }

        public int Agencia
        {
            get
            {
                return _agencia;
            }
            set
            {
                if (value <= 0)
                    return;

                _agencia = value;
            }
        }

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                //value represents the parameter saldo sent to the SetSaldo Method
                if (value < 0)
                    return;

                _saldo = value;
            }
        }

        /*
        //To simplify the development process we can use the getters and setters default
        public void SetSaldo(double saldo)
        {
            if(this.saldo < 0)
            {
                return;
            }
            
            this.saldo = saldo;
        }

        public double GetSaldo()
        {
            return saldo;
        }
        */

        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                _saldo += valor;
            }
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}
