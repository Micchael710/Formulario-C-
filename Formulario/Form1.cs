using System;
using System.Windows.Forms;

namespace Formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // TIMER
            timer1.Interval = 1000;
            timer1.Enabled = true;

            timer1.Tick -= timer1_Tick;
            timer1.Tick += timer1_Tick;

            // BOTÓN GUARDAR
            btnGuardar.Click -= btnGuardar_Click;
            btnGuardar.Click += btnGuardar_Click;

            // COLUMNAS DEL DATAGRIDVIEW
            if (dgvEstudiante.Columns.Count == 0)
            {
                dgvEstudiante.Columns.Add("Codigo", "Código");
                dgvEstudiante.Columns.Add("Nombres", "Nombres");
                dgvEstudiante.Columns.Add("Apellidos", "Apellidos");
                dgvEstudiante.Columns.Add("Direccion", "Dirección");
                dgvEstudiante.Columns.Add("Celular", "Celular");
                dgvEstudiante.Columns.Add("Correo", "Correo Electrónico");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHoraActual.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            dgvEstudiante.Rows.Add(
                txtCodigo.Text,
                txtNombres.Text,
                txtApellidos.Text,
                txtDireccion.Text,
                txtCelular.Text,
                txtCorreo.Text
            );

            txtCodigo.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtDireccion.Clear();
            txtCelular.Clear();
            txtCorreo.Clear();

            txtCodigo.Focus();
        }
    }
}