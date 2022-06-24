namespace CursoDesignPatterns.formatos
{
    public class WhithoutFormat : IFormato
    {
        public IFormato Proximo { get; set; }

        public string Checar(Requisicao requisicao)
        {
            throw new NotImplementedException();
        }
    }
}