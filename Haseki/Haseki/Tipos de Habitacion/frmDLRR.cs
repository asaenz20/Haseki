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
    public partial class frmDLRR : Form
    {
        public frmDLRR()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDLRR_Load(object sender, EventArgs e)
        {
            MessageBox.Show("En el próximo formulario sólo se le dará a conocer la información de la habitación tipo DLRR.");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
