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
    public partial class frmPlata : Form
    {

       

        public frmPlata()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void FrmHabitacion_Load(object sender, EventArgs e)
        {
            MessageBox.Show("En el próximo formulario sólo se le dará a conocer la información de la habitación tipo Plata.");
        }

        private void LblTimer_Click(object sender, EventArgs e)
        {
            
        }

        private void PicInfo_Click(object sender, EventArgs e)
        {

        }

        private void TmCambio_Tick(object sender, EventArgs e)
        {
           
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
