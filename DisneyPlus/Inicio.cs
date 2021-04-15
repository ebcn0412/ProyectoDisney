﻿using System;
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
        List<string> listamarvel = new List<string>();
        List<string> listaNational = new List<string>();
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
            MessageBox.Show("TIENE MENOS DE 30 DIAS PRA VOLVER A PAGAR");
            limpiar();
            //MARVEL
            listamarvel.Add("falcon y el soldado del invierno"); listamarvel.Add("wanda vision"); listamarvel.Add("antman");
            listamarvel.Add("avengers"); listamarvel.Add("black panter"); listamarvel.Add("captain marvel");
            listamarvel.Add("avengers endgame"); listamarvel.Add("spider man"); listamarvel.Add("agents of shield"); 
            listamarvel.Add("captain carter "); listamarvel.Add(""); listamarvel.Add("");
            listamarvel.Add("runaways"); listamarvel.Add("punisher"); listamarvel.Add("616"); listamarvel.Add("legends");

            //national
            listaNational.Add("atlantis rising"); listaNational.Add("antes que sea tarde"); listaNational.Add("jane"); 
            listaNational.Add("dentro del okavango"); listaNational.Add("apollo"); listaNational.Add("la historia de dios"); 
            listaNational.Add("catastrofes aereas"); listaNational.Add("genios que cambiaron"); listaNational.Add("the hot zone");
            listaNational.Add("secretos en los oceanos");
            Form formulario = new Form2();
            formulario.Show();
            this.Hide();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}