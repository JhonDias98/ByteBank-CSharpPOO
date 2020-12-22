using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_ByteBank_Herança_Interface.Funcionarios;
using _02_ByteBank_Herança_Interface.Sistemas;

namespace _02_ByteBank_Herança_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se o método for static, usar da seguinte forma
            CalcularBonificacao();

            //Caso contrario, usar da seguinte maneira
            /*
            Program program = new Program();
            program.CalcularBonificacao();
            */

            Console.ReadLine();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor danilo = new Diretor("623.171.854-71");
            danilo.Nome = "Danilo";
            danilo.Senha = "123";
            sistemaInterno.Logar(danilo, "123");
        }

        //É preciso deixar o método como static para utilizar dentro no método Main
        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Auxiliar danilo = new Auxiliar("587.321.964-98");
            danilo.Nome = "Danilo";

            Designer matheus = new Designer("632.874.963-78");
            matheus.Nome = "Matheus";

            Diretor ricardo = new Diretor("471.231.854-71");
            ricardo.Nome = "Ricardo";

            GerenteDeConta jonathan = new GerenteDeConta("632.684.167-52");
            jonathan.Nome = "Jonathan";

            gerenciadorBonificacao.Registrar(danilo);
            gerenciadorBonificacao.Registrar(matheus);
            gerenciadorBonificacao.Registrar(ricardo);
            gerenciadorBonificacao.Registrar(jonathan);

            Console.WriteLine("Total de bonificações do mês: " + 
                gerenciadorBonificacao.GetTotalBonificacao());
        }
    }
}
