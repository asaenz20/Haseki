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
    public partial class frmFactura : Form
    {
        public SqlConnection cn;
        public String Reserva_Aux;
        public double Parqueadero=30000;
        public double Persona = 20000;
        public double PrecioTip;
        public double total;
        public frmFactura()
        {
            InitializeComponent();
        }
        public frmFactura(String ReservaId)
        {
            InitializeComponent();
            Reserva_Aux = ReservaId;
            cn = new SqlConnection("Data Source=DESKTOP-NE9KM9Q\\SQLEXPRESS;Initial Catalog=Hotel_Paso;Integrated Security=True");
            cn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Reserva where Reserva_Id='" + Reserva_Aux + "'", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            String ClienteId = dt.Rows[0][6].ToString();
            SqlCommand cmd1 = new SqlCommand("Select Nombre from Cliente where Cliente_Id='" + ClienteId + "'", cn);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            String ClienteNombre = dt1.Rows[0][0].ToString();
            txtnombreCLI.Text = ClienteNombre;
            txtIdCLI.Text = ClienteId;
            txtResId.Text = Reserva_Aux;
            txtHabNum.Text = dt.Rows[0][5].ToString();
            txtfecha_entrada.Text = dt.Rows[0][1].ToString();
            txtfecha_salida.Text = dt.Rows[0][2].ToString();
            txtocupantes.Text = dt.Rows[0][3].ToString();
            double a = Persona * Convert.ToDouble(dt.Rows[0][3].ToString());
            total = a + total;
            txtprecio_ocupantes.Text = Convert.ToString(a);
            if (dt.Rows[0][4].ToString().Equals("0"))
            {
                txtEstacion.Text = "No";
                double es = 30000;
                total = es + total;
                txtprecio_estacion.Text = Convert.ToString(es);
            }
            else
            {
                txtEstacion.Text = "Si Estacionamiento";
                double es = 30000;
                total = es + total;
                txtprecio_estacion.Text = Convert.ToString(es);
            }
            SqlCommand cmd2 = new SqlCommand("Select Tipo_Id from Habitacion where Numero_Habitacion='" +
                dt.Rows[0][5].ToString() + "'", cn);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            String TipoHabi = dt2.Rows[0][0].ToString();
            txtTipo_hab.Text = TipoHabi;
            if (TipoHabi.Equals("Plata"))
            {
                PrecioTip = 95000;
                total = PrecioTip + total;
                txtprecio_tipo_hab.Text = Convert.ToString(PrecioTip);
            }

            if (TipoHabi.Equals("Oro"))
            {
                PrecioTip = 130000;
                total = PrecioTip + total;
                txtprecio_tipo_hab.Text = Convert.ToString(PrecioTip);
            }
            if (TipoHabi.Equals("Diamante"))
            {
                PrecioTip = 250000;
                total = PrecioTip + total;
                txtprecio_tipo_hab.Text = Convert.ToString(PrecioTip);
            }
            if (TipoHabi.Equals("DLRR"))
            {
                PrecioTip = 450000;
                total = PrecioTip + total;
                txtprecio_tipo_hab.Text = Convert.ToString(PrecioTip);
            }
            
            SqlCommand cmd3 = new SqlCommand("Select Cantidad_Por_Producto, Precio from Detalle_Factura where Factura_Id='" + Reserva_Aux + "'AND Producto_Id='" + 1 + "'", cn);
            SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            if(dt3.Rows.Count !=0)
            { 
            txtCOLA_CANTI.Text = dt3.Rows[0][0].ToString();
            txtCOLA_UNI.Text = dt3.Rows[0][1].ToString();
            double COLA = Convert.ToDouble(dt3.Rows[0][1].ToString());
            total = COLA + total;

            }

            SqlCommand cmd4 = new SqlCommand("Select Cantidad_Por_Producto, Precio from Detalle_Factura where Factura_Id='" + Reserva_Aux + "'AND Producto_Id='" + 2 + "'", cn);
            SqlDataAdapter da4 = new SqlDataAdapter(cmd4);
            DataTable dt4 = new DataTable();
            da4.Fill(dt4);
            if (dt4.Rows.Count != 0)
            {
                txt7UP_CANTI.Text = dt4.Rows[0][0].ToString();
                txt7UP_UNI.Text = dt4.Rows[0][1].ToString();
                double UP = Convert.ToDouble(dt4.Rows[0][1].ToString());
                total = UP + total;
            }

            SqlCommand cmd5 = new SqlCommand("Select Cantidad_Por_Producto, Precio from Detalle_Factura where Factura_Id='" + Reserva_Aux + "'AND Producto_Id='" + 3 + "'", cn);
            SqlDataAdapter da5 = new SqlDataAdapter(cmd5);
            DataTable dt5 = new DataTable();
            da5.Fill(dt5);
            if (dt5.Rows.Count != 0)
            {
                txtJUMBO_CANTI.Text = dt5.Rows[0][0].ToString();
                txtJUMBO_UNI.Text = dt5.Rows[0][1].ToString();
                double JUMBO = Convert.ToDouble(dt5.Rows[0][1].ToString());
                total = JUMBO + total;
            }
            
            SqlCommand cmd6 = new SqlCommand("Select Cantidad_Por_Producto, Precio from Detalle_Factura where Factura_Id='" + Reserva_Aux + "'AND Producto_Id='" + 4 + "'", cn);
            SqlDataAdapter da6 = new SqlDataAdapter(cmd6);
            DataTable dt6 = new DataTable();
            da6.Fill(dt6);
            if (dt6.Rows.Count != 0) 
            {
                txtTODITO_CANTI.Text = dt6.Rows[0][0].ToString();
                txtTODITO_UNI.Text = dt6.Rows[0][1].ToString();
                double TODITO = Convert.ToDouble(dt6.Rows[0][1].ToString());
                total = TODITO + total;
            }

            SqlCommand cmd7 = new SqlCommand("Select Cantidad_Por_Producto, Precio from Detalle_Factura where Factura_Id='" + Reserva_Aux + "'AND Producto_Id='" + 5 + "'", cn);
            SqlDataAdapter da7 = new SqlDataAdapter(cmd7);
            DataTable dt7 = new DataTable();
            da7.Fill(dt7);
            if (dt7.Rows.Count != 0) 
            {
                txtAGUA_CANTI.Text = dt7.Rows[0][0].ToString();
                txtAGUA_UNI.Text = dt7.Rows[0][1].ToString();
                double AGUA = Convert.ToDouble(dt7.Rows[0][1].ToString());
                total = AGUA + total;

            }

            SqlCommand cmd8 = new SqlCommand("Select Cantidad_Por_Producto, Precio from Detalle_Factura where Factura_Id='" + Reserva_Aux + "'AND Producto_Id='" + 6 + "'", cn);
            SqlDataAdapter da8 = new SqlDataAdapter(cmd8);
            DataTable dt8 = new DataTable();
            da8.Fill(dt8);
            if (dt8.Rows.Count != 0)
            {
                txtDORITOS_CANTI.Text = dt8.Rows[0][0].ToString();
                txtDORITOS_UNI.Text = dt8.Rows[0][1].ToString();
                double DORITOS = Convert.ToDouble(dt8.Rows[0][1].ToString());
                total = DORITOS + total;

            }
            
            SqlCommand cmd9 = new SqlCommand("Select Cantidad_Por_Producto, Precio from Detalle_Factura where Factura_Id='" + Reserva_Aux + "'AND Producto_Id='" + 7 + "'", cn);
            SqlDataAdapter da9 = new SqlDataAdapter(cmd9);
            DataTable dt9 = new DataTable();
            da9.Fill(dt9);
            if (dt9.Rows.Count != 0)
            {
                txtNACHOS_CANTI.Text = dt9.Rows[0][0].ToString();
                txtNACHOS_UNI.Text = dt9.Rows[0][1].ToString();
                double NACHOS = Convert.ToDouble(dt9.Rows[0][1].ToString());
                total = NACHOS + total;

            }

            SqlCommand cmd10 = new SqlCommand("Select Cantidad_Por_Producto, Precio from Detalle_Factura where Factura_Id='" + Reserva_Aux + "'AND Producto_Id='" + 8 + "'", cn);
            SqlDataAdapter da10 = new SqlDataAdapter(cmd10);
            DataTable dt10 = new DataTable();
            da10.Fill(dt10);
            if (dt10.Rows.Count != 0)
            {
                txtLUBRI_CANTI.Text = dt10.Rows[0][0].ToString();
                txtLUBRI_UNI.Text = dt10.Rows[0][1].ToString();
                double LUBRI_STAR = Convert.ToDouble(dt10.Rows[0][1].ToString());
                total = LUBRI_STAR + total;

            }
            
            SqlCommand cmd11 = new SqlCommand("Select Cantidad_Por_Producto, Precio from Detalle_Factura where Factura_Id='" + Reserva_Aux + "'AND Producto_Id='" + 9 + "'", cn);
            SqlDataAdapter da11 = new SqlDataAdapter(cmd11);
            DataTable dt11 = new DataTable();
            da11.Fill(dt11);
            if (dt11.Rows.Count != 0)
            {
                txtCONDON_CANTI.Text = dt11.Rows[0][0].ToString();
                txtCONDON_UNI.Text = dt11.Rows[0][1].ToString();
                double TODAY = Convert.ToDouble(dt11.Rows[0][1].ToString());
                total = TODAY + total;

            }

            SqlCommand cmd12 = new SqlCommand("Select Cantidad_Por_Producto, Precio from Detalle_Factura where Factura_Id='" + Reserva_Aux + "'AND Producto_Id='" + 10 + "'", cn);
            SqlDataAdapter da12 = new SqlDataAdapter(cmd12);
            DataTable dt12 = new DataTable();
            da12.Fill(dt12);
            if (dt11.Rows.Count != 0)
            {
                txtAERO_CANTI.Text = dt12.Rows[0][0].ToString();
                txtAERO_UNI.Text = dt12.Rows[0][1].ToString();
                double AEREO = Convert.ToDouble(dt12.Rows[0][1].ToString());
                total = AEREO + total;

            }
            

            txtTOTAL.Text = Convert.ToString(total);

            SqlCommand cmdS = new SqlCommand("update Reserva Set Estado=0 where Reserva_Id='" + Reserva_Aux + "'", cn);
            cmdS.ExecuteNonQuery();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmOpcionAdmin a = new frmOpcionAdmin();
            a.Show();
            this.Close();
        }

        private void label23_Click(object sender, EventArgs e)
        {
            
        }

        private void txtEstacion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
