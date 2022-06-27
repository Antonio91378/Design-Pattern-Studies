namespace CursoDesignPatterns
{
    public class Requisicao
    {

        public FormatItem FormatItens { get; private set; }
        public Requisicao(FormatItem formatItem)
        {
            this.FormatItens = formatItem;
        }



    }
}