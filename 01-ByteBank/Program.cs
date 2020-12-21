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
            Cliente gabriela = new Cliente("Gabriela", "Desenvolvedora C#", "487.698.321-12");

            ContaCorrente contaDaGabriela = new ContaCorrente(4488, 458796);
            contaDaGabriela.Titular = gabriela;
            contaDaGabriela.Saldo = 1000;
            Console.WriteLine("Saldo Inicial Gabriela: R$" + contaDaGabriela.Saldo);


            Cliente bruno = new Cliente("Bruno", "Desenvolvedor C#", "484.324.924-31");

            ContaCorrente contaDoBruno = new ContaCorrente(4488, 423654);
            contaDoBruno.Titular = bruno;
            contaDoBruno.Saldo = 1000;
            Console.WriteLine("Saldo Inicial Bruno: R$" + contaDoBruno.Saldo);

            contaDoBruno.Transferir(500, contaDaGabriela);

            Console.WriteLine("Saldo da Gabriela após a tranferência R$" + contaDaGabriela.Saldo);
            Console.WriteLine("Saldo do Bruno após a tranferência R$" + contaDoBruno.Saldo);


            //Atribuindo a instância do Cliente direto no titular
            ContaCorrente conta = new ContaCorrente(4488, 696423);

            conta.Titular = new Cliente("Jonathan", "Desenvolvedor Junior", "487.548.631-54");
            conta.Saldo = 3500;

            if(conta.Titular == null)
            {
                Console.WriteLine("A referência em conta.titular é NULL");
            }

            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
            
            Console.ReadLine();
        }
    }
}
