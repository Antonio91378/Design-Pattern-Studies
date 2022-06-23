using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class Iss
    {
        public double CalculaIss(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }
    }
}
