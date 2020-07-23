using System;
using System.Windows.Forms;

namespace programaweb24
{
    public partial class HistorialPC : Form
    {
        private String idPC
        { set; get; }
        private String descrip
        { set; get; }
        public HistorialPC(ref String ExID, ref String descripPC)
        {
            idPC = ExID;
            descrip = descripPC;

            InitializeComponent();
        }

        



        private void buttonHistorial_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void listarHIstorial(String nID)
        {
            computadoraclass computadores = new computadoraclass();
            dataGridView13.DataSource = computadores.HistorialPC(nID);
        }
        public void listarHistorialFecha(String nID, String dateFiltro)
        {
            computadoraclass computadores = new computadoraclass();
            dataGridView13.DataSource = computadores.HistorialPCxFecha(nID, dateFiltro);

        }


        private void HistorialPC_Load(object sender, EventArgs e)
        {
            listarHIstorial(idPC);

            labelID.Text = ("ID de PC: " + idPC);
            labelDescrip.Text = ("Descripcion de PC: " + descrip);
        }

        private void FiltrarFecha_Click(object sender, EventArgs e)
        {
            DateTime datem = dateTimePicker1.Value;
            String formato = "yyyy-MM-dd";

            String dateFinal = datem.ToString(formato);

            listarHistorialFecha(idPC, dateFinal);
        }

       
    }
}
