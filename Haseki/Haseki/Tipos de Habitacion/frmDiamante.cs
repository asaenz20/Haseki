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
    public partial class frmDiamante : Form
    {
        public frmDiamante()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDiamante_Load(object sender, EventArgs e)
        {
            MessageBox.Show("En el próximo formulario sólo se le dará a conocer la información de la habitación tipo Diamante.");
        }
    }
}
