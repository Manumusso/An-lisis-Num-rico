using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisisNumerico.BackEnd.Logica
{
    public class ResultadosRaices
    {
        public double Raiz { get; set; }

        public int Iteraciones { get; set; }

        public double Error { get; set; }

        public string Observacion { get; set; }
    }
}
