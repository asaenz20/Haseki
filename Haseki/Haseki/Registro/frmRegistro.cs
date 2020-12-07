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
    public partial class frmRegistro : Form
    {
        public SqlConnection cn;
        public frmRegistro()
        {
            InitializeComponent();
            cn = new SqlConnection("Data Source=DESKTOP-NE9KM9Q\\SQLEXPRESS;Initial Catalog=Hotel_Paso;Integrated Security=True");
            cn.Open();
        }
        public void LimpiarClave() 
        {
            txtContraseña.Clear();
            txtContraseñaV.Clear();
            txtContraseña.Focus();
        }
        public void LimpiarTodo() 
        {
            txtId.Clear();
            txtNombre.Clear();
            txtContraseña.Clear();
            txtContraseñaV.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Si las contraseñas coinciden, entonces...
            if (txtContraseña.Text.Equals(txtContraseñaV.Text))
            {
                //Ahora traiga todos los clientes registrados, si al menos uno coincide con una id, quiere decir
                //que el cliente que se registrara ya se encuentra registrado
                SqlCommand cmd = new SqlCommand("Select * From Cliente where Cliente_Id='" + txtId.Text + "'", cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                //Si encuentra al menos 1 registro con esa id, entonces...
                if (dt.Rows.Count != 0)
                {
                    //Ya que la id esta ya registrada y no puede haber 2 clientes con el mismo id
                    MessageBox.Show("La persona ya se encuentra registrada");
                    LimpiarTodo();
                }
                //Si no encontro a alguien registrado con ese id, entonces
                else
                { 
                    //inserte todos los valores del cliente, en la tabla cliente para completa el registro...
                    SqlCommand cmdi = new SqlCommand("insert into Cliente values('" + txtId.Text + "','" + txtNombre.Text + "','" + txtCorreo.Text
                    + "','" + txtContraseña.Text + "','" + cmbPago.Text + "')", cn);
                    cmdi.ExecuteNonQuery();
                    MessageBox.Show("Registro exitoso");
                    this.Close();
                }
            }
            //Y si las claves no coinciden...
            else
            {
                LimpiarClave();
                MessageBox.Show("ERROR, LAS CONTRASEÑAS NO COINCIDEN");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
