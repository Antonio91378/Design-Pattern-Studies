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

            var identificador = new IdentificadorDeFormatos();
            var requisicoes = new List<Requisicao>();
            //lembrar de printar a ordem quando nao der certo :)
            var formatItem1 = new FormatItem("antonio,100", 1);
            var formatItem2 = new FormatItem("antonio%100", 2);
            var formatItem3 = new FormatItem("<nome>antonio</nome><saldo>100</saldo>", 3);//Identificação XML não funcionando ainda
            requisicoes.Add(new Requisicao(formatItem1));
            requisicoes.Add(new Requisicao(formatItem2));
            requisicoes.Add(new Requisicao(formatItem3));
            ResultadoDaRequisicao.AdicionaResultado(identificador.Identifica(requisicoes[0]));
            ResultadoDaRequisicao.AdicionaResultado(identificador.Identifica(requisicoes[1]));
            ResultadoDaRequisicao.AdicionaResultado(identificador.Identifica(requisicoes[2]));
            ResultadoDaRequisicao.MostrarResultados();
        }
    }
}
