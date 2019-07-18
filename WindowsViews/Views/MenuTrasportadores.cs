﻿using System;
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
    public partial class MenuTrasportadores : Form
    {
        public MenuTrasportadores()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ImgHistorial_MouseHover(object sender, EventArgs e)
        {
            ImgHistorial.Size = new Size(width: 249, height: 116);
        }

        private void ImgHistorial_MouseLeave(object sender, EventArgs e)
        {
            ImgHistorial.Size = new Size(width: 249, height: 94);
        }

        private void ImgMantencion_MouseLeave(object sender, EventArgs e)
        {
            ImgMantencion.Size = new Size(width: 249, height: 94);
        }

        private void ImgMantencion_MouseHover(object sender, EventArgs e)
        {
            ImgMantencion.Size = new Size(width: 249, height: 116);
        }

        private void ImgOT_MouseLeave(object sender, EventArgs e)
        {
            ImgOT.Size = new Size(width: 249, height: 94);
        }

        private void ImgOT_MouseHover(object sender, EventArgs e)
        {
            ImgOT.Size = new Size(width: 249, height: 116);
        }

        private void ImgProximasMantenciones_MouseLeave(object sender, EventArgs e)
        {
            ImgProximasMantenciones.Size = new Size(width: 249, height: 94);
        }

        private void ImgProximasMantenciones_MouseHover(object sender, EventArgs e)
        {
            ImgProximasMantenciones.Size = new Size(width: 249, height: 116);
        }

        private void ImgOT_Click(object sender, EventArgs e)
        {
            IngresoOT ingreso = new IngresoOT();
            ingreso.Show();
        }

        private void ImgMantencion_Click(object sender, EventArgs e)
        {
            MantencionTrasportadores MTrasportadores = new MantencionTrasportadores();
            MTrasportadores.Show();
        }

        private void ImgProximasMantenciones_Click(object sender, EventArgs e)
        {
            ProximasMantencionesTrasportadores PMTrasportadores = new ProximasMantencionesTrasportadores();
            PMTrasportadores.Show();
        }

        private void ImgHistorial_Click(object sender, EventArgs e)
        {
            HistorialMantencionesVehiculos HMVehiculos = new HistorialMantencionesVehiculos();
            HMVehiculos.Show();
        }

        private void MenuTrasportadores_Load(object sender, EventArgs e)
        {

        }
    }
}
