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
    public partial class natgeo : Form
    {
        public natgeo()
        {
            InitializeComponent();
            listaNational.Add("cosmos mundos posibles"); listaNational.Add("barkskins"); listaNational.Add("diana en primera persona");
            listaNational.Add("free solo"); listaNational.Add("un dia maravilloso en la tierra"); listaNational.Add("into the okavango");
            listaNational.Add("antes que sea tarde"); listaNational.Add("china misteriosa y salvaje"); listaNational.Add("the hot zone");
            listaNational.Add("one strange rock"); listaNational.Add("planeta hostil"); listaNational.Add("gordon Ramsay sabores extremos");
            listaNational.Add("la historia de dios"); listaNational.Add("tesoros perdidos de egipto");
            decisionMarvel pila = new decisionMarvel();

            //para cargar mi LISTA SIEMPRE 
            foreach(string elemento in pila.pilaMiLista)
            {
                txtNat.Text = elemento;
            }
        }
        Categorías regreso = new Categorías();
        List<string> listaNational = new List<string>();
        string variable;
        Form salto = new decisionMarvel();
        decisionMarvel hola = new decisionMarvel();

        
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            variable = "cosmos mundos posibles";
            hola.txtDato.Text = variable;
            hola.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //
            variable = "barkskins";
            hola.txtDato.Text = variable;
            hola.Show();
            this.Hide();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            variable = "diana en primera persona";
            hola.txtDato.Text = variable;
            hola.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //
            variable = "free solo";
            hola.txtDato.Text = variable;
            hola.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //un dia maravilloso en la tierra
            variable = "un dia maravilloso en la tierra";
            hola.txtDato.Text = variable;
            hola.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //into the okavango
            variable = "into the okavango";
            hola.txtDato.Text = variable;
            hola.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //antes que sea tarde
            variable = "antes que sea tarde";
            hola.txtDato.Text = variable;
            hola.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //china misteriosa y salvaje
            variable = "china misteriosa y salvaje";
            hola.txtDato.Text = variable;
            hola.Show();
            this.Hide();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //la historia de dios
            variable = "la historia de dios";
            hola.txtDato.Text = variable;
            hola.Show();
            this.Hide();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //planeta hostil
            variable = "planeta hostil";
            hola.txtDato.Text = variable;
            hola.Show();
            this.Hide();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //the hot zone
            variable = "the hot zone";
            hola.txtDato.Text = variable;
            hola.Show();
            this.Hide();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //one strange rock
            variable = "one strange rock";
            hola.txtDato.Text = variable;
            hola.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //gordon
            variable = "gordon Ramsay sabores extremos";
            hola.txtDato.Text = variable;
            hola.Show();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //egipto
            variable = "tesoros perdidos de egipto";
            hola.txtDato.Text = variable;
            hola.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            regreso.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (string elemento in listaNational)
            {
                if (elemento.Equals(txtReproducir.Text))
                {
                    MessageBox.Show("Si existe la pelicula: " + txtReproducir.Text);

                }

            }
        }
    }
}
