using BLL;
using System;
using System.Windows.Forms;

namespace ControlAutobuses
{
    public partial class AutobusForm : Form
    {
        public AutobusForm()
        {
            InitializeComponent();
            CargarAutobuses();
        }

        private void CargarAutobuses()
        {
            dataGridViewAutobuses.DataSource = BusControlService.ObtenerAutobuses().ToDataTable();
        }

        private void btnAgregarAutobus_Click(object sender, EventArgs e)
        {
            string marca = txtMarca.Text;
            string modelo = txtModelo.Text;
            string placa = txtPlaca.Text;
            string color = txtColor.Text;
            int ano = int.Parse(txtAño.Text);

            BusControlService.AgregarAutobus(marca, modelo, placa, color, ano);
            CargarAutobuses();
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtPlaca.Text = "";
            txtColor.Text = "";
            txtAño.Text = "";
            MessageBox.Show("Autobús agregado correctamente");
        }

        private void lblMarca_Click(object sender, EventArgs e)
        {

        }

        private void lblModelo_Click(object sender, EventArgs e)
        {

        }

        private void lblPlaca_Click(object sender, EventArgs e)
        {

        }

        private void lblColor_Click(object sender, EventArgs e)
        {

        }

        private void lblAño_Click(object sender, EventArgs e)
        {

        }
    }
}
