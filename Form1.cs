using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programaweb24
{
    public partial class Form1 : Form
    { 
        //verificamos que tipo de usuario es Para dar acceso a ciertas partes del menu 
        public Form1(ref String b)
        {
            InitializeComponent();
            
            //si es un moderador ocultaremos las siguientes opciones del menu 
            if (b=="Moderador")
            {
                btnAE.Hide();
                btnDC.Hide();
               
            }

        
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)

        {
            new agrSaldo().Show();
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
           
        }
    }
}
