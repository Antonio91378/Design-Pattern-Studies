namespace CursoDesignPatterns
{
    public class Iccc : IImposto
    {
        public double Calcula(Orcamento orcamento)
        {
            double valorCalculado = 0;
            if (orcamento.Valor < 1000)
            {
                valorCalculado = (orcamento.Valor * 0.05);
            }
            else if (1000 <= orcamento.Valor && orcamento.Valor <= 3000)
            {
                valorCalculado = (orcamento.Valor * 0.07);
            }
            else if (3000 < orcamento.Valor)
            {
                valorCalculado = (orcamento.Valor * 0.08) + 30;
            }
            return valorCalculado;
        }
    }
}