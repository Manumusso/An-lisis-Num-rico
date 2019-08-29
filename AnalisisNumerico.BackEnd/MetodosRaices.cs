using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using org.mariuszgromada.math.mxparser;

namespace AnalisisNumerico.BackEnd
{
    public  class MetodosRaices:IMetodosRaices
    {


        public double RetornarValor(string funcion, double xr)
        {
            var imagen = new Function(funcion).calculate(xr);

            return new Function(funcion).calculate(xr);

        }
 
    }

}

