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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //-------aqui hacemos el cambio de form--------------
            Form formMarvel = new marvelMain();
            formMarvel.Show();
            this.Hide();
            //--------------------------------------------------
            
        }
    }
}
