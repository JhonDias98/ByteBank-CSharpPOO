using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ByteBank_Herança_Interface.Funcionarios
{
    //Herdando a classe Funcionário
    class Desenvolvedor : Funcionario
    {
        //Base faz referência a classe pai
        //Atribuindo os valores do contrutor da classe Funcionário(base)
        public Desenvolvedor(string cpf) : base(3000, cpf) { }

        //Override permite sobrescrever o método abstrato da classe pai
        public override void AumentarSalario()
        {
            Salario *= 0.15;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.1;
        }
    }
}
