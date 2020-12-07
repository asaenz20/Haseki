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
    public partial class frmEliminarReserva : Form
    {
        public SqlConnection cn;
        public String Aux_Id;
        public frmEliminarReserva()
        {
            InitializeComponent();
            cn = new SqlConnection("Data Source=DESKTOP-NE9KM9Q\\SQLEXPRESS;Initial Catalog=Hotel_Paso;Integrated Security=True");
            cn.Open();
        }
        public frmEliminarReserva(String id)
        {
            InitializeComponent();
            cn = new SqlConnection("Data Source=DESKTOP-NE9KM9Q\\SQLEXPRESS;Initial Catalog=Hotel_Paso;Integrated Security=True");
            cn.Open();
            Aux_Id = id;
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
                    if (dt.Rows[0][4].ToString().Equals("0"))
                        txtEstacio.Text = "No Estacionamiento";
                    else
                        txtEstacio.Text = "Si estacionamiento";
                    txtNumHab.Text = dt.Rows[0][5].ToString();
                    //Se salta la 06 porque es el id del cliente que ya lo conoce porque inicio sesion
                    if (dt.Rows[0][7].ToString().Equals("0"))
                        txtEstado.Text = "No activo";
                    else
                        txtEstado.Text = "Activo";
                    txtSuyas.Text = dt.Rows[0][8].ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Aqui ademas de Mostrar el estado de reserva, tambien se eliminara el registro si es necesario
            //Obtenga el nombre del cliente
            SqlCommand Nombre = new SqlCommand("Select Nombre from Cliente where Cliente_Id='" + Aux_Id + "'", cn);
            SqlDataAdapter daN = new SqlDataAdapter(Nombre);
            DataTable dtNombre = new DataTable();
            daN.Fill(dtNombre);
            //Si encontro un registro de Cliente, relacionado con esa id entonces
            if (dtNombre.Rows.Count != 0) 
            {
              //Ahora busque todos los datos de la reserva del cliente
              SqlCommand Obtener = new SqlCommand("Select * from Reserva where Cliente_Id='" + Aux_Id + "'AND Estado='" + true + "'" , cn);
              SqlDataAdapter da = new SqlDataAdapter(Obtener);
              DataTable dt = new DataTable();
              da.Fill(dt);
                //Si encontro la reserva asociada con la id del cliente...
              if (dt.Rows.Count != 0) 
              {
                    //Ahora pregunte si desea eliminar la reservacion
                    var result = MessageBox.Show("Realmente desea borrar la reservacion?", "Mensaje de Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    //Si si lo desea, entonces...
                    if (result == DialogResult.Yes)
                    {
                        SqlCommand comando = new SqlCommand("update Reserva set Estado=0 where Reserva_Id ='" + txtReservaId.Text + "'", cn);
                        comando.ExecuteNonQuery();
                        int Num =Convert.ToInt32(dt.Rows[0][5].ToString());
                        SqlCommand Dis = new SqlCommand("update Habitacion set Disponibilidad='" + true + "'where Numero_Habitacion='" + Num + "'", cn);
                        Dis.ExecuteNonQuery();
                        MessageBox.Show("Reserva eliminada correctamente");
                    }
                    //Si no lo quiere borrar...
                    else 
                    {
                        MessageBox.Show("Reserva no eliminada, gracias!!!");
                        this.Close();
                    }
                }

            }
            //Si no encontro ninguna reserva asociada con la id del cliente...
            else 
            {
                MessageBox.Show("No hay ninguna reserva a su nombre");
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEliminarReserva_Load(object sender, EventArgs e)
        {

        }
    }
}
