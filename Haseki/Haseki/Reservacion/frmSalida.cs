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
    public partial class frmSalida : Form
    {
        public SqlConnection cn;
        public frmSalida()
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
            //Busque el numero de la habitacion relacionado con esa reserva
            SqlCommand ObtenerNumero = new SqlCommand("Select Numero_Habitacion from Reserva where Estado=1 and Reserva_Id='" + txtReserva.Text + "'", cn);
            SqlDataAdapter da = new SqlDataAdapter(ObtenerNumero);
            DataTable dt = new DataTable();
            da.Fill(dt);
            //Si encontro una habitacion que coincida con el id de la reserva ingresado entonces...
            if (dt.Rows.Count != 0)
            {

                //Modifique la disponibilidad de la habitacion de la que se salio
                int Num_Hab = Convert.ToInt32(dt.Rows[0][0].ToString());
                SqlCommand Dis = new SqlCommand("update Habitacion set Disponibilidad='" + true + "'where Numero_Habitacion='" + Num_Hab + "'", cn);
                Dis.ExecuteNonQuery();
                //Ingrese la fecha de salida en la Reserva correspondiente
                SqlCommand cmd1 = new SqlCommand("update Reserva Set Fecha_Salida='" + txtFecha_Salida.Text + "'where Reserva_Id='" + txtReserva.Text + "'", cn);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Salida registrada con exito");
                frmOpcionAdmin a = new frmOpcionAdmin();
                a.Show();
                this.Close();
            }
            else 
            {
                MessageBox.Show("No se encuentra ninguna reserva relacionada con ese Id, porfavor verifique en el codigo de reserva que se le dio al reservar");
                txtReserva.Clear();
                txtFecha_Salida.Clear();
            }
        }
    }
}
