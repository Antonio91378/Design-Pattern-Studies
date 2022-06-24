using CursoDesignPatterns.formatos;
namespace CursoDesignPatterns
{
    public class IdentificadorDeFormatos
    {
        public string Identifica(Requisicao requisicao)
        {
            var r1 = new CsvFormat();
            var r2 = new PorCentoFormat();
            var r3 = new XmlFormat();
            var r4 = new WhithoutFormat();
            r1.Proximo = r2;
            r2.Proximo = r3;
            r3.Proximo = r4;
            return r1.Checar(requisicao);
        }
    }
}