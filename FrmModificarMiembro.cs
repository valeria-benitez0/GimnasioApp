using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GimnasioApp
{
    public partial class FrmModificarMiembro : Form
    {
        public FrmModificarMiembro()
        {
            InitializeComponent();
        }

        private void FrmModificarMiembro_Load(object sender, EventArgs e)
        {
            cmbEstadoMembresia.Items.Add("Activa");
            cmbEstadoMembresia.Items.Add("Inactiva");
            cmbEstadoMembresia.SelectedIndex = 0;

            cmbRol.Items.Add("Admin");
            cmbRol.Items.Add("Miembro");
            cmbRol.SelectedIndex = 1;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string email = txtEmail.Text;
            string telefono = txtTelefono.Text;
            DateTime fechaNacimiento = dtpFechaNacimiento.Value;
            string estado = cmbEstadoMembresia.SelectedItem.ToString();
            string rol = cmbRol.SelectedItem.ToString();

            MiembroRepository repo = new MiembroRepository();
            bool exito = repo.ModificarMiembro(id, nombre, apellido, email, telefono, fechaNacimiento, estado, rol);

            if (exito)
                MessageBox.Show("Miembro modificado correctamente.");
            else
                MessageBox.Show("Error al modificar el miembro.");
        }
    }
}
