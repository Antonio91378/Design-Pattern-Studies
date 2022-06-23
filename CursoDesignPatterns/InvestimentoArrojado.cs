namespace CursoDesignPatterns
{
    public class InvestimentoArrojado : IInvestimento
    {
        public double CalculaInvestimento(double valor)
        {
            bool escolha1 = new Random().Next(101) > 20; // retorna 5% se false
            bool escolha2 = new Random().Next(101) > 30; // retorna 3% se false
            bool escolha3 = new Random().Next(101) > 50; // retorna 0.6% se false
            if (!escolha1)
            {
                Console.WriteLine("Retornei o investimento * 5");
                return (valor * 5);
            }
            else if (!escolha2)
            {
                Console.WriteLine("Retornei o investimento * 3");
                return (valor * 3);
            }
            else
            {
                Console.WriteLine("Retornei o investimento * 0,6");
                return (valor * 0.6);
            }
        }
    }
}