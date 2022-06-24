namespace CursoDesignPatterns
{
    public class Requisicao
    {


        public List<FormatItem> FormatItens { get; private set; }
        public Requisicao()
        {

            FormatItens = new List<FormatItem>();
        }
        public void AdicionarFormatItem(FormatItem formatItem)
        {
            FormatItens.Add(formatItem);
        }

    }
}