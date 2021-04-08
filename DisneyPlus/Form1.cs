using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DisneyPlus.CODIGO.USUARIO;
using DisneyPlus.CODIGO.LISTADOBLE;

namespace DisneyPlus
{
    public partial class Form1 : Form
    {
        int contador = 0;
        listadoble lista;
        public Form1()
        {
            InitializeComponent();
            lista = new listadoble();
        }
        private void limpiar()
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            contador = contador + 1;
            usuario vDato = new usuario(contador,textBox1.Text,textBox2.Text);
            lista.agregarAlFinal(vDato);
            MessageBox.Show("SU CODIGO DE USUARIO ES: "+contador);
            limpiar();
            Form formulario = new Form2();
            formulario.Show();
            this.Hide();


        }
    }
}
