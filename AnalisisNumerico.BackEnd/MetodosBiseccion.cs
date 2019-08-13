using AnalisisNumerico.BackEnd.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisisNumerico.BackEnd
{
    class MetodosBiseccion : MetodosRaices
    {
        public ResultadosRaices MetodoBiseccionReglaFalsa(ParametrosRaices parametros)
        {
            return null;
        }

        private double CalcularXrBiseccion(double xi, double xd)
        {
            return (xi + xd) / 2;
        }

    }
}
