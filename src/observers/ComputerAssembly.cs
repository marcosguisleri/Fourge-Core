using System;
using System.Collections.Generic;
using ProjetoFinal1.src.models;
using ProjetoFinal1.src.strategies;
using ProjetoFinal1.src.observers;

namespace ProjetoFinal1.src.assemblers
{
    public class ComputerAssembly
    {
        private readonly List<IObserver> _observers = new List<IObserver>();
        private readonly Computer assembledComputer;
        private readonly IAssemblyStrategy assemblyStrategy;
        public ComputerAssembly(Computer assembledComputer, IAssemblyStrategy assemblyStrategy)
        {
            this.assembledComputer = assembledComputer;
            this.assemblyStrategy = assemblyStrategy;
        }

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        private void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(assembledComputer);
            }
        }

        public void Assemble()
        {
            assemblyStrategy.Assemble(assembledComputer);
            Notify();
        }
    }
}
