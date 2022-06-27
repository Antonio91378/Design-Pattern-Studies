namespace CursoDesignPatterns.formatos
{
    public class WhithoutFormat : IFormato
    {
        public IFormato Proximo { get; set; }

        public string Checar(Requisicao requisicao)
        {
            return $" Requisicao {requisicao.FormatItens.OrdemDaRequisicao} não identificada.";
        }
    }
}