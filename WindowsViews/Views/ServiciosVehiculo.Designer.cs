namespace WindowsViews.Views
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.TxtChasis = new System.Windows.Forms.TextBox();
            this.TxtMotor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtColor = new System.Windows.Forms.TextBox();
            this.TxtMarca = new System.Windows.Forms.TextBox();
            this.TxtPatente = new System.Windows.Forms.TextBox();
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
            this.TxtPatenteBuscar = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(188)))), ((int)(((byte)(229)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.TxtPatenteBuscar);
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
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.TxtChasis);
            this.panel2.Controls.Add(this.TxtMotor);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.TxtColor);
            this.panel2.Controls.Add(this.TxtMarca);
            this.panel2.Controls.Add(this.TxtPatente);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(25, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(722, 113);
            this.panel2.TabIndex = 16;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(557, 72);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(137, 20);
            this.textBox3.TabIndex = 28;
            // 
            // TxtChasis
            // 
            this.TxtChasis.Location = new System.Drawing.Point(557, 46);
            this.TxtChasis.Multiline = true;
            this.TxtChasis.Name = "TxtChasis";
            this.TxtChasis.Size = new System.Drawing.Size(137, 20);
            this.TxtChasis.TabIndex = 27;
            // 
            // TxtMotor
            // 
            this.TxtMotor.Location = new System.Drawing.Point(557, 16);
            this.TxtMotor.Multiline = true;
            this.TxtMotor.Name = "TxtMotor";
            this.TxtMotor.Size = new System.Drawing.Size(137, 20);
            this.TxtMotor.TabIndex = 26;
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
            // TxtColor
            // 
            this.TxtColor.Location = new System.Drawing.Point(137, 71);
            this.TxtColor.Name = "TxtColor";
            this.TxtColor.Size = new System.Drawing.Size(137, 20);
            this.TxtColor.TabIndex = 17;
            // 
            // TxtMarca
            // 
            this.TxtMarca.Location = new System.Drawing.Point(137, 47);
            this.TxtMarca.Name = "TxtMarca";
            this.TxtMarca.Size = new System.Drawing.Size(137, 20);
            this.TxtMarca.TabIndex = 16;
            // 
            // TxtPatente
            // 
            this.TxtPatente.Location = new System.Drawing.Point(137, 16);
            this.TxtPatente.Multiline = true;
            this.TxtPatente.Name = "TxtPatente";
            this.TxtPatente.Size = new System.Drawing.Size(137, 20);
            this.TxtPatente.TabIndex = 15;
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
            // TxtPatenteBuscar
            // 
            this.TxtPatenteBuscar.Location = new System.Drawing.Point(160, 285);
            this.TxtPatenteBuscar.Multiline = true;
            this.TxtPatenteBuscar.Name = "TxtPatenteBuscar";
            this.TxtPatenteBuscar.Size = new System.Drawing.Size(514, 20);
            this.TxtPatenteBuscar.TabIndex = 35;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 323);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(722, 204);
            this.dataGridView1.TabIndex = 36;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox TxtChasis;
        private System.Windows.Forms.TextBox TxtMotor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtColor;
        private System.Windows.Forms.TextBox TxtMarca;
        private System.Windows.Forms.TextBox TxtPatente;
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
        private System.Windows.Forms.TextBox TxtPatenteBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
    }
}