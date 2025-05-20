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
using System.Windows.Forms;

namespace GimnasioApp
{
    public partial class FrmRegistrarClase : Form
    {
        public FrmRegistrarClase()
        {
            InitializeComponent();
        }

        private void btnRegistrarClase_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreClase.Text) ||
                string.IsNullOrWhiteSpace(txtDescripcion.Text) ||
                string.IsNullOrWhiteSpace(txtDuracion.Text) ||
                string.IsNullOrWhiteSpace(txtCapacidad.Text) ||
                cmbDificultad.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor completa todos los campos.");
                return;
            }

            try
            {
                SqlConnection con = ConexionBD.ObtenerConexion();
                if (con.State == ConnectionState.Closed)
                    con.Open();

                string query = "INSERT INTO Clases (nombre_clase, Descripcion, Duracion_min, Dificultad, Capacidad) " +
                               "VALUES (@Nombre, @Descripcion, @Duracion, @Dificultad, @Capacidad)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Nombre", txtNombreClase.Text);
                    cmd.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                    cmd.Parameters.AddWithValue("@Duracion", int.Parse(txtDuracion.Text));
                    cmd.Parameters.AddWithValue("@Dificultad", cmbDificultad.Text);
                    cmd.Parameters.AddWithValue("@Capacidad", int.Parse(txtCapacidad.Text));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Clase registrada correctamente.");
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar clase: " + ex.Message);
            }
        }

    }
}
