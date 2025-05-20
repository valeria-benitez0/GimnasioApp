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

namespace GimnasioApp
{
    public partial class FrmEliminarInstructor : Form
    {
        public FrmEliminarInstructor()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIDInstructor.Text))
            {
                MessageBox.Show("Por favor ingresa el ID del instructor que deseas eliminar.");
                return;
            }

            try
            {
                SqlConnection con = ConexionBD.ObtenerConexion();
                if (con.State == ConnectionState.Closed)
                    con.Open();

                string query = "DELETE FROM Instructores WHERE IDInstructor = @ID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ID", int.Parse(txtIDInstructor.Text));
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                        MessageBox.Show("Instructor eliminado correctamente.");
                    else
                        MessageBox.Show("No se encontró un instructor con ese ID.");
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar instructor: " + ex.Message);
            }
        }

    }
}
