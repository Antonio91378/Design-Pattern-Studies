using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class program
    {
        //Este é um exemplo do padrao de projeto 'Strategy'
        //exemplo teste para o exercício de investimentos
        static void Main(string[] args)
        {
            var conta1 = new ContaBancaria();
            // criando um investimento arrojado por exemplo
            var investimentoArrojado = new InvestimentoArrojado();
            // saldo inicial das contas criadas = 100.
            var investidor = new RealizadorDeInvestimentos();
            investidor.RealizaInvestimento(investimentoArrojado, conta1);
        }
    }
}
