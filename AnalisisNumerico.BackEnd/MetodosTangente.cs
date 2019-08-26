using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using org.mariuszgromada.math.mxparser;

namespace AnalisisNumerico.BackEnd
{
    public class MetodosTangente : IMetodosRaices
    {
        //string Funcion 
        //int Iteraciones 
        //double Tolerancia 
        //double ValorIzquierdo 
        //double ValorDerecho 
        //bool Finalizo 

        

        public static double Calcular(Parametros parametros)
        {
            double replace = parametros.ValorDerecho;

            Function func = new Function("F(x) = " + parametros.Funcion);
            Expression ex = new Expression($"F({parametros.ValorDerecho})", func);

            var x = ex.calculate();
            var a = new StringToFormula();
            var funcionParametros = parametros.Funcion.ToUpper().Replace("X", replace.ToString());
            if (a.Eval(funcionParametros) == 0)
            {
                return replace;
            }
            var cont = 0;
            double replaceAnt = 0;

            double error, Xr;
            do
            {
                cont++;
                var FxniTol = parametros.Funcion.ToUpper().Replace("X", (replace + parametros.Tolerancia).ToString());
                var Fxni = parametros.Funcion.ToUpper().Replace("X", replace.ToString());
                var deri = (a.Eval(FxniTol) - a.Eval(Fxni)) / parametros.Tolerancia;
                Xr = (replace - a.Eval(Fxni)) / deri;
                error = Math.Abs(Xr - replaceAnt) / Xr;

                replaceAnt = Xr;
                replace = Xr;
            } while ((Math.Abs(a.Eval(parametros.Funcion.ToUpper().Replace("X", Xr.ToString()))) < parametros.Tolerancia)
                || cont > parametros.Iteraciones
                || error < parametros.Tolerancia);

            return Xr;            
        }

        public Parametros MetodoBiseccionReglaFalsa(Parametros parametros)
        {
            return null;
        }
    }
}
