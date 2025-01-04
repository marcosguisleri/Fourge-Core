using ProjetoFinal1.src.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal1.src.factories
{
    public class ComputerFactory
    {
        private static ComputerFactory _instance;

        // Construtor privado: impede a criação de instâncias externas.
        private ComputerFactory() { }

        // Método para acessar a única instância da fábrica.
        public static ComputerFactory GetInstance()
        {
            if (_instance == null)
            {
                _instance = new ComputerFactory();
            }
            return _instance;
        }

        // Método para criar um computador específico.
        public Computer CreateComputer(string type)
        {
            switch (type)
            {
                case "Desktop": return new Desktop();
                case "Laptop": return new Laptop();
                default: throw new ArgumentException("Tipo de computador desconhecido");
            }
        }

    }

}