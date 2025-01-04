using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoFinal1.src.models;

namespace ProjetoFinal1.src.strategies
{
    public class GamingAssemblyStrategy : IAssemblyStrategy
    {
        public void Assemble(Computer computer)
        {
            Console.WriteLine($"Montando um {computer.Tipo} com componentes otimizados para jogos.");
        }
    }
}
