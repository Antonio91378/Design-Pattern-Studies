using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class CalculadorDeImpostos
    {
        public void RealizaCalculo(Orcamento orcamento, string imposto)
        {
            if ("ICMS".Equals(imposto))
            {
                double icms = new Icms().CalculaIcms(orcamento);
                Console.WriteLine(icms);
            }

            else if ("ISS".Equals(imposto))
            {
                double iss = new Iss().CalculaIss(orcamento);
                Console.WriteLine(iss);
            }
        }
    }
}
