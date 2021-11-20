using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TarCadenaDeCaracteres2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string original, salida;

        private void button1_Click(object sender, EventArgs e)
        {
            salida = invertircaracteres(original);
            txtCadenaInversa.Text = salida.ToString();

            //CONTAR PALABRAS DE LA CADENA

            txtContarPalabras.Text = "" + txtEntradaCadena.TextLength;


        }

        private void txtEntradaCadena_TextChanged(object sender, EventArgs e)
        {
            original = txtEntradaCadena.Text;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public string invertircaracteres(string original)
        {
            string invierte = "";
            for (int i = original.Length - 1; i >= 0; i--)
                invierte += original[i];
            return invierte;
        }
    }
}
