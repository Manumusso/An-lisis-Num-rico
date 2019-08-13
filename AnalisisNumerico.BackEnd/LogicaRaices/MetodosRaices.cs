using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using org.mariuszgromada.math.mxparser;

namespace AnalisisNumerico.BackEnd.Logica
{
    public class MetodosRaices:IMetodosRaices
    {

        public ResultadosRaices MetodoBiseccionReglaFalsa(ParametrosRaices parametros)
        {
            return null;
        }

        private double RetornarImagen(string funcion, double xr)
        {
            //var imagen = new Function(funcion).calculate(xr);
            return new Function(funcion).calculate(xr);
        }

        private double CalcularXrBiseccion(double xi, double xd)
        {
            return (xi + xd) / 2;
        }

        

    }
}
