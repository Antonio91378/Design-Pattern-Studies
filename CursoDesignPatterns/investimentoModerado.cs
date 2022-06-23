namespace CursoDesignPatterns
{
    public class InvestimentoModerado : IInvestimento
    {
        public double CalculaInvestimento(double valor)
        {
            bool escolha1 = new Random().Next(101) > 50; // retorna 2.5% se false
            if (!escolha1)
            {
                Console.WriteLine("Retornei o investimento * 2.5");
                return (valor * 2.5);
            }
            else
            {
                Console.WriteLine("Retornei o investimento * 0,7");
                return (valor * 0.7);
            }
        }
    }
}