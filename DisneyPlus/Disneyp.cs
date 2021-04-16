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
    public partial class Disneyp : Form
    {
        public Disneyp()
        {
            InitializeComponent();
            //MARVEL
            listaDisney.Add("raya"); listaDisney.Add("flora y ulises"); listaDisney.Add("aladdin");
            listaDisney.Add("el rey leon"); listaDisney.Add("mulan"); listaDisney.Add("piratas del caribe");
            listaDisney.Add("malefica"); listaDisney.Add("la casa de raven"); listaDisney.Add("kim possible");
            listaDisney.Add("enredados otra vez la serie"); listaDisney.Add("bia"); listaDisney.Add("amphibia");
            listaDisney.Add("gravity falls");
            decisionMarvel pila = new decisionMarvel();
            //para cargar mi lista siempre
            foreach (string elemento in pila.pilaMiLista)
            {
                txtMarv.Text = elemento;
            }
        }

        string variable;
        Form salto = new decisionMarvel();
        decisionMarvel hola = new decisionMarvel();
        Categorías regreso = new Categorías();
        List<string> listaDisney = new List<string>();


        private void Disneyp_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            variable = "raya";
            hola.txtDato.Text = variable;
            hola.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            variable = "flora y ulises";
            hola.txtDato.Text = variable;
            hola.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            variable = "aladdin";
            hola.txtDato.Text = variable;
            hola.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            variable = "el rey leon";
            hola.txtDato.Text = variable;
            hola.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            variable = "malefica";
            hola.txtDato.Text = variable;
            hola.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            variable = "mulan";
            hola.txtDato.Text = variable;
            hola.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            variable = "piratas del caribe";
            hola.txtDato.Text = variable;
            hola.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            variable = "ralph el demoledor";
            hola.txtDato.Text = variable;
            hola.Show();
            this.Hide();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            variable = "amphibia";
            hola.txtDato.Text = variable;
            hola.Show();
            this.Hide();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            variable = "bia";
            hola.txtDato.Text = variable;
            hola.Show();
            this.Hide();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            variable = "enredados otra vez la serie";
            hola.txtDato.Text = variable;
            hola.Show();
            this.Hide();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            variable = "gravity falls";
            hola.txtDato.Text = variable;
            hola.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            variable = "kim possible";
            hola.txtDato.Text = variable;
            hola.Show();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            variable = "la casa de raven";
            hola.txtDato.Text = variable;
            hola.Show();
            this.Hide();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            regreso.Show();
            this.Hide();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            foreach (string elemento in listaDisney)
            {
                if (elemento.Equals(txtReproducir.Text))
                {
                    MessageBox.Show("Si existe la pelicula: " + txtReproducir.Text);

                }

            }
        }
    }
}
