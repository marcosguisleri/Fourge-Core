using System;
using System.Windows.Forms;
using ProjetoFinal1.src.models;
using ProjetoFinal1.src.factories;
using ProjetoFinal1.src.observers;
using ProjetoFinal1.src.strategies;
using ProjetoFinal1.src.assemblers;

namespace ProjetoFinal1
{
    public partial class MainForm : Form
    {
        private ComputerFactory _factory;

        public MainForm()
        {
            InitializeComponent();

            _factory = ComputerFactory.GetInstance();

            computerTypeComboBox.Items.Add("Desktop");
            computerTypeComboBox.Items.Add("Laptop");

            strategyComboBox.Items.Add("Standard");
            strategyComboBox.Items.Add("Gaming");
        }

        private void assembleButton_Click(object sender, EventArgs e)
        {
            string cpu = cpuTextBox.Text;
            string ram = ramTextBox.Text;
            string storage = storageTextBox.Text;
            string computerType = computerTypeComboBox.SelectedItem?.ToString();
            string strategy = strategyComboBox.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(cpu) || string.IsNullOrWhiteSpace(ram) || string.IsNullOrWhiteSpace(storage))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            if (computerType == null)
            {
                MessageBox.Show("Por favor, escolha um tipo de computador.");
                return;
            }

            if (strategy == null)
            {
                MessageBox.Show("Por favor, escolha uma estratégia de montagem.");
                return;
            }

            IAssemblyStrategy assemblyStrategy = strategy == "Gaming"
                ? new GamingAssemblyStrategy()
                : new StandardAssemblyStrategy();

            Computer computer;
            if (computerType == "Desktop")
            {
                computer = new Desktop(); 
            }
            else
            {
                computer = new Laptop(); 
            }

            var builder = new ComputerBuilder(computerType)
                .SetCpu(cpu)
                .SetRam(ram)
                .SetArmazenamento(storage);

            var assembledComputer = builder.Build();
            var assembly = new ComputerAssembly(assembledComputer, assemblyStrategy);

            var observer = new AssemblyObserver(notificationLabel); 
            assembly.Attach(observer);
            assembly.Assemble();

            resultLabel.Text = assembledComputer.ToString();
            resultLabel1.Text = $"Estratégia: {assemblyStrategy.GetType().Name}";
        }
    }
}
