using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using org.mariuszgromada.math.mxparser;

namespace AnalisisNumerico.BackEnd
{
    public enum Funcion
    {
        ACTIVIDAD1,
        ACTIVIDAD2,
        ACTIVIDAD3,
        ACTIVIDAD4,

        ACTIVIDAD5A,
        ACTIVIDAD5B
    }
    public class MetodosRaices
    {
        public Funcion actividad;

        public MetodosRaices(Funcion func)
        {
            actividad = func;
        }

        public double Funcion(double x)
        {
            switch (actividad)
            {
                case BackEnd.Funcion.ACTIVIDAD1:
                    {
                        return ((Math.Pow(x,5)-1)*Math.Pow(Math.E,x))-1;
                        break;
                    }
                case BackEnd.Funcion.ACTIVIDAD2:
                    {
                        return Math.Log(x) + (1 / x) - 3;
                        break;
                    }
                case BackEnd.Funcion.ACTIVIDAD3:
                    {
                        return ((15.2 * (x + 2)) / (Math.Pow(x, 2) + 4 * x + 5)) + 2;
                        break;
                    }
                case BackEnd.Funcion.ACTIVIDAD4:
                    {
                        return Math.Abs(Math.Pow(x, 2) - 4) + 2 * x; ;
                        break;
                    }
                case BackEnd.Funcion.ACTIVIDAD5A:
                    {
                        return Math.Pow(x,2)-3*x+Math.Log(1+x);
                        break;
                    }
                case BackEnd.Funcion.ACTIVIDAD5B:
                    {
                        return 5-(Math.Pow(x,0.5));
                        break;
                    }
                default:
                        return 0;
                    break;
            }

            
            // 
            

        }

    }

}

