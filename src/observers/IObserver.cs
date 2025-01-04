using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoFinal1.src.models;

namespace ProjetoFinal1.src.observers
{
    public interface IObserver
    {
        void Update(Computer computer);
    }
}
