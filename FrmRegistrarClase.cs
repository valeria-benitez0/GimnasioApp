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
            ClaseRepository repo = new ClaseRepository();

            if (string.IsNullOrWhiteSpace(txtNombreClase.Text) ||
                string.IsNullOrWhiteSpace(txtDescripcion.Text) ||
                string.IsNullOrWhiteSpace(txtDuracion.Text) ||
                string.IsNullOrWhiteSpace(txtCapacidad.Text) ||
                cmbDificultad.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor completa todos los campos.");
                return;
            }

            bool exito = repo.RegistrarClase(
                txtNombreClase.Text,
                txtDescripcion.Text,
                int.Parse(txtDuracion.Text),
                cmbDificultad.Text,
                int.Parse(txtCapacidad.Text)
            );

            if (exito)
                MessageBox.Show("Clase registrada correctamente.");
            else
                MessageBox.Show("Error al registrar clase.");
        }
    }
}
