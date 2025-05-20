using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GimnasioApp
{
    public partial class FrmRegistro : Form
    {
        public FrmRegistro()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string estado = cmbEstadoMembresia.SelectedItem.ToString();

            MiembroRepository repo = new MiembroRepository();

            bool exito = repo.RegistrarMiembro(
                txtNombre.Text,
                txtApellido.Text,
                txtEmail.Text,
                txtTelefono.Text,
                dtpNacimiento.Value,
                estado,
                txtContrasena.Text,
                "Miembro"
            );

            if (exito)
                MessageBox.Show("Miembro registrado correctamente.");
            else
                MessageBox.Show("Error al registrar miembro.");
        }

        private void btnIrEliminar_Click_1(object sender, EventArgs e)
        {
            FrmEliminarMiembro eliminar = new FrmEliminarMiembro();
            eliminar.Show();
        }

        private void FrmRegistro_Load(object sender, EventArgs e)
        {
            cmbEstadoMembresia.Items.Add("Activa");
            cmbEstadoMembresia.Items.Add("Inactiva");
            cmbEstadoMembresia.SelectedIndex = 0;
        }

        private void cmbEstadoMembresia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnIrModificar_Click(object sender, EventArgs e)
        {
            FrmModificarMiembro eliminar = new FrmModificarMiembro();
            eliminar.Show();
        }
    }
}