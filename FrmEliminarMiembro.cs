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
    public partial class FrmEliminarMiembro : Form
    {
        public FrmEliminarMiembro()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIDMiembro.Text))
            {
                MessageBox.Show("Por favor ingresa el ID del miembro que deseas eliminar.");
                return;
            }

            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar este miembro?", "Confirmar", MessageBoxButtons.YesNo);
            if (resultado != DialogResult.Yes)
                return;

            try
            {
                SqlConnection con = ConexionBD.ObtenerConexion();
                con.Open();

                string query = "DELETE FROM Miembros WHERE IDMiembro = @ID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ID", int.Parse(txtIDMiembro.Text));
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                        MessageBox.Show("Miembro eliminado correctamente.");
                    else
                        MessageBox.Show("No se encontró un miembro con ese ID.");
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar miembro: " + ex.Message);
            }
        }

        private void FrmEliminarMiembro_Load(object sender, EventArgs e)
        {

        }
    }
}
