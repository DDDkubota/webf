using System;
using System.Windows.Forms;

namespace programaweb24
{
    public partial class Control_PC : Form
    {
        public Control_PC()



        {
            this.MinimizeBox = true;
            InitializeComponent();
        }

        private void Control_PC_Load(object sender, EventArgs e)
        {
            listarPC();
        }

        private void listarPC()
        {
            computadoraclass computadores = new computadoraclass();
            dataGridView1.DataSource = computadores.listarPC();


        }


        private void buttonBackmenu_Click(object sender, EventArgs e)
        {
            this.Close();
            Usuario Sesion = Usuario.newinstance();
            String tipouser = Sesion.TipodeUsuario;
            new Menu(ref tipouser).Show();

        }

     
      

        private void buttonBLOQUEARPC_Click(object sender, EventArgs e)
        {
            String IDestado = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            String estadoPc = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            computadoraclass cbestado = new computadoraclass();
            Boolean res = cbestado.cambiarEstado(IDestado, estadoPc);
            if (res == true)
            {
                MessageBox.Show("Se ha cambiado el esatdo de la PC");
            }
            else
            {
                MessageBox.Show("no se a encontrado la PC");
            }
            listarPC();
        }

        private void buttonHistorialPC_Click(object sender, EventArgs e)
        {
            String IDestadoH = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            String descripPc = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            new HistorialPC(ref IDestadoH, ref descripPc).ShowDialog();

        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            listarPC();
        }
    }
}
