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
    public partial class frmClienteSesion : Form
    {
        public frmClienteSesion()
        {
            InitializeComponent();
        }
        public String Aux;
        public frmClienteSesion(String id) 
        {
            InitializeComponent();
            Aux = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmReserva a = new frmReserva(Aux);
            a.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmEstadoReserva a = new frmEstadoReserva(Aux);
            a.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmEliminarReserva a = new frmEliminarReserva(Aux);
            a.Show();
            this.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
