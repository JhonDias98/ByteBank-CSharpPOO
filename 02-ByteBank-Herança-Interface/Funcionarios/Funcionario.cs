using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ByteBank_Herança_Interface.Funcionarios
{
    public class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }

        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; set; }

        public Funcionario(string cpf)
        {
            CPF = cpf;
            TotalDeFuncionarios++;
        }

        //Virtual permite que as classes filhas sobreescrevam o método
        public virtual double GetBonificacao()
        {
            return Salario * 0.10;
        }
    }
}
