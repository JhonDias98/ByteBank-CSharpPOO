using _02_ByteBank_Herança_Interface.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ByteBank_Herança_Interface.Funcionarios
{
    //Por ser abstrata ela não poderá ser instanciada por outras classes
    //Aqui está herdando a classe Funcionário e implementando a interface IAutenticavel
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        //Atributos para usar no método da interface
        public string Senha { get; set; }

        //Atribuindo os valores do contrutor da classe Funcionário(base)
        public FuncionarioAutenticavel(double salario, string cpf) : base(salario, cpf) { }

        //Lógica que usaremos no método que veio da interface
        //Não é preciso usarmos override
        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}