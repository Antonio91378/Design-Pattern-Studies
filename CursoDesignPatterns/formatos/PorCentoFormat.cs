namespace CursoDesignPatterns.formatos
{
    public class PorCentoFormat : IFormato
    {
        public IFormato Proximo { get; set; }
        public string formatType = "PorCento";

        public string Checar(Requisicao requisicao)
        {
            if (requisicao.FormatItens.Phrase.Contains("%")
              && !requisicao.FormatItens.Phrase.Contains(",")
               && !requisicao.FormatItens.Phrase.Contains("<")
                && !requisicao.FormatItens.Phrase.Contains(">"))
            {
                List<string> conteudo = requisicao.FormatItens.Phrase.Split('%').ToList();
                if (conteudo.Count() > 2)
                {
                    throw new Exception("Requisição inválida");
                }
                ContaBancaria.AdicionaConta(new ContaBancaria(conteudo[0], Convert.ToDouble(conteudo[1])));
                return $" Requisicao {requisicao.FormatItens.OrdemDaRequisicao} identificada no modelo {formatType}\n" +
                        $"Conta {requisicao.FormatItens.OrdemDaRequisicao}, de Titular {conteudo[0]}, adicionada com sucesso!";
            }
            else
            {
                return Proximo.Checar(requisicao);
            }
        }
    }
}