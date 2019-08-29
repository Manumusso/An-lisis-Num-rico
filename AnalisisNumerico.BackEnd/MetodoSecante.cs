using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using org.mariuszgromada.math.mxparser;

namespace AnalisisNumerico.BackEnd
{
    class MetodoSecante: MetodosRaices
    {
        public static double Calcular(Parametros parametros)
        {
            double replace = parametros.ValorDerecho;

            Function func = new Function("F(x) = " + parametros.Funcion);

            var a = new StringToFormula();
            double x0=0, x1=0, xr=0;

            double Fx(double x) //Calcular funcion
            {
                return a.Eval(parametros.Funcion.ToUpper().Replace("X", x.ToString()));
            }

            double FF(double xi0, double xi1) //Calcular Formula Fundamental
            {
                var Fxi0 = Fx(xi0);
                var Fxi1 = Fx(xi1);
              
                return ((Fxi1 * xi0 - Fxi0 * xi1)/ Fxi1 - Fxi0);
            }

            x0 = parametros.ValorIzquierdo;
            x1 = parametros.ValorDerecho;
            
            var cont = 0;
            double error = 0, xant = x0;

            while (Fx(x0) * Fx(x1) != 0 ||                  // si (fx*fx=0) => x0 || x1 es raiz
                Math.Abs(Fx(x1)) < parametros.Tolerancia || // si no xr va a ser la raiz
                error < parametros.Tolerancia ||
                cont >= parametros.Iteraciones)
            {
                if(cont >= 1)
                {
                    x0 = x1;
                    x1 = xr;
                    xant = x1;
                }
                cont++;
                xr = FF(x0, x1);
                error= Math.Abs((xr-xant)/xr);
            }
            if (cont == 0)
            {
                if (Fx(x0) == 0)
                    return xr = x0;
                else
                    return xr = x1;
            }
            else
                return xr;
        }
    }
}
