using _02_ByteBank_Herança_Interface.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ByteBank_Herança_Interface.Sistemas
{
    public interface IAutenticavel
    {
        bool Autenticar(string senha);
        
    }
}
