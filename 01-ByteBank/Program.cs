using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 4488;
            contaDaGabriela.numero = 458796;
            contaDaGabriela.saldo = 2000;

            contaDaGabriela.Sacar(2005);

            Console.WriteLine(contaDaGabriela.saldo);

            Console.ReadLine();
        }
    }
}
