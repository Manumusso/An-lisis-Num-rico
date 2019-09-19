using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisisNumerico.BackEnd
{
    public class ResultadoEcuaciones
    {

        public List<double> Resultados { get; set; }
        public int iteraciones { get; set; }
        public bool convergio { get; set; }

        public ResultadoEcuaciones()
        {
            this.Resultados = new List<double>();
        }
    }


    public class ResultadoEcuacionesMatriz
    {

        public double[] Resultados { get; set; }
        public int iteraciones { get; set; }
        public bool convergio { get; set; }

    }

}
