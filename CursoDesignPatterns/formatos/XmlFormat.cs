namespace CursoDesignPatterns.formatos
{
    public class XmlFormat : IFormato
    {
        public IFormato Proximo { get; set; }

        public string Checar(Requisicao requisicao)
        {
            throw new NotImplementedException();
        }
    }
}