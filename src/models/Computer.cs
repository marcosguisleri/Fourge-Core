using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoFinal1.src.strategies;

namespace ProjetoFinal1.src.models
{
    public abstract class Computer
    {
        public string Tipo { get; set; }
        public string Cpu { get; set; }
        public string Ram { get; set; }
        public string Armazenamento { get; set; }

        public IAssemblyStrategy AssemblyStrategy { get; set; }

        public void ChooseAssemblyStrategy(IAssemblyStrategy strategy)
        {
            AssemblyStrategy = strategy;
        }

        public void Assemble()
        {
            AssemblyStrategy.Assemble(this);
        }

        public override string ToString()
        {
            return $"Tipo: {Tipo}, CPU: {Cpu}, RAM: {Ram}, Armazenamento: {Armazenamento}";
        }
    }
}
