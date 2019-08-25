using AnalisisNumerico.BackEnd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using org.mariuszgromada.math.mxparser;

namespace AnalisisNumerico.BackEnd
{
    class MetodosBiseccion : MetodosRaices
    {

        private double CalcularXrBiseccion(double xi, double xd)
        {
            return (xi + xd) / 2;
        }

        private double CalcularXrReglaFalsa(double xi, double xd, string pfuncion)
        {
            return ((RetornarImagen(pfuncion, xd) * xi) - (RetornarImagen(pfuncion, xi) * xd)) / (RetornarImagen(pfuncion, xd) - RetornarImagen(pfuncion, xi));
        }

        /*public Resultados MetodoBiseccionReglaFalsa(Parametros parametros)
        {
            var funcion = new Function(parametros.Funcion);
            var arg1 = new Argument("x", parametros.ValorIzquierdo);
            var arg2= new Argument("x", parametros.ValorDerecho);

            var nombre = parametros.Funcion.Split('=')[0].Trim();

            var expres1 = new Expression(nombre, funcion, arg1);
            var expres2= new Expression(nombre, funcion, arg2);

            bool termino = false;

            Resultados resultado = new Resultados();
            resultado.Observacion = "";

            if (expres1.calculate() * expres2.calculate() > 0)
            {
                resultado.Observacion = "Ingrese otra vez los valores";
                termino = true;
            }
            else if (expres1.calculate() * expres2.calculate() == 0)
            {
                if (expres1.calculate() == 0)
                {
                    resultado.Raiz = parametros.ValorIzquierdo;
                }
                else
                {
                    resultado.Raiz = parametros.ValorDerecho;
                }
            }
            else
            {
                int cInteraciones = 0;
                double antXr = 0;
                double Erek1 = 0;
                double Xr = 0;

                while (!termino)
                {
                    if (parametros.Finalizo)
                    {
                        Xr = CalcularXrBiseccion(parametros.ValorIzquierdo, parametros.ValorDerecho);
                    }
                    else
                    {
                        Xr = CalcularXrReglaFalsa(parametros.ValorIzquierdo, parametros.ValorDerecho, parametros.Funcion);
                    }
                    cInteraciones++;

                    Erek1 = (Xr - antXr) / Xr; //Ver el caso que divide por 0

                    //var argumentoXr = new Argument("x", Xr);
                    //var expresionXr = new Expression(nombre, funcion, argumentoXr);

                    if ((Math.Abs((parametros.Funcion, Xr)) < parametros.Tolerancia) || (cInteraciones > parametros.Iteraciones) || (Math.Abs(Erel) < parametros.Tolerancia))
                    {
                        resultado.Raiz = Xr;
                        termino = true;
                    }
                    else
                    {
                        //var imagenvalorinicial = expresion1.calculate();
                        //var imagenvalorxr = RetornarImagen(parametros.Funcion, Xr);
                        if ((expres1.calculate()) * RetornarImagen(parametros.Funcion, Xr) > 0)
                        {
                            parametros.ValorIzquierdo = Xr;
                        }
                        else
                        {
                            parametros.ValorDerecho = Xr;
                        }
                        antXr = Xr;
                    }

                }
                resultado.Iteraciones = cInteraciones;
                resultado.Error = Math.Abs(Erek1);
            }
            return resultado;
        }*/
    }
}   
