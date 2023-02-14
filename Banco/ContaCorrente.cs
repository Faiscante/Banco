using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class ContaCorrente : Conta, ITributavel
    {
        public override void Saca(double valor)
        {
            base.Saca(valor + 0.05);
        }

        public override void Deposita(double valor)
        {
            base.Deposita(valor - 0.10);
        }

        public double CalculaTributos()
        {
            return this.Saldo * 0.05;
        }
      
        private static int totalDeContas = 0;
        public ContaCorrente()
        {
            ContaCorrente.totalDeContas++;
        }
        public static int ProximaConta()
        {
            return ContaCorrente.totalDeContas + 1;
        }
        int proxima = ContaCorrente.ProximaConta();



    }
}

