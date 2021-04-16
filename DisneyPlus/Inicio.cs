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
    public partial class Inicio : Form
    {
        int contador = 0;
        listadoble lista;
        List<string> listaStar = new List<string>();
        List<string> listaDisney = new List<string>();
        public Inicio()
        {
            InitializeComponent();
            lista = new listadoble();
            textBox3.PasswordChar = '*';
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
            MessageBox.Show("PAGO REALIZADO A TIEMPO, EL SIGUIENTE SERA EN 30 DIAS");
            limpiar();


            //national
            listaNational.Add("atlantis rising"); listaNational.Add("antes que sea tarde"); listaNational.Add("jane"); 
            listaNational.Add("dentro del okavango"); listaNational.Add("apollo"); listaNational.Add("la historia de dios"); 
            listaNational.Add("catastrofes aereas"); listaNational.Add("genios que cambiaron"); listaNational.Add("the hot zone");
            listaNational.Add("secretos en los oceanos");
            Form formulario = new Categorías();
            formulario.Show();
            this.Hide();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
