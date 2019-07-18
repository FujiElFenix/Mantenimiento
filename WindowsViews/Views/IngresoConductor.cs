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

namespace WindowsViews.Views
{
    public partial class IngresoConductor_ : Form
    {
        SqlConnection cone = new SqlConnection("server=PROGRAMADOR3; database=DBMantencion; integrated security=true");
        public IngresoConductor_()
        {
            InitializeComponent();
        }

        private void IngresoConductor__Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dBMantencionDataSet2.Conductor' Puede moverla o quitarla según sea necesario.
            this.conductorTableAdapter.Fill(this.dBMantencionDataSet2.Conductor);

        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "INSERT INTO Conductor (Rut,Nombre,Direccion,Telefono,Email) VALUES (@Rut,@Nombre,@Direccion,@Telefono,@Email)";
                cone.Open();
                SqlCommand comando = new SqlCommand(query, cone);
                comando.Parameters.AddWithValue("@Rut", TxtRutCliente.Text);
                comando.Parameters.AddWithValue("@Nombre", TxtNombre.Text);
                comando.Parameters.AddWithValue("@Direccion", TxtDireccion.Text);
                comando.Parameters.AddWithValue("@Telefono", TxtTelefono.Text);
                comando.Parameters.AddWithValue("@Email", TxtMail.Text);
                comando.ExecuteNonQuery();
                MessageBox.Show("Conductor Insertado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Conductor No Insertado " + ex.Message);
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtRutCliente.Clear();
            TxtNombre.Clear();
            TxtDireccion.Clear();
            TxtTelefono.Clear();
            TxtMail.Clear();
        }
    }
}
