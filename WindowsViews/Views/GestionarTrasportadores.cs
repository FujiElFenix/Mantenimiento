﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsViews.Views
{
    public partial class GestionarTrasportadores : Form
    {


        public GestionarTrasportadores(string descripcion)
        {
            
            InitializeComponent();
            

        }

        public GestionarTrasportadores()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 352)
            {
                MenuVertical.Width = 84;
            }
            else
            {
                MenuVertical.Width = 352;
            }
            FlechaDerecha.Visible = true;
            FlechaIzq.Visible = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void IcoCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IcoMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            IcoRestaurar.Visible = true;
            IcoMaximizar.Visible = false;
        }

        private void IcRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            IcoRestaurar.Visible = false;
            IcoMaximizar.Visible = true;
        }

        private void IcoMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FlechaDerecha_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 84)
            {
                MenuVertical.Width = 352;
            }
            else
            {
                MenuVertical.Width = 84;
            }
            FlechaDerecha.Visible = false;
            FlechaIzq.Visible = true;

        }

        private void AbrirLogeoMaquinasInPanel(object Formhijo)
        {
            try
            {
                if (this.panelContenedor.Controls.Count > 0)
                    this.panelContenedor.Controls.RemoveAt(0);
                Form fh = Formhijo as Form;
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.panelContenedor.Controls.Add(fh);
                this.panelContenedor.Tag = fh;
                fh.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }

        }

        private void BtnGestionMaquinas_Click(object sender, EventArgs e)
        {

            AbrirLogeoMaquinasInPanel(new Login());
        }

        private void BtnGestionVehiculos_Click(object sender, EventArgs e)
        {
            AbrirLogeoMaquinasInPanel(new Login());
        }

        private void BtnGestionTrasportadores_Click(object sender, EventArgs e)
        {
            AbrirLogeoMaquinasInPanel(new Login());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirLogeoMaquinasInPanel(new MenuTrasportadores());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirLogeoMaquinasInPanel(new IngresoTrasportadores());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirLogeoMaquinasInPanel(new ListadoTrasportadores());
        }

        private void FlechaIzq_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 352)
            {
                MenuVertical.Width = 84;
            }
            else
            {
                MenuVertical.Width = 352;
            }
            FlechaDerecha.Visible = true;
            FlechaIzq.Visible = false;
        }

        private void FlechaDerecha_Click_1(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 84)
            {
                MenuVertical.Width = 352;
            }
            else
            {
                MenuVertical.Width = 84;
            }
            FlechaDerecha.Visible = false;
            FlechaIzq.Visible = true;
        }

        private void IcoRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            IcoRestaurar.Visible = false;
            IcoMaximizar.Visible = true;
        }

        private void IcoMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void IcoMaximizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            IcoRestaurar.Visible = true;
            IcoMaximizar.Visible = false;
        }

        private void IcoCerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas Seguro que deseas cerrar sesion?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
            Login Logeo = new Login();
            Logeo.Show();
        }
        

        private void button5_Click(object sender, EventArgs e)
        {
            MenuPrincipal Mprincipal = new MenuPrincipal();
            Mprincipal.Show();
            this.Close();
        }
    }
}
