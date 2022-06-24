using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class program
    {
        //Este é um exemplo do padrao de projeto 'Chain of Responsability'
        static void Main(string[] args)
        {
            var calculador = new CalculadorDeDescontos();
            var orcamento = new Orcamento();
            var item1 = new Item("lapis", 10.0);
            var item2 = new Item("caneta", 10.0);
            orcamento.AdicionaItem(item1);
            orcamento.AdicionaItem(item2);

            double desconto = calculador.Calcula(orcamento);
            System.Console.WriteLine(desconto);

        }
    }
}
