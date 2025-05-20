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
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtEspecialidad.Text) ||
                cmbEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor completa todos los campos.");
                return;
            }

            try
            {
                SqlConnection con = ConexionBD.ObtenerConexion();
                if (con.State == ConnectionState.Closed)
                    con.Open();

                string query = "INSERT INTO Instructores (Nombre, Apellido, Especialidad, Horario, Estado) " +
                               "VALUES (@Nombre, @Apellido, @Especialidad, @Horario, @Estado)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@Apellido", txtApellido.Text);
                    cmd.Parameters.AddWithValue("@Especialidad", txtEspecialidad.Text);
                    cmd.Parameters.AddWithValue("@Horario", dtpHorario.Value);
                    cmd.Parameters.AddWithValue("@Estado", cmbEstado.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Instructor registrado correctamente.");
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar: " + ex.Message);
            }
        }

        private void btnIrAEliminar_Click(object sender, EventArgs e)
        {
            FrmEliminarInstructor eliminar = new FrmEliminarInstructor();
            eliminar.Show();
        }
    }
}

