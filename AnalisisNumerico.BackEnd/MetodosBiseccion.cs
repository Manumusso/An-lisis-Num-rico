using AnalisisNumerico.BackEnd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using org.mariuszgromada.math.mxparser;

namespace AnalisisNumerico.BackEnd
{
    public class MetodosBiseccion : MetodosRaices
    {
        public MetodosBiseccion(Funcion enume) : base(enume)
        {
        }

        private double CalcularXrBiseccion(double xi, double xd)
        {
            return (xi + xd) / 2;
        }

        private double CalcularXrReglaFalsa(double xi, double xd)
        {
            return (((Funcion(xi) * xd) - (Funcion(xd) * xi)) / ((Funcion(xi) - Funcion(xd))));
        }

        public Resultados MetodoBiseccionReglaFalsa(Parametros parametros)
        {
            double limitizquierdo = parametros.ValorIzquierdo;
            double limitederecho = parametros.ValorDerecho;
            double error = 0;

            var iteraciones = parametros.Iteraciones;
            var tolerancia = parametros.Tolerancia;


            bool termino = false;

            Resultados resultado = new Resultados();
            resultado.Observacion = "";
            //expres1 Limite izquierd
            //expres2Limitederecha

            if ((Funcion(limitizquierdo) * Funcion(limitederecho)) > 0)
            {
                resultado.Observacion = "Ingrese otra vez los valores";
                termino = true;
            }
            
            else if (Funcion(limitizquierdo) * Funcion(limitederecho) == 0)
            {
               
                if (Funcion(limitizquierdo) == 0)
                {
                    resultado.Raiz = limitizquierdo;
                }
                else
                {
                    resultado.Raiz = limitederecho;
                }
            }
            else
            {
                int cInteraciones = 0;
                double antXr = 0;
                double Xr = 0;

                while (!termino)
                {
                    if (parametros.Finalizo)
                    {
                        Xr = CalcularXrBiseccion(limitizquierdo, limitederecho);
                    }
                    else
                    {
                        Xr = CalcularXrReglaFalsa(limitizquierdo, limitederecho);
                    }
                    cInteraciones++;

                    error = Math.Abs((Xr - antXr) / Xr); 

                  
                    if ((Math.Abs(Funcion(Xr)) < tolerancia) || (cInteraciones > iteraciones) || (Math.Abs(error) < tolerancia))
                    {
                        resultado.Raiz = Xr;
                        termino = true;
                    }
                    else
                    {
                        if (Funcion(limitizquierdo) * (Funcion(Xr)) < 0)
                        {
                            limitederecho = Xr;
                        }
                        else
                        {
                            limitizquierdo = Xr;
                        }
                        antXr = Xr;
                    }

                }
                resultado.Iteraciones = cInteraciones;
                error = Math.Abs(error);
                resultado.Error = error;
                resultado.Observacion = "";
            }

            return resultado;
        }

    }
}   
