using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTERFACE
{
    internal class poupança : IConta
    {
        public double saldo { get; set; }
        public string numero { get; set; }
        public string Nome { get ; set ; }
        public string CPF { get; set ; }


        public poupança()
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
        private double CalcularRendimento() 
        {
            return saldo = saldo * (617/ 100);
        }

        public void unico()
        {
            Console.WriteLine(CalcularRendimento());
        }
    }
}
