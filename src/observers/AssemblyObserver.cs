using ProjetoFinal1.src.models;

namespace ProjetoFinal1.src.observers
{
    public class AssemblyObserver : IObserver
    {
        private Label _notificationLabel;

        public AssemblyObserver(Label notificationLabel)
        {
            _notificationLabel = notificationLabel;
        }

        public void Update(Computer computer)
        {
            _notificationLabel.Text = $"Computador montado com Sucesso";
        }
    }
}
