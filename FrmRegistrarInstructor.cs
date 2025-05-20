using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GimnasioApp
{
    public partial class FrmRegistrarInstructor : Form
    {
        public FrmRegistrarInstructor()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            var repo = new InstructorRepository();

            bool exito = repo.RegistrarInstructor(
                txtNombre.Text,
                txtApellido.Text,
                txtEspecialidad.Text,
                dtpHorario.Value,
                cmbEstado.Text
            );

            if (exito)
                MessageBox.Show("Instructor registrado correctamente.");
            else
                MessageBox.Show("Error al registrar instructor.");
        }

        private void btnIrAEliminar_Click(object sender, EventArgs e)
        {
            FrmEliminarInstructor eliminar = new FrmEliminarInstructor();
            eliminar.Show();
        }
    }
}

