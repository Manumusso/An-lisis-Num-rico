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

namespace AnalisisNumerico.FrontEnd.MetodosRaicesMenu
{
    public partial class MenuPrincipalRaices : Form
    {
        private readonly MetodosRaices metodosRaices;

        public MenuPrincipalRaices()
        {
            InitializeComponent();
            metodosRaices = new MetodosTangente();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Calcular_Click(object sender, EventArgs e)
        {
            
        }

        private void MenuPrincipalRaices_Load(object sender, EventArgs e)
        {

        }
    }
}
