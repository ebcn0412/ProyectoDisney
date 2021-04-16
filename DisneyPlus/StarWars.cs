using DisneyPlus.CODIGO.LISTADOBLE;
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
    public partial class StarWars : Form
    {
        public StarWars()
        {
            InitializeComponent();
            listaStar.Add("mandalorian"); listaStar.Add("star wars la resistencia"); listaStar.Add("star wars el ascenso de Skywalker");
            listaStar.Add("star wars los últimos jedi"); listaStar.Add("star wars el despertar de la fuerza"); 
            listaStar.Add("star wars la venganza de los sith");
            listaStar.Add("star wars el ataque de los clones"); listaStar.Add("star wars la amenaza fantasma"); 
            listaStar.Add("mandalorian la serie");
            listaStar.Add("star wars la guerra de los clones"); listaStar.Add("star wars rebels"); 
            listaStar.Add("star wars fuerzas del destino");
            listaStar.Add("star wars el legado"); listaStar.Add("lego star wars");
            decisionMarvel pila = new decisionMarvel();
            //para cargar mi lista siempre
            foreach (string elemento in pila.pilaMiLista)
            {
                //txtMarv.Text = elemento;
            }
        }

        string variable;
        Form salto = new decisionMarvel();
        decisionMarvel hola = new decisionMarvel();
        Categorías regreso = new Categorías();
        List<string> listaStar = new List<string>();


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //mandalorian
            variable = "mandalorian";
            hola.txtDato.Text = variable;
            hola.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //star wars la resistencia
            variable = "star wars la resistencia";
            hola.txtDato.Text = variable;
            hola.Show();
            this.Hide();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            //star wars el ascenso de Skywalker
            variable = "star wars el ascenso de Skywalker";
            hola.txtDato.Text = variable;
            hola.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //avengers
            variable = "star wars los últimos jedi";
            hola.txtDato.Text = variable;
            hola.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //black panter
            variable = "star wars el despertar de la fuerza";
            hola.txtDato.Text = variable;
            hola.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //captain marvel
            variable = "star wars la venganza de los sith";
            hola.txtDato.Text = variable;
            hola.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //avengers endgame
            variable = "star wars el ataque de los clones";
            hola.txtDato.Text = variable;
            hola.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //spider man
            variable = "star wars la amenaza fantasma";
            hola.txtDato.Text = variable;
            hola.Show();
            this.Hide();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //agents of shield
            variable = "star wars la guerra de los clones";
            hola.txtDato.Text = variable;
            hola.Show();
            this.Hide();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //captain carter
            variable = "star wars fuerzas del destino";
            hola.txtDato.Text = variable;
            hola.Show();
            this.Hide();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //
            variable = "star wars el legado";
            hola.txtDato.Text = variable;
            hola.Show();
            this.Hide();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //lego star wars
            variable = "lego star wars";
            hola.txtDato.Text = variable;
            hola.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //
            variable = "mandalorian";
            hola.txtDato.Text = variable;
            hola.Show();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //star wars rebels
            variable = "star wars rebels";
            hola.txtDato.Text = variable;
            hola.Show();
            this.Hide();
        }

        private void StarWars_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (string elemento in listaStar)
            {
                if (elemento.Equals(txtReproducir.Text))
                {
                    MessageBox.Show("Si existe la pelicula: " + txtReproducir.Text);

                }

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            regreso.Show();
            this.Hide();
        }
    }
}
