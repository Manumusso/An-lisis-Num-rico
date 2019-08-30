using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using org.mariuszgromada.math.mxparser;

namespace AnalisisNumerico.BackEnd
{
    public class MetodosTangente : MetodosRaices
    {
        //string Funcion 
        //int Iteraciones 
        //double Tolerancia 
        //double ValorIzquierdo 
        //double ValorDerecho 
        //bool Finalizo 



        public static double Funcion(double x)
        {
            return ((15.2 * (x + 2)) / (Math.Pow(x, 2) + 4 * x + 5)) + 2;
            // return Math.Log(x) + (1 / x) - 3;
            //return Math.Abs(Math.Pow(x,2) - 4)+2*x;

        }
            public static Resultados Calcular(Parametros parametros)
        {
            var cont = 0;
            double xIni = 4;
            double xR = xIni;
            double xAnt = 0;
            double error = 0;

            var iteraciones = 10000000;
            var tolerancia = 0.0001;

            while (Math.Abs(Funcion(xR))>xR)
            {
                cont++;

                var deri = (Funcion(xIni + tolerancia) - Funcion(xIni)) / tolerancia;

                xR = xIni - (Funcion(xIni) / deri);

                error = Math.Abs((xR - xAnt) / xR);

                if(error < tolerancia || cont >= iteraciones)
                {
                    break;
                }
                else
                {
                    xIni = xR;
                    xAnt = xR;
                }
            }
            return new Resultados()
            {
                Raiz = xR,
                Error = error,
                Iteraciones = cont,
                Observacion = ""
            };
        }
    }
}
