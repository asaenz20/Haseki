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
    public partial class frmAdminLogin : Form
    {
        public SqlConnection cn;
        public frmAdminLogin()
        {
            InitializeComponent();
            cn = new SqlConnection("Data Source=DESKTOP-NE9KM9Q\\SQLEXPRESS;Initial Catalog=Hotel_Paso;Integrated Security=True");
            cn.Open();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Encuentre un admnistrador que este relacionado con la clave y el id ingresados
            //SqlCommand cmd = new SqlCommand("Select * from Administrador where Admin_Id='" + txtId.Text 
            //    + "' AND Clave= '" + txtcontraseña.Text + "'" , cn);
            SqlCommand cmd = new SqlCommand("Select * from Administrador where Admin_Id='" + txtId.Text + "'AND Clave='" + txtcontraseña.Text + "'", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            //Si encontro a alguien que coincide con las dos en la tabla administrador
            if (dt.Rows.Count != 0) 
            {
                //Para que sea mas ADINERADO, muestre el nombre al ingresar sesion
                MessageBox.Show("Sesion iniciada , bienvenido " + " " + dt.Rows[0][1].ToString());
                frmOpcionAdmin a = new frmOpcionAdmin();
                a.Show();
                this.Close();
            }
            else 
            {
                MessageBox.Show("ERROR, IDENTIFICACION O CLAVE INCONSISTENTES");
                txtId.Clear();
                txtcontraseña.Clear();
            }
        }
    }
}
