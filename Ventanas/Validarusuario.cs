using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programaweb24.Ventanas
{
    public partial class Validarusuario : Form
    {
        public Validarusuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String usuario =this.textBox1.Text;

            HistorialUsuarios validar = new HistorialUsuarios();
            int respuesta= validar.validarsuspender(usuario);
            switch (respuesta)
            {
                case 1:
                    MessageBox.Show("Matricula Validada");
                    break;
                case 2:
                    MessageBox.Show("Matricula Suspendida");
                    break;
                default:
                    MessageBox.Show("Matricula no encontrada");
                    break;

            }

        }
    }
}
