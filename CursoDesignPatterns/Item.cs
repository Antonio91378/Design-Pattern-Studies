namespace CursoDesignPatterns
{
    public class Item
    {
        public Item(string nome, double valor)
        {
            this.Nome = nome.ToUpper();
            this.Valor = valor;
        }

        public string Nome { get; private set; }
        public double Valor { get; private set; }
    }
}