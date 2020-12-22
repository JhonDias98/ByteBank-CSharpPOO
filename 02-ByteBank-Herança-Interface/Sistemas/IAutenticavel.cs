using _02_ByteBank_Herança_Interface.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ByteBank_Herança_Interface.Sistemas
{
    //Colocar I no início para diferenciar classe de interface
    public interface IAutenticavel
    {
        //Não é preciso definir se é public, private...
        //Métodos
        bool Autenticar(string senha);
    }
}
