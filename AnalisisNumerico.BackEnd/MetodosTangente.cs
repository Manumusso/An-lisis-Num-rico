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

     

        public Parametros asd(Parametros parametros)
        {
            return null;
        }

        public static Resultados Calcular(Parametros parametros)
        {
            double valorX = parametros.ValorDerecho;
            bool flag = true;
            double xR = 0;
            double xAnt = 0;
            double error = 0;
            var cont = 0;

            Function func = new Function("F(x) = " + parametros.Funcion);
            //Expression ex = (new Expression($"F({valorX})", func));

            Expression ex = (new Expression($"F({valorX})", func));
            var ResultValorX = ex.calculate();

            while (flag)
            {

                if (Math.Abs(ResultValorX) <= parametros.Tolerancia)
                {
                    return new Resultados()
                    {
                        Raiz = valorX,
                    };
                }
                else
                {
                    cont++;
                    Double val = ((new Expression($"F({valorX + parametros.Tolerancia})", func)).calculate() - ResultValorX);
                    double derivadaEnX = val / parametros.Tolerancia;
                    xR = (valorX - ResultValorX) / derivadaEnX;

                    error = Math.Abs(xR - xAnt) / xR;


                    ex = (new Expression($"F({xR})", func));
                    ResultValorX = ex.calculate();

                    if(error < parametros.Tolerancia || cont >= parametros.Iteraciones)
                    {
                        return new Resultados()
                        {
                            Raiz = valorX,
                        };
                    }

                    valorX = xR;
                    xAnt = xR;
                }

            }

            return null;            
        }


    }
}
