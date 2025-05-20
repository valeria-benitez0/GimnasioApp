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
            MiembroRepository repo = new MiembroRepository();

            if (int.TryParse(txtIDMiembro.Text, out int id))
            {
                bool exito = repo.EliminarMiembro(id);

                if (exito)
                    MessageBox.Show("Miembro eliminado correctamente.");
                else
                    MessageBox.Show("No se encontró un miembro con ese ID.");
            }
            else
            {
                MessageBox.Show("Por favor ingresa un ID válido.");
            }
        }

    }
}