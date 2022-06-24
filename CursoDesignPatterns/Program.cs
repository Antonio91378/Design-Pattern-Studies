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
            var requisicao = new Requisicao();
            //lembrar de printar a ordem quando nao der certo :)
            var formatItem1 = new FormatItem("antonio,100,programador", 1);
            requisicao.AdicionarFormatItem(formatItem1);
            string identificacao = identificador.Identifica(requisicao);
            System.Console.WriteLine(identificacao);
        }
    }
}
