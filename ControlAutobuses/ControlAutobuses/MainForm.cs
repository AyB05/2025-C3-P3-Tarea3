using System;
using System.Linq;
using System.Windows.Forms;

namespace ControlAutobuses
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnChoferForm_Click(object sender, EventArgs e)
        {
            //    ChoferForm choferForm = new ChoferForm();
            //      choferForm.Show();
           Form choferForm = Application.OpenForms.OfType<ChoferForm>().FirstOrDefault();

            if (choferForm == null)
            {
                // Si no está abiertocrea una nueva instancia y muéstrala
                choferForm = new ChoferForm();
                choferForm.Show();
            }
            else
            {
                // Si ya está abierto trae la ventana al frente
                choferForm.BringToFront();
            }
        }

        private void btnAutobusForm_Click(object sender, EventArgs e)
        {
            //AutobusForm autobusForm = new AutobusForm();
            //autobusForm.Show();
            Form autobusForm = Application.OpenForms.OfType<AutobusForm>().FirstOrDefault();

            if (autobusForm == null)
            {
                autobusForm = new AutobusForm();
                autobusForm.Show();
            }
            else
            {
                autobusForm.BringToFront();
            }
        }

        private void btnRutaForm_Click(object sender, EventArgs e)
        {
            //RutaForm rutaForm = new RutaForm();
            //rutaForm.Show();
            Form rutaForm = Application.OpenForms.OfType<RutaForm>().FirstOrDefault();

            if (rutaForm == null)
            {
                rutaForm = new RutaForm();
                rutaForm.Show();
            }
            else
            {
                rutaForm.BringToFront();
            }
        }

        private void btnAsignacionForm_Click(object sender, EventArgs e)
        {
            //AsignacionForm asignacionForm = new AsignacionForm();
            //asignacionForm.Show();
            Form asignacionForm = Application.OpenForms.OfType<AsignacionForm>().FirstOrDefault();

            if (asignacionForm == null)
            {
                asignacionForm = new AsignacionForm();
                asignacionForm.Show();
            }
            else
            {
                asignacionForm.BringToFront();
            }
        }
    }
    
}
