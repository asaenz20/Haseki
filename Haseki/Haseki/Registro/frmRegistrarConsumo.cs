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
            //Busque si la reserva si se le pueden registrar consumos ya que debe estar activada
            SqlCommand cmd = new SqlCommand("Select * from Reserva where Estado=1 AND Reserva_Id='" + txtReserva.Text + "'", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                //Traiga el precio del producto 
                SqlCommand Pre = new SqlCommand("Select Precio_Producto from Producto where Producto_Id='" + txtProId.Text + "'", cn);
                SqlDataAdapter dat = new SqlDataAdapter(Pre);
                DataTable dtf = new DataTable();
                dat.Fill(dtf);
                double Precio = Convert.ToDouble(dtf.Rows[0][0].ToString());
                //Mire a ver si con el codigo de factura que tiene, no tiene repetido el conteo del producto que va a volver a registrar (Que se consumio)
                SqlCommand F = new SqlCommand("Select Cantidad_Por_Producto from Detalle_Factura where Producto_Id='" + txtProId.Text + "'AND Factura_Id='" + txtReserva.Text + "'", cn);
                SqlDataAdapter Da = new SqlDataAdapter(F);
                DataTable dit = new DataTable();
                Da.Fill(dit);
                
                if (dit.Rows.Count == 0)
                {
                    SqlCommand Defi = new SqlCommand("insert into Detalle_Factura values('" + txtReserva.Text + "','" + txtProId.Text + "','" + 1 + "','" + Precio + "')", cn);
                    Defi.ExecuteNonQuery();
                    MessageBox.Show("Producto registrado con exito");
                    frmOpcionAdmin a = new frmOpcionAdmin();
                    a.Show();
                    this.Close();
                }
                else
                {
                    int Cuantos = Convert.ToInt32(dit.Rows[0][0].ToString()) + 1;
                    SqlCommand Torn = new SqlCommand("Update Detalle_Factura set Cantidad_Por_Producto='" + Cuantos + "'where Producto_Id='" +
                         txtProId.Text + "'AND Factura_Id='" + txtReserva.Text + "'", cn);
                    Torn.ExecuteNonQuery();
                    Precio = Precio * Cuantos;
                    SqlCommand Torni = new SqlCommand("Update Detalle_Factura set Precio='" + Precio + "'where Producto_Id='" +
                        txtProId.Text + "'AND Factura_Id='" + txtReserva.Text + "'", cn);
                    Torni.ExecuteNonQuery();
                    MessageBox.Show("Consumo registrado con exito");
                    frmOpcionAdmin a = new frmOpcionAdmin();
                    a.Show();
                    this.Close();
                }
            }
            MessageBox.Show("Codigo de Reserva no valido para registrar consumo de producto", "ALERTA");
            txtProId.Clear();
            txtReserva.Clear();
            txtProId.Focus();
        }    
    }
}

