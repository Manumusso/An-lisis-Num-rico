using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisisNumerico.BackEnd.Logica
{
    public class ParametrosRaices
    {
        public string Funcion { get; set; }

        public int Iteraciones { get; set; }

        public double Tolerancia { get; set; }

        public double ValorIzquierdo { get; set; }

        public double ValorDerecho { get; set; }

        public bool Finalizo { get; set; }
    }
}
