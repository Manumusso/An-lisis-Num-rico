using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using org.mariuszgromada.math.mxparser;

namespace AnalisisNumerico.BackEnd
{
    public class MetodoSecante: MetodosRaices
    {

        public MetodoSecante(Funcion enume) : base(enume)
        {
        }

    public Resultados Calcular(Parametros parametros) // Metodo Chelo
        {            
            var Resultado = new Resultados();
            double xant = parametros.ValorIzquierdo;
            double x0 = 0, x1 = 0, xr = 0;

            double FF(double xi0, double xi1) //Calcular Formula Fundamental
            {
                var Fxi0 = Funcion(xi0);
                var Fxi1 = Funcion(xi1);

                return ((Fxi1 * xi0 - Fxi0 * xi1) / Fxi1 - Fxi0);
            }

            x0 = parametros.ValorIzquierdo;
            x1 = parametros.ValorDerecho;

            var cont = 0;
            double error = 0;

            while (Funcion(x0) * Funcion(x1) != 0 &&                 // si (fx*fx=0) => x0 || x1 es raiz
                Math.Abs(Funcion(x1)) < parametros.Tolerancia || // si no xr va a ser la raiz
                error < parametros.Tolerancia ||
                cont <= parametros.Iteraciones)
            {
                if (cont >= 1)
                {
                    x0 = x1;
                    x1 = xr;
                    xant = x1;
                }
                cont++;
                xr = FF(x0, x1);
                error = Math.Abs((xr - xant) / xr);
            }
            if (Funcion(x0) * Funcion(x1) == 0)
            {
                if (Funcion(x0) == 0)
                    Resultado.Raiz = x0;
                else
                    Resultado.Raiz = x1;
            }
            else
                Resultado.Raiz = xr;

            Resultado.Error = error;
            Resultado.Iteraciones = cont;
            Resultado.Observacion = "";

            return Resultado;

        }
    }
}
