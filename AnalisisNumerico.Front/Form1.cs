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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Calcular_Click(object sender, EventArgs e)
        {

            var parametros = new Parametros();
            // Se comprueba que no exista texbox sin datos
            if (String.IsNullOrWhiteSpace(textBox_Funcion.Text) ||
                String.IsNullOrWhiteSpace(textBox_Tolerancia.Text) ||
               String.IsNullOrWhiteSpace(textBox_Iteraciones.Text) ||
               String.IsNullOrWhiteSpace(textBox_ValorDerecho.Text) ||
               String.IsNullOrWhiteSpace(textBox_ValorIzquierdo.Text))
            {
                MessageBox.Show("Faltan ingresar datos", "Notificación", MessageBoxButtons.OK);
            }
            else
            {
                parametros.Funcion = textBox_Funcion.Text;
                parametros.Iteraciones = int.Parse(textBox_Iteraciones.Text);
                parametros.Tolerancia = double.Parse(textBox_Tolerancia.Text);
                parametros.ValorDerecho = double.Parse(textBox_ValorDerecho.Text);
                parametros.ValorIzquierdo = double.Parse(textBox_ValorIzquierdo.Text);
                //Prueba bisección
                parametros.Finalizo = true;


                MetodosBiseccion Ejecutar = new MetodosBiseccion();
                Resultados resultado = Ejecutar.MetodoBiseccionReglaFalsa(parametros);



                //textBox_Raiz.Text = MetodosTangente.Calcular(parametros).ToString();

                if (resultado.Observacion == "")
                {
                    textBox_Error.Text = resultado.Error.ToString();
                    textBox_IteracionesR.Text = resultado.Iteraciones.ToString();
                    textBox_Raiz.Text = resultado.Raiz.ToString();
                }
                else
                {
                    MessageBox.Show("Los extremos ingresados no son válidos", "Notificación", MessageBoxButtons.OK);
                }
            }
        }

        private void textBox_Raiz_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
