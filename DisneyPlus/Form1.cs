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
        List<string> listamarvel = new List<string>();
        public Form1()
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
            MessageBox.Show("TIENE MENOS DE 30 DIAS PRA VOLVER A PAGAR");
            limpiar();
            listamarvel.Add("falcon y el soldado del invierno"); listamarvel.Add("wanda vision"); listamarvel.Add("antman");
            listamarvel.Add("avengers"); listamarvel.Add("black panter"); listamarvel.Add("captain marvel");
            listamarvel.Add("avengers endgame"); listamarvel.Add("spider man"); listamarvel.Add("agents of shield"); 
            listamarvel.Add("captain carter "); listamarvel.Add(""); listamarvel.Add("");
            listamarvel.Add("runaways"); listamarvel.Add("punisher"); listamarvel.Add("616"); listamarvel.Add("legends");
            Form formulario = new Form2();
            formulario.Show();
            this.Hide();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
