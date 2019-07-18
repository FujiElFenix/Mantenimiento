using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace WindowsViews.Views
{
    public partial class IngresoVehiculos : Form
    {
        SqlConnection cone = new SqlConnection("server=PROGRAMADOR3; database=DBMantencion; integrated security=true");
        public IngresoVehiculos()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void IngresoVehiculos_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "INSERT INTO Vehiculo (Patente,Marca,Color,Modelo,Motor,Chasis,Metraje,anio,Conductor_id) VALUES (@Patente,@Marca,@Color,@Modelo,@Motor,@Chasis,@Metraje,@anio,@Conductor_id)";
                cone.Open();
                SqlCommand comando = new SqlCommand(query, cone);
                comando.Parameters.AddWithValue("@Patente", TxtPatente.Text);
                comando.Parameters.AddWithValue("@Marca", TxtMarca.Text);
                comando.Parameters.AddWithValue("@Color", TxtColor.Text);
                comando.Parameters.AddWithValue("@Modelo", TxtModelo.Text);
                comando.Parameters.AddWithValue("@Motor", TxtMotor.Text);
                comando.Parameters.AddWithValue("@Chasis", TxtChasis.Text);
                comando.Parameters.AddWithValue("@Metraje", TxtMetraje.Text);
                comando.Parameters.AddWithValue("@anio", TxtAnio.Text);
                comando.Parameters.AddWithValue("@Conductor_id", TxtRut.Text);
                comando.ExecuteNonQuery();
                MessageBox.Show("Vehiculo Insertado");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Vehiculo No Insertado "+ex.Message);
            }
        }

        private void BtnNuevoVehiculo_Click(object sender, EventArgs e)
        {
            TxtPatente.Clear();
            TxtMarca.Clear();
            TxtColor.Clear();
            TxtModelo.Clear();
            TxtMotor.Clear();
            TxtChasis.Clear();
            TxtMetraje.Clear();
            TxtAnio.Clear();

        }

        private void IngresoVehiculos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dBMantencionDataSet1.Vehiculo' Puede moverla o quitarla según sea necesario.
            this.vehiculoTableAdapter1.Fill(this.dBMantencionDataSet1.Vehiculo);

        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "UPDATE Vehiculo SET Marca=@Marca,Color=@Color,Modelo=@Modelo,Motor=@Motor,Chasis=@Chasis,Metraje=@Metraje,anio=@anio,Conductor_id=@Conductor_id WHERE Patente = @Patente";
                cone.Open();
                SqlCommand comando = new SqlCommand(query, cone);
                comando.Parameters.AddWithValue("@Patente", TxtPatente.Text);
                comando.Parameters.AddWithValue("@Marca", TxtMarca.Text);
                comando.Parameters.AddWithValue("@Color", TxtColor.Text);
                comando.Parameters.AddWithValue("@Modelo", TxtModelo.Text);
                comando.Parameters.AddWithValue("@Motor", TxtMotor.Text);
                comando.Parameters.AddWithValue("@Chasis", TxtChasis.Text);
                comando.Parameters.AddWithValue("@Metraje", TxtMetraje.Text);
                comando.Parameters.AddWithValue("@anio", TxtAnio.Text);
                comando.Parameters.AddWithValue("@Conductor_id", TxtRut.Text);
                comando.ExecuteNonQuery();
                cone.Close();
                MessageBox.Show("Vehiculo Modificado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar " + ex.Message);
            }
            
        }

        private void BtnBuscarVehiculo_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("select * from Vehiculo where Patente = @Patente ", cone);
            comando.Parameters.AddWithValue("@Patente", TxtPatenteBuscar.Text);
            cone.Open();
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                TxtPatente.Text = registro["Patente"].ToString();
                TxtMarca.Text = registro["Marca"].ToString();
                TxtColor.Text = registro["Color"].ToString();
                TxtModelo.Text = registro["Modelo"].ToString();
                TxtMotor.Text = registro["Motor"].ToString();
                TxtChasis.Text = registro["Chasis"].ToString();
                TxtMetraje.Text = registro["Metraje"].ToString();
                TxtAnio.Text = registro["anio"].ToString();
            }
            cone.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("Select * from Conductor where Rut=@Rut ",cone);
            comando.Parameters.AddWithValue("@Rut", TxtRut.Text);
            cone.Open();
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                TxtNombreCliente.Text = registro["Nombre"].ToString();
            }
            cone.Close();
        }
    }
}
