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
    public partial class marvel : Form
    {
        public marvel()
        {
            InitializeComponent();

            //MARVEL
            listamarvel.Add("falcon y el soldado del invierno"); listamarvel.Add("wanda vision"); listamarvel.Add("antman");
            listamarvel.Add("avengers"); listamarvel.Add("black panter"); listamarvel.Add("captain marvel");
            listamarvel.Add("avengers endgame"); listamarvel.Add("spider man"); listamarvel.Add("agents of shield");
            listamarvel.Add("captain carter "); listamarvel.Add(""); listamarvel.Add("");
            listamarvel.Add("runaways"); listamarvel.Add("punisher"); listamarvel.Add("616"); listamarvel.Add("legends");
            //para cargar mi lista siempre
            foreach (string elemento in hola.pilaMiLista)
            {
                txtMarv.Text = elemento;
            }
        }
        string variable;
        decisionMarvel hola = new decisionMarvel();
        Categorías regreso = new Categorías();
        List<string> listamarvel = new List<string>();




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }



        private void button4_Click(object sender, EventArgs e)
        {
            //falcon
            variable = "falcon y el soldado del invierno";
            hola.txtDato.Text = variable;
            hola.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //wanda vision
            variable = "wanda vision";
            hola.txtDato.Text = variable;
            hola.Show();
            this.Hide();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            //ant man
            variable = "antman";
            hola.txtDato.Text = variable;
            hola.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //avengers
            variable = "avengers";
            hola.txtDato.Text = variable;
            hola.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //black panter
            variable = "black panter";
            hola.txtDato.Text = variable;
            hola.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //captain marvel
            variable = "captain marvel";
            hola.txtDato.Text = variable;
            hola.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //avengers endgame
            variable = "avengers endgame";
            hola.txtDato.Text = variable;
            hola.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //spider man
            variable = "spider man";
            hola.txtDato.Text = variable;
            hola.Show();
            this.Hide();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //agents of shield
            variable = "agents of shield";
            hola.txtDato.Text = variable;
            hola.Show();
            this.Hide();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //captain carter
            variable = "captain carter";
            hola.txtDato.Text = variable;
            hola.Show();
            this.Hide();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //runaways
            variable = "runaways";
            hola.txtDato.Text = variable;
            hola.Show();
            this.Hide();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //punisher
            variable = "punisher";
            hola.txtDato.Text = variable;
            hola.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //616
            variable = "616";
            hola.txtDato.Text = variable;
            hola.Show();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //legends
            variable = "legends";
            hola.txtDato.Text = variable;
            hola.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            foreach(string elemento in listamarvel)
            {
                if (elemento.Equals(txtReproducir.Text))
                {
                    MessageBox.Show("Si existe la pelicula: "+txtReproducir.Text);

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
