using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class program
    {
        static void Main(string[] args)
        {
            var iss = new Iss();
            var icms = new Icms();

            Orcamento orcamento = new Orcamento(5000.0);
            CalculadorDeImpostos calculador = new CalculadorDeImpostos();

            calculador.RealizaCalculo(orcamento, icms);
        }
    }
}
