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
            var orcamento = new Orcamento(500);
            orcamento.AdicionaItem(new Item("Caneta", 250));
            orcamento.AdicionaItem(new Item("Lapis", 250));

            double desconto = calculador.Calcula(orcamento);

        }
    }
}
