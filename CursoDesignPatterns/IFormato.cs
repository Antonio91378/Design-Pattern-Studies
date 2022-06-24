namespace CursoDesignPatterns
{
    public interface IFormato
    {
        string Checar(Requisicao requisicao);
        IFormato Proximo { get; set; }
    }
}