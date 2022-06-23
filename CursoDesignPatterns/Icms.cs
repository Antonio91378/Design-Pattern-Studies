using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class Icms
    {
        public double CalculaIcms(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }
    }
}
