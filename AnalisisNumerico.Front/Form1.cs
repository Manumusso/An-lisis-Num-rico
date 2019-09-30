using AnalisisNumerico.BackEnd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnalisisNumerico.BackEnd;
using System.Windows.Forms;

namespace AnalisisNumerico.Front
{
    enum Metodo
    {
        TANGENTE,
        BISECCION,
        REGLAFALSA,
        SECANTE,
    }
    public partial class Form1 : Form
    {
        Funcion Funcion;
        Metodo Metodo;

        public Form1()
        {
            InitializeComponent();
        }


        private void button_Calcular_Click(object sender, EventArgs e)
        {

            var parametros = new Parametros();
            // Se comprueba que no exista texbox sin datos
            if (
               String.IsNullOrWhiteSpace(textBox_ValorDerecho.Text) ||
               String.IsNullOrWhiteSpace(textBox_ValorIzquierdo.Text))
            {
                MessageBox.Show("Faltan ingresar datos", "Notificación", MessageBoxButtons.OK);
            }
            else
            {
                parametros.ValorDerecho = double.Parse(textBox_ValorDerecho.Text);
                parametros.ValorIzquierdo = double.Parse(textBox_ValorIzquierdo.Text);
                parametros.Iteraciones = int.Parse(textBox_Iteraciones.Text);
                parametros.Tolerancia = double.Parse(textBox_Tolerancia.Text);
                //Prueba bisección
                parametros.Finalizo = true;
                Resultados resultado;
                switch (Metodo)
                {
                    case Metodo.TANGENTE:
                        {
                            MetodosTangente Ejecutar = new MetodosTangente(Funcion);
                            if(Funcion == Funcion.PORTEXTO)
                            {
                                Ejecutar = new MetodosTangente(Funcion, tbFuncion.Text);
                            }
                            resultado = Ejecutar.Calcular(parametros);
                            break;
                        }
                    case Metodo.BISECCION:
                        {
                            MetodosBiseccion Ejecutar = new MetodosBiseccion(Funcion);
                            if (Funcion == Funcion.PORTEXTO)
                            {
                                Ejecutar = new MetodosBiseccion(Funcion, tbFuncion.Text);
                            }
                            resultado = Ejecutar.MetodoBiseccionReglaFalsa(parametros);
                            break;
                        }
                    case Metodo.REGLAFALSA:
                        {
                            MetodosBiseccion Ejecutar = new MetodosBiseccion(Funcion);
                            if (Funcion == Funcion.PORTEXTO)
                            {
                                Ejecutar = new MetodosBiseccion(Funcion, tbFuncion.Text);
                            }
                            parametros.Finalizo = false;
                            resultado = Ejecutar.MetodoBiseccionReglaFalsa(parametros);
                            break;
                        }
                    case Metodo.SECANTE:
                        {
                            MetodoSecante Ejecutar = new MetodoSecante(Funcion);
                            if (Funcion == Funcion.PORTEXTO)
                            {
                                Ejecutar = new MetodoSecante(Funcion, tbFuncion.Text);
                            }
                            resultado = Ejecutar.Calcular(parametros);
                            break;
                        }
                    default:
                        resultado = new Resultados();
                        break;
                }


                //textBox_Raiz.Text = MetodosTangente.Calcular(parametros).ToString();

                
                    textBox_Error.Text = resultado.Error.ToString();
                    textBox_IteracionesR.Text = resultado.Iteraciones.ToString();
                    textBox_Raiz.Text = resultado.Raiz.ToString();
                
            }
        }

        private void textBox_Raiz_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Funcion = Funcion.ACTIVIDAD1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Funcion = Funcion.ACTIVIDAD2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Funcion = Funcion.ACTIVIDAD3;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Funcion = Funcion.ACTIVIDAD4;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            Funcion = Funcion.ACTIVIDAD5A;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            Funcion = Funcion.ACTIVIDAD5B;
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            Funcion = Funcion.PARAPARCIAL;
        }



        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            Metodo = Metodo.TANGENTE;
        }
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            Metodo = Metodo.SECANTE;
        }
        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            Metodo = Metodo.BISECCION;
        }
        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            Metodo = Metodo.REGLAFALSA;
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            Funcion = Funcion.PORTEXTO;
        }
    }
}
