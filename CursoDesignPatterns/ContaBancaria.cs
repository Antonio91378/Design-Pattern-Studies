namespace CursoDesignPatterns
{
    public class ContaBancaria
    {
        public string Nome { get; }
        public double Saldo { get; private set; }
        public ContaBancaria(string nome)
        {
            this.Nome = nome;
            Saldo = 100.0;
        }
    }
}