using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTERFACE
{
    internal class Cliente : ICliente
    {
        public string Nome { get ; set ; }
        public string CPF { get ; set; }

        public Cliente() 
        {
            Console.WriteLine("Seu nome: ");
            Nome = Console.ReadLine();
            Console.WriteLine("Seu CPF: ");
            CPF = Console.ReadLine();
        }

        
    }
}
