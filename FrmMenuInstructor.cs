using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GimnasioApp
{
    public partial class FrmMenuInstructor : Form
    {
        public FrmMenuInstructor()
        {
            InitializeComponent();
        }

        private void btnRegistrarClase_Click(object sender, EventArgs e)
        {
            FrmRegistrarClase frm = new FrmRegistrarClase();
            frm.Show();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Close(); // Cierra este menú
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmEliminarClase frm = new FrmEliminarClase();
            frm.Show();
        }
    }
}
