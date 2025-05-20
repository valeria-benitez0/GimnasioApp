using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GimnasioApp
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string contrasena = txtContrasena.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(contrasena))
            {
                MessageBox.Show("Por favor ingresa tu email y contraseña.");
                return;
            }

            try
            {
                SqlConnection con = ConexionBD.ObtenerConexion();
                con.Open();

                string query = "SELECT * FROM Miembros WHERE Email = @Email AND Contrasena = @Contrasena";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Contrasena", contrasena);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        MessageBox.Show("Inicio de sesión exitoso. Bienvenido/a " + reader["Nombre"].ToString() + "!");
                    }
                    else
                    {
                        MessageBox.Show("Email o contraseña incorrectos.");
                    }
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesión: " + ex.Message);
            }
        }

        private void btnRegistrarse_Click_1(object sender, EventArgs e)
        {
            // Abre el formulario de registro
            using (FrmRegistro reg = new FrmRegistro())
            {
                this.Hide();
                reg.ShowDialog();
                this.Show();// Cuando el registro se cierra, vuelve a mostrar login
            }
        }
    }
}