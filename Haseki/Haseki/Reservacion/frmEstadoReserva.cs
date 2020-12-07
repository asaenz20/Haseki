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
    public partial class frmEstadoReserva : Form
    {
        public SqlConnection cn;
        public String Aux_Id;
        public frmEstadoReserva()
        {
            InitializeComponent();
        //    cn = new SqlConnection("Data Source=DESKTOP-NE9KM9Q\\SQLEXPRESS;Initial Catalog=Hotel_Paso;Integrated Security=True");
        //    cn.Open();
            
        }
        public frmEstadoReserva(String id)
        {
            InitializeComponent();
            cn = new SqlConnection("Data Source=DESKTOP-NE9KM9Q\\SQLEXPRESS;Initial Catalog=Hotel_Paso;Integrated Security=True");
            cn.Open();
            Aux_Id = id;
            //En este frm solo se muestra la reserva, absolutamente nada se modifica, en el EliminarReserva si se elimina ademas de mostrar
            SqlCommand Nombre = new SqlCommand("Select Nombre from Cliente where Cliente_Id='" + Aux_Id + "'", cn);
            SqlDataAdapter daN = new SqlDataAdapter(Nombre);
            DataTable dtNombre = new DataTable();
            daN.Fill(dtNombre);
            //Aqui obtenga el nombre del cliente nada mas
            if (dtNombre.Rows.Count != 0)
            {
                //Iguale el nombre del cliente encontrado con el txtnombre del cliente
                txtNombreCl.Text = dtNombre.Rows[0][0].ToString();
                //Ahora busque todos los datos de la reserva del cliente
                SqlCommand Obtener = new SqlCommand("Select * from Reserva where Cliente_Id='" + Aux_Id + "'And Estado='" + true + "'", cn);
                SqlDataAdapter da = new SqlDataAdapter(Obtener);
                DataTable dt = new DataTable();
                da.Fill(dt);
                //Si encontro la reserva asociada con la id del cliente...
                if (dt.Rows.Count != 0)
                {
                    //Muestre en los respectivos textbox la informacion de la reserva
                    txtReservaId.Text = dt.Rows[0][0].ToString();
                    txtFecha.Text = dt.Rows[0][1].ToString();
                    //Se salta de posicion porque la [0][2] es de la fechasalida, y logicamente no ha salido...
                    txtOcup.Text = dt.Rows[0][3].ToString();
                    //int b = Convert.ToInt32(dt.Rows[0][4].ToString());
                    if (dt.Rows[0][4].ToString().Equals("0"))
                        txtEstacio.Text = "No Estacionamiento";
                    else
                        txtEstacio.Text = "Si Estacionamiento";
                    txtNumHab.Text = dt.Rows[0][5].ToString();
                    //Se salta la 06 porque es el id del cliente que ya lo conoce porque inicio sesion
                    //int a = Convert.ToInt32(dt.Rows[0][7].ToString());
                    if (dt.Rows[0][7].ToString().Equals("0"))
                        txtEstado.Text = "No activo";
                    else
                        txtEstado.Text = "Activo";
                    txtSuyas.Text = dt.Rows[0][8].ToString();
                }
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtReservaId_TextChanged(object sender, EventArgs e)
        {
            txtReservaId.Enabled = false;        
        }
    }
}
