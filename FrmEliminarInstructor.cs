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
            var repo = new InstructorRepository();
            int id = int.Parse(txtIDInstructor.Text);

            if (repo.EliminarInstructor(id))
                MessageBox.Show("Instructor eliminado correctamente.");
            else
                MessageBox.Show("No se pudo eliminar el instructor.");
        }

    }
}
