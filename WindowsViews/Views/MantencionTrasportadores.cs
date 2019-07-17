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
using System.Drawing;
using System.IO;


namespace WindowsViews.Views
{
    public partial class MantencionTrasportadores : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        public MantencionTrasportadores()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CalcularDiasFaltantes()
        {
            
            
        }

        private void TxtDiasFaltantes_TextChanged(object sender, EventArgs e)
        {
            TxtDiasFaltantes.Enabled = false;
        }
        
        private void BtnAgregarMantencion_Click(object sender, EventArgs e)
        {

            try
            {
                DateTime fecha = new DateTime(2019, 07, 17);
                DateTime fechaMantencion = new DateTime(2019, 07, 20);
                TimeSpan CalcularDias;

                DateTime.TryParse(DatePickerFechaProximaMantencion.Text, out fecha);
                DateTime.TryParse(DatePickerFechaUltimaMantencion.Text, out fechaMantencion);
                TimeSpan.TryParse(TxtDiasFaltantes.Text, out CalcularDias);
                CalcularDias = (fecha.Date - fechaMantencion.Date);

                TxtDiasFaltantes.Text = CalcularDias.ToString("dd");
                TxtDiasFaltantes.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MostrarNotificacion();
            
        }

        public void MostrarNotificacion()
        {

            Notificacion.Icon = new System.Drawing.Icon(Path.GetFullPath(@"C:\Users\ffranco\Pictures\imagenes Proyectos\Mantenimiento\Custom-Icon-Design-Flatastic-1-Alert.ico"));
            Notificacion.Text = "EJEMPLO Text";
            Notificacion.Visible = true;
            Notificacion.BalloonTipTitle = "Proxima Mantencion!";
            Notificacion.BalloonTipText = ("La siguiente mantencion es en " + TxtDiasFaltantes);
            Notificacion.ShowBalloonTip(100);
        }

        private void MantencionTrasportadores_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
