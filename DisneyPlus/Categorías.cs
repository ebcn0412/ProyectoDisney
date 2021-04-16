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
    public partial class Categorías : Form
    {
        public Categorías()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //-------aqui hacemos el cambio de form--------------
            Form formMarvel = new marvel();
            formMarvel.Show();
            this.Hide();
            //--------------------------------------------------
        }

        private void button2_Click(object sender, EventArgs e)
        {
            natgeo minat = new natgeo();
            minat.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Pixar pixi = new Pixar();
            pixi.Show();
            this.Hide();
        }
    }
}
