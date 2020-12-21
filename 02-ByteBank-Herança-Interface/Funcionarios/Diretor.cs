﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ByteBank_Herança_Interface.Funcionarios
{
    //Usar ':' para herança
    class Diretor : Funcionario
    {
        public Diretor(string cpf) : base(cpf) { }

        //Override sobreescreve o método
        public override double GetBonificacao()
        {
            //Base faz referência a classe pai 
            return Salario + base.GetBonificacao();
        }
    }
}
