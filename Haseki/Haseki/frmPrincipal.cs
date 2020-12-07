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
    
    public partial class frmPrincipal : Form
    {
        public int d = 0;
        public String id_aux;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void HabitacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void HabitaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPlata a = new frmPlata();
            a.Show();
        }

        private void HabitaciónOroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOro a = new frmOro();
            a.Show();
        }

        private void HabitaciónDiamanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDiamante a = new frmDiamante();
            a.Show();
        }

        private void HabitaciónDLRRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDLRR a = new frmDLRR();
            a.Show();
        }

        private void ReservarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOpcionCliente a = new frmOpcionCliente();
            a.Show();
        }

        private void btContinuar_Click(object sender, EventArgs e)
        {

           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por usar nuestros servicios!");
            this.Dispose();
        }

        private void estadoDeReservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdminLogin a = new frmAdminLogin();
            a.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {              //MessageBox.Show("Elija una opción dependiendo de su rol.");
           
        }
    }
}
