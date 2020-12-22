using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ByteBank_Herança_Interface.Funcionarios
{
    //Por ser abstrata ela não poderá ser instanciada por outras classes
    public abstract class Funcionario
    {
        //Atributos
        public static int TotalDeFuncionarios { get; private set; }

        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        //Construtor
        public Funcionario(double salario, string cpf)
        {
            CPF = cpf;
            Salario = salario;
            TotalDeFuncionarios++;
        }

        //Métodos
        public abstract void AumentarSalario();

        public abstract double GetBonificacao();
    }
}