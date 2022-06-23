namespace CursoDesignPatterns
{
    public class RealizadorDeInvestimentos
    {
        public void RealizaInvestimento(IInvestimento investimento, ContaBancaria contaBancaria)
        {
            double retornoInvestimento = investimento.CalculaInvestimento(contaBancaria.Saldo);
            contaBancaria.GanhosDeInvestimento(retornoInvestimento);
            System.Console.WriteLine(contaBancaria.Saldo);
        }
    }
}