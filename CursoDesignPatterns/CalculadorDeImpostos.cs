using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class CalculadorDeImpostos
    {
        public void RealizaCalculo(Orcamento orcamento, IImposto _imposto)
        {
            double imposto = _imposto.Calcula(orcamento);
            Console.WriteLine(imposto);
        }
    }
}
