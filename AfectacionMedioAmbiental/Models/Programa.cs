using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AfectacionMedioAmbiental.Models
{
    public class Programa
    {
        static void Main(string[] args)
        {
            CSuma s = new CSuma();
            s.calcular(4.5, 6.7);
            s.mostrar();
        }
    }
}
