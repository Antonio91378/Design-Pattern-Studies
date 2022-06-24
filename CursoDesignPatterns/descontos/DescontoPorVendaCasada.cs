namespace CursoDesignPatterns
{
    public class DescontoPorVendaCasada : IDesconto
    {
        public IDesconto Proximo { get; set; }
        public double Desconta(Orcamento orcamento)
        {
            foreach (var item in orcamento.Itens)
            {
                if (item.Nome.Equals("LAPIS"))
                {
                    foreach (var item2 in orcamento.Itens)
                    {
                        if (item2.Nome.Equals("CANETA"))
                        {
                            return orcamento.Valor * 0.05;
                        }
                    }
                }
            }
            return 0;
        }
    }
}