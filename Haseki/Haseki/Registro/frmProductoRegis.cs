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
    public partial class frmProductoRegis : Form
    {
        public SqlConnection cn;
        public frmProductoRegis()
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
            //Registre un producto con los campos anteriormente seleccionados
            SqlCommand cmd = new SqlCommand("Insert into Producto values('" + txtProId.Text + "','" + txtTipo_Producto.Text + "','" + txtPrecio.Text + "')", cn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Producto registrado con exito");
            frmOpcionAdmin a = new frmOpcionAdmin();
            a.Show();
            this.Close();
        }
    }
}
