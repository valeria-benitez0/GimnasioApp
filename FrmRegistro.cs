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
            // Validar que las contraseñas coincidan
            if (txtContrasena.Text != txtConfirmar.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return;
            }

            try
            {
                SqlConnection con = ConexionBD.ObtenerConexion();
                con.Open();

                string query = "INSERT INTO Miembros (Nombre, Apellido, Email, Telefono, Fecha_nacimiento, Estado_Membresia, Contrasena) " +
                               "VALUES (@Nombre, @Apellido, @Email, @Telefono, @FechaNacimiento, 'Activa', @Contrasena)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@Apellido", txtApellido.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                    cmd.Parameters.AddWithValue("@FechaNacimiento", dtpNacimiento.Value);
                    cmd.Parameters.AddWithValue("@Contrasena", txtContrasena.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Usuario registrado exitosamente.");
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar: " + ex.Message);
            }
        }

        private void FrmRegistro_Load(object sender, EventArgs e)
        {

        }

        private void btnIrEliminar_Click(object sender, EventArgs e)
        {
            FrmEliminarMiembro eliminar = new FrmEliminarMiembro();
            eliminar.Show();
        }
    }
}
