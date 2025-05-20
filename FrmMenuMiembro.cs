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
    public partial class FrmMenuMiembro : Form
    {
        public FrmMenuMiembro(string nombre)
        {
            InitializeComponent();
            lblBienvenida.Text = "¡Bienvenido, " + nombre + "!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Close();
        }
    }
}
