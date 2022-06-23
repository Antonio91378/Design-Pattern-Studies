namespace CursoDesignPatterns
{
    public class InvestimentoConservador : IInvestimento
    {
        public double CalculaInvestimento(double valor)
        {
            return (valor * 0.8);
        }
    }
}