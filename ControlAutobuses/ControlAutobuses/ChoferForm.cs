
using BLL;
using System;
using System.Windows.Forms;


namespace ControlAutobuses
{
    public partial class ChoferForm : Form
    {
        public ChoferForm()
        {
            InitializeComponent();
            CargarChoferes();
        }

        private void CargarChoferes()
        {
            dataGridViewChoferes.DataSource = BusControlService.ObtenerChoferes().ToDataTable();
        }

        private void ChoferForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarChofer_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreChofer.Text;
            string apellido = txtApellidoChofer.Text;
            DateTime fechaNacimiento = dtpFechaNacimiento.Value;
            string cedula = txtCedulaChofer.Text;

            BusControlService.AgregarChofer(nombre, apellido, fechaNacimiento, cedula);
            CargarChoferes();
            txtNombreChofer.Text = "";
            txtApellidoChofer.Text = "";
            txtCedulaChofer.Text = "";
            MessageBox.Show("Chofer agregado correctamente");
        }
    }
}
