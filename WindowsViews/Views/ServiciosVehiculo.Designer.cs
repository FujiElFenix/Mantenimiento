﻿namespace WindowsViews.Views
{
    partial class ServiciosVehiculo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtFechaRegistro = new System.Windows.Forms.TextBox();
            this.TxtObservacion = new System.Windows.Forms.TextBox();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.TxtServicio = new System.Windows.Forms.TextBox();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnBuscarVehiculo = new System.Windows.Forms.Button();
            this.BtnDarDeBaja = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.BtnNuevoVehiculo = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.TxtBuscarCodigo = new System.Windows.Forms.TextBox();
            this.DGVServicios = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVServicios)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(188)))), ((int)(((byte)(229)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.DGVServicios);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.TxtBuscarCodigo);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 551);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.TxtFechaRegistro);
            this.panel2.Controls.Add(this.TxtObservacion);
            this.panel2.Controls.Add(this.TxtPrecio);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.TxtDescripcion);
            this.panel2.Controls.Add(this.TxtServicio);
            this.panel2.Controls.Add(this.TxtCodigo);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(25, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(722, 113);
            this.panel2.TabIndex = 16;
            // 
            // TxtFechaRegistro
            // 
            this.TxtFechaRegistro.Location = new System.Drawing.Point(557, 72);
            this.TxtFechaRegistro.Multiline = true;
            this.TxtFechaRegistro.Name = "TxtFechaRegistro";
            this.TxtFechaRegistro.Size = new System.Drawing.Size(137, 20);
            this.TxtFechaRegistro.TabIndex = 28;
            // 
            // TxtObservacion
            // 
            this.TxtObservacion.Location = new System.Drawing.Point(557, 46);
            this.TxtObservacion.Multiline = true;
            this.TxtObservacion.Name = "TxtObservacion";
            this.TxtObservacion.Size = new System.Drawing.Size(137, 20);
            this.TxtObservacion.TabIndex = 27;
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Location = new System.Drawing.Point(557, 16);
            this.TxtPrecio.Multiline = true;
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(137, 20);
            this.TxtPrecio.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label8.Location = new System.Drawing.Point(410, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Fecha Registro:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label7.Location = new System.Drawing.Point(410, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Observacion:";
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(137, 71);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(137, 20);
            this.TxtDescripcion.TabIndex = 17;
            // 
            // TxtServicio
            // 
            this.TxtServicio.Location = new System.Drawing.Point(137, 47);
            this.TxtServicio.Name = "TxtServicio";
            this.TxtServicio.Size = new System.Drawing.Size(137, 20);
            this.TxtServicio.TabIndex = 16;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(137, 16);
            this.TxtCodigo.Multiline = true;
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(137, 20);
            this.TxtCodigo.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(22, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Codigo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label6.Location = new System.Drawing.Point(410, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Precio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(21, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Servicio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(21, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Descripcion:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.BtnBuscarVehiculo);
            this.panel3.Controls.Add(this.BtnDarDeBaja);
            this.panel3.Controls.Add(this.BtnModificar);
            this.panel3.Controls.Add(this.BtnRegistrar);
            this.panel3.Controls.Add(this.BtnNuevoVehiculo);
            this.panel3.Location = new System.Drawing.Point(106, 183);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(561, 73);
            this.panel3.TabIndex = 29;
            // 
            // BtnBuscarVehiculo
            // 
            this.BtnBuscarVehiculo.Location = new System.Drawing.Point(451, 13);
            this.BtnBuscarVehiculo.Name = "BtnBuscarVehiculo";
            this.BtnBuscarVehiculo.Size = new System.Drawing.Size(94, 44);
            this.BtnBuscarVehiculo.TabIndex = 19;
            this.BtnBuscarVehiculo.Text = "Buscar";
            this.BtnBuscarVehiculo.UseVisualStyleBackColor = true;
            // 
            // BtnDarDeBaja
            // 
            this.BtnDarDeBaja.Location = new System.Drawing.Point(341, 13);
            this.BtnDarDeBaja.Name = "BtnDarDeBaja";
            this.BtnDarDeBaja.Size = new System.Drawing.Size(94, 44);
            this.BtnDarDeBaja.TabIndex = 18;
            this.BtnDarDeBaja.Text = "Dar de baja";
            this.BtnDarDeBaja.UseVisualStyleBackColor = true;
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(229, 13);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(94, 44);
            this.BtnModificar.TabIndex = 17;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Location = new System.Drawing.Point(119, 13);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(94, 44);
            this.BtnRegistrar.TabIndex = 1;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            // 
            // BtnNuevoVehiculo
            // 
            this.BtnNuevoVehiculo.Location = new System.Drawing.Point(12, 13);
            this.BtnNuevoVehiculo.Name = "BtnNuevoVehiculo";
            this.BtnNuevoVehiculo.Size = new System.Drawing.Size(94, 44);
            this.BtnNuevoVehiculo.TabIndex = 0;
            this.BtnNuevoVehiculo.Text = "Nuevo";
            this.BtnNuevoVehiculo.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label14.Location = new System.Drawing.Point(81, 285);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 20);
            this.label14.TabIndex = 34;
            this.label14.Text = "Codigo:";
            // 
            // TxtBuscarCodigo
            // 
            this.TxtBuscarCodigo.Location = new System.Drawing.Point(160, 285);
            this.TxtBuscarCodigo.Multiline = true;
            this.TxtBuscarCodigo.Name = "TxtBuscarCodigo";
            this.TxtBuscarCodigo.Size = new System.Drawing.Size(514, 20);
            this.TxtBuscarCodigo.TabIndex = 35;
            // 
            // DGVServicios
            // 
            this.DGVServicios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVServicios.Location = new System.Drawing.Point(25, 323);
            this.DGVServicios.Name = "DGVServicios";
            this.DGVServicios.Size = new System.Drawing.Size(722, 204);
            this.DGVServicios.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Rockwell", 17F);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(181, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(421, 26);
            this.label5.TabIndex = 37;
            this.label5.Text = "Servicios De Mantencion De Vehiculos";
            // 
            // ServiciosVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(804, 575);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ServiciosVehiculo";
            this.Text = "ServiciosVehiculo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVServicios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TxtFechaRegistro;
        private System.Windows.Forms.TextBox TxtObservacion;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.TextBox TxtServicio;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnBuscarVehiculo;
        private System.Windows.Forms.Button BtnDarDeBaja;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.Button BtnNuevoVehiculo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TxtBuscarCodigo;
        private System.Windows.Forms.DataGridView DGVServicios;
        private System.Windows.Forms.Label label5;
    }
}