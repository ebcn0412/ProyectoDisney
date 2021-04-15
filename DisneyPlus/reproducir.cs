using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisneyPlus
{
    public partial class reproducir : Form
    {
        public reproducir()
        {
            InitializeComponent();
        }

        Queue<string> colaReproducir = new Queue<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            colaReproducir.Enqueue(txtReproducir.Text);
            MessageBox.Show("Agregado a ver continuar viendo: " + txtReproducir.Text);

            foreach(string colita in colaReproducir)
            {
                txtVer.Text = colita|;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
