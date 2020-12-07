using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Haseki
{
    public partial class frmOpcionAdmin : Form
    {
        public frmOpcionAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAdminHab a = new frmAdminHab();
            a.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmSalida a = new frmSalida();
            a.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmProductoRegis a = new frmProductoRegis();
            a.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            frmPreFactura a = new frmPreFactura();
            a.Show();
            this.Close();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
