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
    public partial class frmLogin_Cliente : Form
    {
        public String id_aux;
        public SqlConnection cn;
        public frmLogin_Cliente()
        {
            InitializeComponent();
            cn=new SqlConnection("Data Source=DESKTOP-NE9KM9Q\\SQLEXPRESS;Initial Catalog=Hotel_Paso;Integrated Security=True");
            cn.Open();
        }

        public frmLogin_Cliente(string pene) 
        {
            InitializeComponent();
            id_aux = pene;
            cn = new SqlConnection("Data Source=DESKTOP-NE9KM9Q\\SQLEXPRESS;Initial Catalog=Hotel_Paso;Integrated Security=True");
            cn.Open();
        }
        void limpiar()
        {
            txtcontraseña.Clear();
            txtId.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Traiga al cliente cuya clave y contraseña coincidan con las ingresadas en los textbox
            SqlCommand cmd = new SqlCommand("Select * from Cliente where Cliente_Id='" + txtId.Text + "'AND Contraseña='" + txtcontraseña.Text + "'", cn);
            SqlDataAdapter dat = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dat.Fill(dt);
            //Si encontro ya registrado al cliente, entonces...
            if (dt.Rows.Count != 0)
                {
                //Esta es muy importante, es por asi decirlo el comprobante de la sesion esta iniciada
                //Es decir, a partir de la id tomada, se exportara a eliminar reserva y ver el estado de reserva siendo 
                //un atributo publico para dichos frames
                id_aux=dt.Rows[0][0].ToString();
                //Ahora muestre el menu de inicio de sesion
                frmClienteSesion a = new frmClienteSesion(id_aux);
                a.Show();
                this.Hide();
            }
            //Si no encontro ningun registro que coincida la clave y la contraseña entonces...
            else 
            {
                MessageBox.Show("Identificacion o Contraseña incorrectas");
                limpiar();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }
    }
}
