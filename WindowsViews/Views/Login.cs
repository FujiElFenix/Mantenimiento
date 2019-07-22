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
using WindowsViews.Views;

namespace WindowsViews
{
    public partial class Login : Form
    {
        SqlConnection cone = new SqlConnection("server=PROGRAMADOR3; database=DBMantencion; integrated security=true");

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        public Login()
        {
            InitializeComponent();
        }

        private void BtnGestionMaquinas_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        

        public void logear(string Username ,string Contrasenia)
        {
            try
            {
                cone.Open();
                SqlCommand cmd = new SqlCommand("Select Username, Descripcion from  Usuario where Username=@Username and Password=@Password", cone);
                cmd.Parameters.AddWithValue("Username", Username);
                cmd.Parameters.AddWithValue("Password", Contrasenia);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    if (dt.Rows[0][1].ToString() == "administrador")
                    {
                        new MenuPrincipal(dt.Rows[0][0].ToString()). Show();
                    }
                    else if (dt.Rows[0][1].ToString() == "Vehiculos")
                    {
                        new GestionarVehiculos(dt.Rows[0][0].ToString()).Show();
                    }
                    else if (dt.Rows[0][1].ToString() == "Maquinaria")
                    {
                        new GestionarMaquinaria(dt.Rows[0][0].ToString()).Show();
                    }
                    else if (dt.Rows[0][1].ToString() == "Trasportadores")
                    {
                        new GestionarTrasportadores(dt.Rows[0][0].ToString()).Show();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario y Contraseña incorrectos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo logear " + ex.Message);
            }
            finally
            {
                cone.Close();
            }
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            logear(this.TxtUsuario.Text, this.TxtContrasenia.Text); 
        }
    }
}
