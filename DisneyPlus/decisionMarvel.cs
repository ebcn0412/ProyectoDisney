﻿using System;
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
    public partial class decisionMarvel : Form
    {
        public decisionMarvel()
        {
            InitializeComponent();
        }
        Stack<string> pilaMiLista = new Stack<string>();
        marvel regreso = new marvel();
        private void button1_Click(object sender, EventArgs e)
        {
            pilaMiLista.Push(txtDato.Text);
            MessageBox.Show("Agregado a tu lista: "+txtDato.Text);
            regreso.Show();
            this.Hide();
        }
    }
}
