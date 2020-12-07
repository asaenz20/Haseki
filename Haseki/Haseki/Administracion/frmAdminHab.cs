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
    public partial class frmAdminHab : Form
    {
        public SqlConnection cn;
        public frmAdminHab()
        {
            InitializeComponent();
            cn = new SqlConnection("Data Source=DESKTOP-NE9KM9Q\\SQLEXPRESS;Initial Catalog=Hotel_Paso;Integrated Security=True");
            cn.Open();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // SqlCommand Oro = new SqlCommand("Select * from Habitacion where Tipo='" + "Plata" + "'", cn);
            //Si el tipo de creacion es plata, entonces
            if (cmbHab.SelectedItem.Equals("Plata"))
            {
                SqlCommand Plata = new SqlCommand("Select * from Habitacion where Tipo_Id='" + "1" + "'", cn);
                SqlDataAdapter Da = new SqlDataAdapter(Plata);
                DataTable dt = new DataTable();
                Da.Fill(dt);
                int platc = 101 + dt.Rows.Count;
                //Ingrese en la tabla Habitacion, una tipo plata, con su numero, y su disponibilidad pasa a ser true
                //Plata es el contador que va incrementando a medida que se crean habitaciones, cuando uno coloca el 1 
                //en el insert, es porque en la BD por defecto, el Tipo_Id de 1 es de plata, de 2 de oro, 3 diamante y 4 DLRR
                SqlCommand cmd = new SqlCommand("Insert into Habitacion values ('" + platc + "','" + 1 + "','" + true + "')", cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Habitacion creada con exito");
                frmOpcionAdmin a = new frmOpcionAdmin();
                a.Show();
                this.Close();
            }
            //Y asi con todas las demas...
            if (cmbHab.SelectedItem.Equals("Oro"))
            {

                SqlCommand Oro = new SqlCommand("Select * from Habitacion where Tipo_Id='" + "2" + "'", cn);
                SqlDataAdapter Da = new SqlDataAdapter(Oro);
                DataTable dt = new DataTable();
                Da.Fill(dt);
                int oroc = 201 + dt.Rows.Count;
                //Ingrese en la tabla Habitacion, una tipo plata, con su numero, y su disponibilidad pasa a ser true
                //Plata es el contador que va incrementando a medida que se crean habitaciones, cuando uno coloca el 1 
                //en el insert, es porque en la BD por defecto, el Tipo_Id de 1 es de plata, de 2 de oro, 3 diamante y 4 DLRR
                SqlCommand cmd = new SqlCommand("Insert into Habitacion values ('" + oroc + "','" + 2 + "','" + true + "')", cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Habitacion creada con exito");
                frmOpcionAdmin a = new frmOpcionAdmin();
                a.Show();
                this.Close();
            }
            if (cmbHab.SelectedItem.Equals("Diamante"))
            {
                SqlCommand Diamante = new SqlCommand("Select * from Habitacion where Tipo_Id='" + "3" + "'", cn);
                SqlDataAdapter Da = new SqlDataAdapter(Diamante);
                DataTable dt = new DataTable();
                Da.Fill(dt);
                int Diamantec = 301 + dt.Rows.Count;
                //Ingrese en la tabla Habitacion, una tipo plata, con su numero, y su disponibilidad pasa a ser true
                //Plata es el contador que va incrementando a medida que se crean habitaciones, cuando uno coloca el 1 
                //en el insert, es porque en la BD por defecto, el Tipo_Id de 1 es de plata, de 2 de oro, 3 diamante y 4 DLRR
                SqlCommand cmd = new SqlCommand("Insert into Habitacion values ('" + Diamantec + "','" + 3 + "','" + true + "')", cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Habitacion creada con exito");
                frmOpcionAdmin a = new frmOpcionAdmin();
                a.Show();
                this.Close();
            }
            if (cmbHab.SelectedItem.Equals("DLRR"))
            {
                SqlCommand DLRR = new SqlCommand("Select * from Habitacion where Tipo_Id='" + "4" + "'", cn);
                SqlDataAdapter Da = new SqlDataAdapter(DLRR);
                DataTable dt = new DataTable();
                Da.Fill(dt);
                int DLRRc = 401 + dt.Rows.Count;
                //Ingrese en la tabla Habitacion, una tipo plata, con su numero, y su disponibilidad pasa a ser true
                //Plata es el contador que va incrementando a medida que se crean habitaciones, cuando uno coloca el 1 
                //en el insert, es porque en la BD por defecto, el Tipo_Id de 1 es de plata, de 2 de oro, 3 diamante y 4 DLRR
                SqlCommand cmd = new SqlCommand("Insert into Habitacion values ('" + DLRRc + "','" + 4 + "','" + true + "')", cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Habitacion creada con exito");
                frmOpcionAdmin a = new frmOpcionAdmin();
                a.Show();
                this.Close();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmOpcionAdmin a = new frmOpcionAdmin();
            a.Show();
            this.Close();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {

        }
    }
}
