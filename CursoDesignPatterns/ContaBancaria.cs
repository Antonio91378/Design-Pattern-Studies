namespace CursoDesignPatterns
{
    public class ContaBancaria
    {
        public double Saldo { get; private set; }
        public ContaBancaria()
        {
            //saldo de exemplo
            Saldo = 100.0;
        }
        public void GanhosDeInvestimento(double _valor)
        {
            Saldo += _valor;
        }

    }
}