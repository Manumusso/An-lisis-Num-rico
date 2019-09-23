using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnalisisNumerico.BackEnd;

namespace AnalisisNumerico.Front
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = int.Parse(TextBox_NumIncogn.Text);
            dataGridView1.ColumnCount = int.Parse(TextBox_NumIncogn.Text) + 1;
        }

        private void label_NumIncon_Click(object sender, EventArgs e)
        {

        }

        private void button_Calcular_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = null;
            dataGridView2.Rows.Clear();
            dataGridView2.Refresh();

            var prueba = new ParametrosEcuaciones { NumIncognitas = int.Parse((TextBox_NumIncogn.Text)) };
            var coef = new List<double>();
            //coef.Add(5); coef.Add(2); coef.Add(0); coef.Add(2);
            //coef.Add(2); coef.Add(1); coef.Add(-1); coef.Add(0);
            //coef.Add(2); coef.Add(3); coef.Add(-1); coef.Add(3);

            //recorre filas
            var cont = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                cont++;
                //recorre las celdas de la columnas
                if (cont <= int.Parse((TextBox_NumIncogn.Text)))
                { 
                    foreach (DataGridViewCell cel in row.Cells)
                    {
                        coef.Add(Convert.ToDouble(cel.Value));
                    }
                }
            }

            prueba.Coeficientes = coef;


            MetodosSistemaEcuacion Ejecutar = new MetodosSistemaEcuacion();
            var resultado = Ejecutar.GaussJordan(prueba);

 

            foreach (var item in resultado.Resultados)
            {
                dataGridView2.Rows.Add(item);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            dataGridView2.DataSource = null;
            dataGridView2.Rows.Clear();
            dataGridView2.Refresh();

            int NumIncognitas = int.Parse((TextBox_NumIncogn.Text));
            int x = -1;
            int y = -1;
            double[,] matriz = new double[NumIncognitas, NumIncognitas + 1];

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                x++;
                y = -1;
                foreach (DataGridViewCell cel in row.Cells)
                {
                    y++;
                    matriz[x,y] = Convert.ToDouble(cel.Value);
                }
            }

            var parametros = new ParametrosEcuaciones() { NumIncognitas = int.Parse((TextBox_NumIncogn.Text)), Tolerancia = double.Parse((tbError.Text)), Iteraciones = int.Parse((tbIterac.Text)) };

            MetodosSistemaEcuacion Ejecutar = new MetodosSistemaEcuacion();

            var resultado = Ejecutar.GaussSeidel(matriz, parametros);

            if (resultado == null) { 
                MessageBox.Show("Este sistemas no es diagonalmente dominante", "NO CONVERGE", MessageBoxButtons.OK);
                return;
            }

            if(!resultado.convergio)
            {
                MessageBox.Show("Este sistemas es diagonalmente dominante parcial y no converge", "NO CONVERGE", MessageBoxButtons.OK);
                return;
            }

            for (int i = 0; i < NumIncognitas; i++)
            {
                dataGridView2.Rows.Add(resultado.Resultados[i]);
            }
            label1.Text = "Iteraciones: " + resultado.iteraciones;
        }
    }
}
