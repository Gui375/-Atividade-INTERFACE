using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTERFACE
{
    class corrente : IConta
    {
        public double saldo { get; set; }
        public string numero { get; set; }
        public string Nome { get ; set ; }
        public string CPF { get ; set ; }



        public corrente()
        {
            Cliente cliente = new Cliente();
            saldo = 0;
        }
        public double calcularSaldo()
        {
            return saldo;
        }

        public void depositar(double valor)
        {
            saldo += valor;
        }

        public void sacar(double valor)
        {
            saldo -= valor;
        }

        private double CalcularTarifa() 
        {
            return saldo-30;
            //imaginei que CalcularTarifa fosse a manutenção da conta

        }

        public void unico()
        {
            Console.WriteLine(CalcularTarifa());
        }
    }
}
