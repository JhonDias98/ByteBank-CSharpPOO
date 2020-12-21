using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_ByteBank_Herança_Interface.Funcionarios;

namespace _02_ByteBank_Herança_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario jonathan = new Funcionario("456.123.789-19");
            jonathan.Nome = "Jonathan";
            jonathan.Salario = 2000;

            gerenciador.Registrar(jonathan);

            Diretor jones = new Diretor("852.741.963-91");
            jones.Nome = "Jones";
            jones.Salario = 5000;

            gerenciador.Registrar(jones);

            Console.WriteLine(jonathan.Nome);
            Console.WriteLine(jonathan.GetBonificacao());

            Console.WriteLine(jones.Nome);
            Console.WriteLine(jones.GetBonificacao());

            Console.WriteLine("Total de Bonificação: " + gerenciador.GetTotalBonificacao());


            Console.ReadLine();
        }
    }
}
