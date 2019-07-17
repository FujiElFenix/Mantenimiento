using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsViews.Views
{
    public partial class MantencionTrasportadores : Form
    {
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
            

            
        }
    }
}
