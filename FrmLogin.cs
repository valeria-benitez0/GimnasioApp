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
            string email = txtEmail.Text.Trim();
            string contrasena = txtContrasena.Text.Trim();

            SqlConnection con = ConexionBD.ObtenerConexion();
            if (con.State == ConnectionState.Closed)
                con.Open();

            // 1. Buscar en Miembros
            string queryMiembro = "SELECT * FROM Miembros WHERE Email = @Email AND Contrasena = @Contrasena";
            SqlCommand cmd1 = new SqlCommand(queryMiembro, con);
            cmd1.Parameters.AddWithValue("@Email", email);
            cmd1.Parameters.AddWithValue("@Contrasena", contrasena);

            SqlDataReader reader1 = cmd1.ExecuteReader();

            if (reader1.Read())
            {
                MessageBox.Show("Bienvenido Miembro: " + reader1["Nombre"]);
                string nombre = reader1["Nombre"].ToString();
                FrmMenuMiembro menuMiembro = new FrmMenuMiembro(nombre); 
                menuMiembro.Show();
                this.Hide();
                con.Close();
                return;
            }
            reader1.Close();

            // 2. Buscar en Instructores
            string queryInstructor = "SELECT * FROM Instructores WHERE Email = @Email AND Contrasena = @Contrasena";
            SqlCommand cmd2 = new SqlCommand(queryInstructor, con);
            cmd2.Parameters.AddWithValue("@Email", email);
            cmd2.Parameters.AddWithValue("@Contrasena", contrasena);

            SqlDataReader reader2 = cmd2.ExecuteReader();

            if (reader2.Read())
            {
                MessageBox.Show("Bienvenido Instructor: " + reader2["Nombre"]);
                FrmMenuInstructor menuInstructor = new FrmMenuInstructor(); // Este sí puede tener el botón de Registrar Clase
                menuInstructor.Show();
                this.Hide();
                con.Close();
                return;
            }
            reader2.Close();

            // Si no lo encontró en ninguna tabla:
            MessageBox.Show("Email o contraseña incorrectos.");
            con.Close();
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