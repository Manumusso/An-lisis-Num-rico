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
        public MetodosTangente(Funcion enume) : base(enume)
        {

        }

        public MetodosTangente(Funcion enume, string str) : base(enume, str)
        {

        }

        public Resultados Calcular(Parametros parametros)
        {
            var cont = 0;
            double xIni = parametros.ValorDerecho;
            double xR = xIni;
            double xAnt = 0;
            double error = 0;

            var iteraciones = parametros.Iteraciones;
            var tolerancia = parametros.Tolerancia;

            while (Math.Abs(Funcion(xR))>parametros.Tolerancia)
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
