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
            textBox_Funcion.Text = "f(x)=((x^5)-1)e^x-10=0";
            textBox_Iteraciones.Text = "100";
            textBox_Tolerancia.Text = "0,0001";

            textBox_Funcion.Enabled = false;
            textBox_Iteraciones.Enabled = false;
            textBox_Tolerancia.Enabled = false;
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
                //Prueba bisección
                parametros.Finalizo = true;

                /*Prueba Regla Falsa
                 * 
                parametros.Finalizo = false;

                 */

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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
