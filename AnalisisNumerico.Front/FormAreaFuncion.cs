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
    public partial class FormAreaFuncion : Form
    {
        public FormAreaFuncion()
        {
            InitializeComponent();
        }

        private void buttEjecutar_Click(object sender, EventArgs e)
        {
            string f = txtFuncion.Text;
            double a = Convert.ToDouble(txtValora.Text);
            double b = Convert.ToDouble(txtValorb.Text);
            int? inter = null;

            if (!string.IsNullOrEmpty(txtInter.Text))
            {
                inter = Convert.ToInt32(txtInter.Text);
            }

            //var n = new MetodosArea();
            //if (radioButton1.Checked)
            //{
            //    txtResult.Text = "El area por Trapecio es: " + Convert.ToString(n.Trapecio(f, a, b));
            //}
            //else if (radioButton2.Checked)
            //{
            //    txtResult.Text = "El area por Trapecio multiple es: " + Convert.ToString(n.TrapecioMultiple(f, a, b, inter.Value));
            //}
            //else if (radioButton3.Checked)
            //{
            //    txtResult.Text = "El area por Simpson 1/3 es: " + Convert.ToString(n.Simpson13(f, a, b));

            //}
            //else if (radioButton4.Checked)
            //{
            //    txtResult.Text = "El area por Simpson 1/3 multiple es: " + Convert.ToString(n.Simpson13_Multiple(f, a, b, inter.Value));

            //}
            //else
            //{
            //    txtResult.Text = "El area por Simpson 3/8 es: " + Convert.ToString(n.Simpson38(f, a, b));

            //}
        }
    }
}
