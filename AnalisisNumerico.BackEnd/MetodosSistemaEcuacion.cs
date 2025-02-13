﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisisNumerico.BackEnd
{
    public class MetodosSistemaEcuacion
    {
    
        public ResultadoEcuaciones GaussJordan(ParametrosEcuaciones parametros)
        {
            var resultado = new ResultadoEcuaciones();

            double[,] matriz = new double[parametros.NumIncognitas, parametros.NumIncognitas + 1];

            var columna = 0;
            var fila = 0;

            //Cargo la matriz
            foreach (var item in parametros.Coeficientes)
            {
                matriz[fila, columna] = item;
                if (columna < parametros.NumIncognitas)
                {
                    columna++;
                }
                else
                {
                    fila++;
                    columna = 0;
                }
            }

            fila = 0;
            columna = 0;

            ControlarPivotEsDistintoDe0(matriz, parametros.NumIncognitas); //Si el pivot no es 1 cambia las columna.

            for (int f = 0; f < parametros.NumIncognitas; f++)
            {
                for (int c = 0; c < parametros.NumIncognitas + 1; c++)
                {
                    if (f == c)
                    {
                        if ((matriz[f, c] != 0) && (f + 1 < parametros.NumIncognitas))
                        {
                            VerificarSiElPivotEs1(matriz, parametros.NumIncognitas, f, c); //Si el pivot es != de 1 lo hace 1.

                            PrimerBloque(matriz, parametros.NumIncognitas, f + 1, c); //Primer columna los hace todos 0 menos el pivot
                        }
                        else if (parametros.NumIncognitas - 1 > f)
                        {
                            CambiarFilaSiElPivotEs0(matriz, parametros.NumIncognitas + 1, f); //Si el pivot es 0 y es una fila del medio la cambia por una de abajo   //ver
                        }
                        else
                        {
                            VerificarSiElPivotEs1(matriz, parametros.NumIncognitas, f, c); //Si el pivot es != de 1 lo hace 1.
                        }
                    }
                }
            }

            for (int f = 0; f < parametros.NumIncognitas; f++)
            {
                for (int c = 0; c < parametros.NumIncognitas + 1; c++)
                {
                    if (c > f && c < parametros.NumIncognitas)
                    {
                        SegundoBloque(matriz, parametros.NumIncognitas, f, c);
                    }
                }
            }

            resultado.Resultados = null;
            resultado.Resultados = new List<double>();

            for (int f = 0; f < parametros.NumIncognitas; f++)
            {
                for (int c = 0; c < parametros.NumIncognitas + 1; c++)
                {
                    if (c == parametros.NumIncognitas)
                    {
                        var x = matriz[f, c];
                        resultado.Resultados.Add(x);
                    }

                }
            }

            return resultado;
        }

        private void ControlarPivotEsDistintoDe0(double[,] m, int coeficiente)
        {
            if (m[0, 0] == 0)
            {
                var indice = 1;
                while (m[0, indice] != 0 && indice <= coeficiente)
                {
                    var fila = 0; var columna = 0;
                    double aux = 0;
                    for (int i = 0; i < coeficiente; i++)
                    {
                        aux = m[fila, columna];
                        m[fila, columna] = m[fila, indice];
                        m[fila, indice] = aux;
                        fila++;
                    }
                    break;
                }
                indice++;
            }
        }

        private void VerificarSiElPivotEs1(double[,] m, int numIncog, int f, int c)
        {
            if (m[f, c] != 1)
            {
                double valorPivot = 1 / m[f, c];
                for (int i = 0; i < numIncog + 1; i++)
                {
                    m[f, i] = m[f, i] * valorPivot;
                }
            }
        }

        private void PrimerBloque(double[,] m, int numIncognitas, int fil, int colum)
        {
            var auxFila = 0;
            var fila = fil;
            var columna = colum;
            bool corte = false;

            while (!corte)
            {
                auxFila++;
                if (fila < numIncognitas)
                {
                    var valor = m[fila, columna];

                    for (int i = 0; i <= (numIncognitas - colum); i++)
                    {
                        var operar = (m[fila, columna]);
                        m[fila, columna] = (operar - (valor * m[fila - auxFila, columna]));
                        columna++;
                    }
                    fila++;
                    columna = colum;
                    if (fila >= numIncognitas)
                    {
                        corte = true;
                        break;
                    }
                }
                else
                {
                    corte = true;
                    break;
                }
            }
        }

        private void CambiarFilaSiElPivotEs0(double[,] m, int numIncognitas, int f)
        {
            double aux = 0;
            for (int i = 0; i < numIncognitas; i++)
            {
                aux = m[f, i];
                m[f, i] = m[f + 1, i];
                m[f + 1, i] = aux;
            }
        }

        private void SegundoBloque(double[,] m, int numIncognitas, int fil, int colum)
        {
            var fila = fil;
            var columna = colum;

            if (m[fila, columna] != 0)
            {
                var valor = m[fila, columna];

                for (int i = 0; i <= numIncognitas - colum; i++)
                {
                    var operar = (m[fila, columna]);
                    m[fila, columna] = (operar - (valor * m[colum, columna]));
                    columna++;
                }
            }
        }




        public ResultadoEcuacionesMatriz GaussSeidel(double[,] matriz, ParametrosEcuaciones param)
        {
            int DD = 0;
            for (int x = 0; x < param.NumIncognitas; x++)
            {
                double sum = 0;
                for (int y = 0; y < param.NumIncognitas; y++)
                {
                    if (x != y)
                        sum += matriz[x, y];
                }
                if (Math.Abs(sum) < Math.Abs(matriz[x, x]))
                    DD++;
            }

            if (DD == 0)
                return null;

            double tolerancia = param.Tolerancia;
            int iteraciones = param.Iteraciones;
            int contador = 0;

            double[] Resultado = new double[param.NumIncognitas];
            double auxiliar;
            double[] ResultadoAnterior = new double[param.NumIncognitas];
            bool flag = true;

            while (flag == true & iteraciones >= contador)
            {
                contador++;
                if (contador > 1)
                    Resultado.CopyTo(ResultadoAnterior, 0);

                for (int x = 0; x < param.NumIncognitas; x++)
                {
                    auxiliar = matriz[x, param.NumIncognitas];
                    for (int y = 0; y < param.NumIncognitas; y++)
                    {
                        if (x != y)
                            auxiliar -= (matriz[x, y] * Resultado[y]);
                    }
                    Resultado[x] = Convert.ToDouble(auxiliar) / Convert.ToDouble(matriz[x, x]); ;

                    if (Math.Abs(Resultado[x] - ResultadoAnterior[x]) <= tolerancia)
                    {
                        flag = false;
                    }
                }
            }
            ResultadoEcuacionesMatriz resultado = new ResultadoEcuacionesMatriz();
            resultado.convergio = !flag;
            resultado.iteraciones = contador;
            resultado.Resultados = Resultado;
            return resultado;
        }
    }
}
