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
    public partial class Pixar : Form
    {
        public Pixar()
        {
            InitializeComponent();

            listaPixar.Add("soul"); listaPixar.Add("onward"); listaPixar.Add("toy story");
            listaPixar.Add("bichos"); listaPixar.Add("monsters inc"); listaPixar.Add("buscando a nemo");
            listaPixar.Add("valiente"); listaPixar.Add("los increibles"); listaPixar.Add("forky asks a question");
            listaPixar.Add("pixar in real life"); listaPixar.Add("a celebration of the music from coco"); 
            listaPixar.Add("inside pixar");listaPixar.Add("the pixar story"); listaPixar.Add("pixar popcorn");
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
        List<string> listaPixar = new List<string>();


        private void button5_Click(object sender, EventArgs e)
        {

            foreach(string elemento in listaPixar)
            {
                if (elemento.Equals(txtReproducir.Text))
                {
                    MessageBox.Show("Si existe la pelicula: "+txtReproducir.Text);

                }
                
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
        //soul
        variable = "soul";
        hola.txtDato.Text = variable;
        hola.Show();
        this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
        //onward
        variable = "onward";
        hola.txtDato.Text = variable;
        hola.Show();
        this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
        //toy story
        variable = "toy story";
        hola.txtDato.Text = variable;
        hola.Show();
        this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
        //bichos
        variable = "bichos";
        hola.txtDato.Text = variable;
        hola.Show();
        this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
        //black panter
        variable = "monsters inc";
        hola.txtDato.Text = variable;
        hola.Show();
        this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
        //buscando a nemo
        variable = "buscando a nemo";
        hola.txtDato.Text = variable;
        hola.Show();
        this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
        //valiente
        variable = "valiente";
        hola.txtDato.Text = variable;
        hola.Show();
        this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
        //los increibles
        variable = "los increibles";
        hola.txtDato.Text = variable;
        hola.Show();
        this.Hide();
        }

        private void button18_Click(object sender, EventArgs e)
        {
        //forky asks a question
        variable = "forky asks a question";
        hola.txtDato.Text = variable;
        hola.Show();
        this.Hide();
        }

        private void button17_Click(object sender, EventArgs e)
        {
        //pixar in real life
        variable = "pixar in real life";
        hola.txtDato.Text = variable;
        hola.Show();
        this.Hide();
        }

        private void button16_Click(object sender, EventArgs e)
        {
        //a celebration of the music from coco
        variable = "a celebration of the music from coco";
        hola.txtDato.Text = variable;
        hola.Show();
        this.Hide();
    }

        private void button15_Click(object sender, EventArgs e)
        {
        //inside pixar
        variable = "inside pixar";
        hola.txtDato.Text = variable;
        hola.Show();
        this.Hide();
    }

        private void button13_Click(object sender, EventArgs e)
        {
        //the pixar story
        variable = "the pixar story";
        hola.txtDato.Text = variable;
        hola.Show();
        this.Hide();
    }

        private void button14_Click(object sender, EventArgs e)
        {
        //pixar popcorn
        variable = "pixar popcorn";
        hola.txtDato.Text = variable;
        hola.Show();
        this.Hide();
    }

        private void button6_Click(object sender, EventArgs e)
        {
        //regresar
        regreso.Show();
        this.Hide();
    }
    }
}
