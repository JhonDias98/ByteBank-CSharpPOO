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

            Console.WriteLine("Saldo Inicial Gabriela: R$" + contaDaGabriela.saldo);


            ContaCorrente contaDoBruno = new ContaCorrente();

            contaDoBruno.titular = "Gabriela";
            contaDoBruno.agencia = 4488;
            contaDoBruno.numero = 423654;
            contaDoBruno.saldo = 1000;

            Console.WriteLine("Saldo Inicial Bruno: R$" + contaDoBruno.saldo);

            contaDoBruno.Transferir(400, contaDaGabriela);

            Console.WriteLine("Saldo da Gabriela após a tranferência R$" + contaDaGabriela.saldo);
            Console.WriteLine("Saldo do Bruno após a tranferência R$" + contaDoBruno.saldo);

            Console.ReadLine();
        }
    }
}
