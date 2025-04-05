using BLL;
using System;
using System.Windows.Forms;

namespace ControlAutobuses
{
    public partial class RutaForm : Form
    {
        public RutaForm()
        {
            InitializeComponent();
            CargarRutas();
        }


        private void CargarRutas()
        {
            dataGridViewRutas.DataSource = BusControlService.ObtenerRutas().ToDataTable();
        }

        private void btnAgregarRuta_Click(object sender, EventArgs e)
        {
            string nombreRuta = txtNombreRuta.Text;

            BusControlService.AgregarRuta(nombreRuta);
            CargarRutas();
            txtNombreRuta.Text = "";
            MessageBox.Show("Ruta agregada correctamente");
        }

        private void lblNombreRuta_Click(object sender, EventArgs e)
        {

        }

        private void RutaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
