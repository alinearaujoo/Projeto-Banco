using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Banco
{
    internal class Conta_Bancaria
    {
        public int agencia, numero_conta, idade, mes;
        public string titular;
        public double valor, saldo = 100;

        public void Sacar()
        {
            saldo -= valor;
        }

        public void Depositar()
        {
            saldo += valor;
        }
    }
}
