using _02_ByteBank_Herança_Interface.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ByteBank_Herança_Interface.Funcionarios
{
    //Usar ':' para herança
    class Diretor : FuncionarioAutenticavel
    {
        public Diretor(string cpf) : base(5000, cpf) { }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

        //Override sobreescreve o método
        public override double GetBonificacao()
        {
            //Base faz referência a classe pai 
            return Salario * 0.5;
        }
    }
}
