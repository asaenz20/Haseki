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
    public partial class frmReserva : Form
    {
        public SqlConnection cn;
        public String Id_Aux;
        public frmReserva()
        {
            InitializeComponent();
            cn = new SqlConnection("Data Source=DESKTOP-NE9KM9Q\\SQLEXPRESS;Initial Catalog=Hotel_Paso;Integrated Security=True");
            cn.Open();
        }
        public frmReserva(String id)
        {
            InitializeComponent();
            cn = new SqlConnection("Data Source=DESKTOP-NE9KM9Q\\SQLEXPRESS;Initial Catalog=Hotel_Paso;Integrated Security=True");
            cn.Open();
            Id_Aux = id;
        }
        private void Label6_Click(object sender, EventArgs e)
        {
        }

        private void cmdTipoHabitacion_Leave(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmOpcionCliente a = new frmOpcionCliente();
            a.Show();
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Traiga todas las reservas que tenga este cliente que esten en estado activo no canceladas
            SqlCommand Definitivo = new SqlCommand("Select * FROM Reserva where Cliente_Id='" + Id_Aux + "'AND Estado='" + true + "'", cn);
            SqlDataAdapter Def = new SqlDataAdapter(Definitivo);
            DataTable Trap = new DataTable();
            Def.Fill(Trap);
            //Si no hay reservaciones activas de esta persona, entonces
            if (Trap.Rows.Count == 0)
            {
                
                //Por defecto, tanto el id la reserva como de la factura empiezan en 1, sera un contador que se va incrementando
                SqlCommand FacturaCod = new SqlCommand("Select Factura_Id from Factura ", cn);
                SqlDataAdapter Da = new SqlDataAdapter(FacturaCod);
                DataTable dt = new DataTable();
                Da.Fill(dt);
                SqlCommand ReservaCod = new SqlCommand("Select Reserva_Id from Factura  ", cn);
                SqlDataAdapter da = new SqlDataAdapter(ReservaCod);
                DataTable Dt = new DataTable();
                da.Fill(Dt);
                int fac = dt.Rows.Count + 1;
                int rev = Dt.Rows.Count + 1;
                String Reserva = rev.ToString();
                String Factura = fac.ToString();
                //Busque si hay mas reservas de esta persona
                SqlCommand ReservasPorId = new SqlCommand("Select * from Reserva where Cliente_Id='" + Id_Aux + "'", cn);
                SqlDataAdapter DATA = new SqlDataAdapter(ReservasPorId);
                DataTable ReservaTabla = new DataTable();
                DATA.Fill(ReservaTabla);
                int con = 0;
                con = ReservaTabla.Rows.Count + 1;
                //Inserte en la tabla reserva los datos
                if (rbdSI.Checked == true)
                {
                    SqlCommand comando = new SqlCommand("insert into Reserva values('" + Reserva + "','" + txtFecha.Text + "','"
                    + null + "','" + NumOcu.Value + "','" + true + "','" + txtNumHab.Text + "','" + Id_Aux + "','" + true +
                    "','" + con + "')", cn);
                    comando.ExecuteNonQuery();
                    //Es importante guardar la id de la reserva necesario a la hora de registrar la salida
                    MessageBox.Show("Reserva ingresado con exito, señor usuario tenga en cuenta que su codigo de reserva es: " + " " + Reserva);
                    //Genere una factura lista para esta reserva, solo se necesita el idcliente, la reserva y de la factura, el total calculado se hara luego
                    SqlCommand ComandoFactura = new SqlCommand("Insert into Factura values('" + Factura + "','" + Factura + "')", cn);
                    ComandoFactura.ExecuteNonQuery();
                    //Cambie la disponibilidad a no disponible la habitacion que ya se reservo
                    SqlCommand NoDisp = new SqlCommand("Update Habitacion set Disponibilidad='" + false + "'Where Numero_Habitacion='" + txtNumHab.Text + "'", cn);
                    NoDisp.ExecuteNonQuery();
                    this.Close();
                }
                else 
                {
                    SqlCommand comando = new SqlCommand("insert into Reserva values('" + Reserva + "','" + txtFecha.Text + "','"
                      + null + "','" + NumOcu.Value + "','" + false + "','" + txtNumHab.Text + "','" + Id_Aux + "','" + true +
                      "','" + con + "')", cn);
                    comando.ExecuteNonQuery();
                    //Es importante guardar la id de la reserva necesario a la hora de registrar la salida
                    MessageBox.Show("Reserva ingresado con exito, señor usuario tenga en cuenta que su codigo de reserva es: " + " " + Reserva);
                    //Genere una factura lista para esta reserva, solo se necesita el idcliente, la reserva y de la factura, el total calculado se hara luego
                    SqlCommand ComandoFactura = new SqlCommand("Insert into Factura values ('" + Factura + "','" + Reserva + "')", cn);
                    ComandoFactura.ExecuteNonQuery();
                    //Cambie la disponibilidad a no disponible la habitacion que ya se reservo
                    SqlCommand NoDisp = new SqlCommand("Update Habitacion set Disponibilidad='" + false + "'Where Numero_Habitacion='" + txtNumHab.Text + "'", cn);
                    NoDisp.ExecuteNonQuery();
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("Señor usuario, usted ya posee una Reservacion activa, por favor eliminela para poder crear otra");
            }
            this.Close();
        }

        private void cmdTipoHabitacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            String auxi = cmdTipoHabitacion.SelectedItem.ToString();
            //Aqui se traera la primera habitacion disponible de cada tipo, todo depende del tipo que la persona eligio para reservar
            //Por ejemplo aqui, se compara si la persona eligio una habitacion tipo plata
            //Si la eligio entonces...
            if (auxi.Equals("Plata"))
            {
                //Traigame la primera habitacion tipo oro que encuentre disponible 
                SqlCommand cmd = new SqlCommand("Select Numero_Habitacion from Habitacion where Disponibilidad=1 and Tipo_Id='" + 1 + "'", cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                //Si hay alguna habitacion tipo plata disponible, entonces...
                if (dt.Rows.Count != 0)
                {
                    //Llevela el textbox de Numero Habitacion de forma automatica LA PRIMERA QUE ENCUENTRE LIBRE
                    txtNumHab.Text = dt.Rows[0][0].ToString();
                }
                //Si no hay ninguna tipo plata disponible, entonces...
                else
                {
                    //Mande un mensaje diciendo que no hay habitaciones tipo plats disponibles
                    MessageBox.Show("No hay habitaciones de ese tipo disponibles");
                }
                //Y asi hara con cualquier otro tipo de habitacion, sea plata, oro, diamante o DLRR
            }
            if (auxi.Equals("Oro"))
            {
                SqlCommand cmd = new SqlCommand("Select Numero_Habitacion from Habitacion where Disponibilidad=1 and Tipo_Id='" + 2 + "'", cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count != 0)
                {
                    txtNumHab.Text = dt.Rows[0][0].ToString();
                }
                else
                {
                    MessageBox.Show("No hay habitaciones de ese tipo disponibles");
                }
            }
            if (auxi.Equals("Diamante"))
            {
                SqlCommand cmd = new SqlCommand("Select Numero_Habitacion from Habitacion where disponibilidad=1 and Tipo_Id='" + 3 + "'", cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count != 0)
                {
                    txtNumHab.Text = dt.Rows[0][0].ToString();
                }
                else
                {
                    MessageBox.Show("No hay habitaciones de ese tipo disponibles");
                }
            }
            if (auxi.Equals("DLRR"))
            {
                SqlCommand cmd = new SqlCommand("Select Numero_Habitacion from Habitacion where Disponibilidad=1 and Tipo_Id='" + 4 + "'", cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count != 0)
                {
                    txtNumHab.Text = dt.Rows[0][0].ToString();
                }
                else
                {
                    MessageBox.Show("No hay habitaciones de ese tipo disponibles");
                }
            }
        }
    }
}
