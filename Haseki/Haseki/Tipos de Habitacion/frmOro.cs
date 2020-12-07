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
    public partial class frmOro : Form
    {
        public frmOro()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void FrmOro_Load(object sender, EventArgs e)
        {
            MessageBox.Show("En el próximo formulario sólo se le dará a conocer la información de la habitación tipo Oro.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
