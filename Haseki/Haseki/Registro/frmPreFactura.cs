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
    public partial class frmPreFactura : Form
    {
        public SqlConnection cn;
        public frmPreFactura()
        {
            InitializeComponent();
            cn = new SqlConnection("Data Source=DESKTOP-NE9KM9Q\\SQLEXPRESS;Initial Catalog=Hotel_Paso;Integrated Security=True");
            cn.Open();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmOpcionAdmin a = new frmOpcionAdmin();
            a.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("Select * from Reserva where Estado=1 AND Reserva_Id='" + txtReserva.Text + "'", cn);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                frmFactura a = new frmFactura(txtReserva.Text);
                a.Show();
                this.Close();
            }
            else 
            {
                MessageBox.Show("Reserva no encontrada para facturar", "ALERTA");
                this.Close();
            }
        }
    }
}
