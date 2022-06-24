namespace CursoDesignPatterns.formatos
{
    public class CsvFormat : IFormato
    {
        public IFormato Proximo { get; set; }
        public string formatType = "CSV";

        public string Checar(Requisicao requisicao)
        {
            foreach (var formatItem in requisicao.FormatItens)
            {
                if (formatItem.Phrase.Contains(",") && !formatItem.Phrase.Contains("%") && !formatItem.Phrase.Contains("<") && !formatItem.Phrase.Contains(">"))
                {

                    return $" Requisição {formatItem.OrdemDaRequisicao} da fila Identificada como {formatType}";
                }
                else
                {
                    return "Nao identificado";
                }
            }
            return "Nao identificado";
        }
    }
}