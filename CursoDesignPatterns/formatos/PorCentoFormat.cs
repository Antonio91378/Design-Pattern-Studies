namespace CursoDesignPatterns.formatos
{
    public class PorCentoFormat : IFormato
    {
        public IFormato Proximo { get; set; }

        public string Checar(Requisicao requisicao)
        {
            throw new NotImplementedException();
        }
    }
}