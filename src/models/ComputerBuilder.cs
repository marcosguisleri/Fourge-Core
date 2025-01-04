using ProjetoFinal1.src.models;

public class ComputerBuilder
{
    private Computer _computer;

    public ComputerBuilder(string tipo)
    {
        if (tipo.Equals("Desktop", StringComparison.OrdinalIgnoreCase))
        {
            _computer = new Desktop { Tipo = "Desktop" };
        }
        else if (tipo.Equals("Laptop", StringComparison.OrdinalIgnoreCase))
        {
            _computer = new Laptop { Tipo = "Laptop" };
        }
        else
        {
            throw new ArgumentException("Tipo de computador inválido.");
        }
    }

    public ComputerBuilder SetCpu(string cpu)
    {
        _computer.Cpu = cpu;
        return this;
    }

    public ComputerBuilder SetRam(string ram)
    {
        _computer.Ram = ram;
        return this;
    }

    public ComputerBuilder SetArmazenamento(string armazenamento)
    {
        _computer.Armazenamento = armazenamento;
        return this;
    }

    public Computer Build()
    {
        return _computer;
    }
}