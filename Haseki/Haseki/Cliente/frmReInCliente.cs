using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Haseki
{
    public partial class frmOpcionCliente : Form
    {
        public frmOpcionCliente()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmRegistro a = new frmRegistro();
            a.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            frmLogin_Cliente a = new frmLogin_Cliente();
            a.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
