using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;

namespace GimnasioApp
{
    public partial class FrmEliminarClase : Form
    {
        public FrmEliminarClase()
        {
            InitializeComponent();
        }

        private void btnEliminarClase_Click(object sender, EventArgs e)
        {
            ClaseRepository repo = new ClaseRepository();

            if (int.TryParse(txtIDClase.Text, out int id))
            {
                bool exito = repo.EliminarClase(id);

                if (exito)
                    MessageBox.Show("Clase eliminada correctamente.");
                else
                    MessageBox.Show("No se encontró una clase con ese ID.");
            }
            else
            {
                MessageBox.Show("Por favor ingresa un ID válido.");
            }
        }
    }
}
