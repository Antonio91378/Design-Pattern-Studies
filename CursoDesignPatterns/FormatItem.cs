namespace CursoDesignPatterns
{
    public class FormatItem
    {
        public FormatItem(string phrase, int ordemDaRequisicao)
        {
            this.Phrase = phrase.ToUpper();
            this.OrdemDaRequisicao = ordemDaRequisicao;
        }

        public int OrdemDaRequisicao { get; }
        public string Phrase { get; set; }
    }
}