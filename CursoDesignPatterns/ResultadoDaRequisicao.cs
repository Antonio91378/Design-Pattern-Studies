using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    static public class ResultadoDaRequisicao
    {
        static public List<string> Resultados = new List<string>();

        static public void AdicionaResultado(string resultado)
        {
            Resultados.Add(resultado);
        }

        static public void MostrarResultados()
        {
            for (var i = 0; i < Resultados.Count(); i++)
            {
                System.Console.WriteLine(Resultados[i]);
            }
        }

    }
}