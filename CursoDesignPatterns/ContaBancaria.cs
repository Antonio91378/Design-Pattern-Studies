namespace CursoDesignPatterns
{
    public class ContaBancaria
    {
        public string Nome { get;private set; }
        public double Saldo { get; private set; }
        static public List<ContaBancaria> ContasBancarias = new List<ContaBancaria>();
        public ContaBancaria(string nome, double saldo)
        {
            this.Nome = nome;
            this.Saldo = saldo;
        }
        static public void AdicionaConta(ContaBancaria conta){

            ContasBancarias.Add(conta);
        }

    }
}