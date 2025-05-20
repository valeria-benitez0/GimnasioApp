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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
        }

        private void btnInstructores_Click_1(object sender, EventArgs e)
        {
            FrmRegistrarInstructor instructor = new FrmRegistrarInstructor();
            instructor.Show();
        }

        private void btnClases_Click(object sender, EventArgs e)
        {
            FrmRegistrarClase clase = new FrmRegistrarClase();
            clase.Show();
        }
    }
}
