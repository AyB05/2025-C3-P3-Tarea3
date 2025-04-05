using BLL;
using EL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace ControlAutobuses
{
    public partial class AsignacionForm : Form
    {
        public AsignacionForm()
        {
            InitializeComponent();
            CargarDatos();
            CargarAsignaciones();
        }

        private void CargarAsignaciones()
        {
            dataGridViewAsignaciones.DataSource = BusControlService.ObtenerAsiganciones().ToDataTable();
        }

        private void CargarDatos()
        {
            // Obtener listas de choferes, autobuses y rutas desde BusControlManager
            List<Chofer> choferes = BusControlService.ObtenerChoferes();
            List<Autobus> autobuses = BusControlService.ObtenerAutobuses();
            List<Ruta> rutas = BusControlService.ObtenerRutas();

            // Asignar listas a los ComboBoxes
            cmbChoferes.DisplayMember = "Nombre"; // Propiedad para mostrar en el ComboBox
            cmbChoferes.ValueMember = "ID"; // Valor del elemento seleccionado

            cmbAutobuses.DisplayMember = "ID"; // Propiedad para mostrar en el ComboBox
            cmbAutobuses.ValueMember = "ID"; // Valor del elemento seleccionado

            cmbRutas.DisplayMember = "NombreRuta"; // Propiedad para mostrar en el ComboBox
            cmbRutas.ValueMember = "ID"; // Valor del elemento seleccionado

            cmbChoferes.DataSource = choferes;
            cmbAutobuses.DataSource = autobuses;
            cmbRutas.DataSource = rutas;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            //    int choferID = (int)cmbChoferes.SelectedValue;
            //    int autobusID = (int)cmbAutobuses.SelectedValue;
            //    int rutaID = (int)cmbRutas.SelectedValue;

            //    BusControlService.AsignarChoferAutobusRuta(choferID, autobusID, rutaID);
            //    CargarAsignaciones();
            //    MessageBox.Show("Asignación realizada correctamente");


            //-------------
            try
            {
                int choferID = (int)cmbChoferes.SelectedValue;  
                int autobusID = (int)cmbAutobuses.SelectedValue;
                int rutaID = (int)cmbRutas.SelectedValue;

                BusControlService.AsignarChoferAutobusRuta(choferID, autobusID, rutaID);

                MessageBox.Show("Asignación realizada correctamente.");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error de Asignación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CargarAsignaciones();
            //---------------
        }

        private void dataGridViewAsignaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
