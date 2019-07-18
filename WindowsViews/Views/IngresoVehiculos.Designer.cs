namespace WindowsViews.Views
{
    partial class IngresoVehiculos
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
            this.BtnSalir = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.TxtChasis = new System.Windows.Forms.TextBox();
            this.TxtMotor = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtModelo = new System.Windows.Forms.TextBox();
            this.TxtColor = new System.Windows.Forms.TextBox();
            this.TxtMarca = new System.Windows.Forms.TextBox();
            this.TxtPatente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnNuevoVehiculo = new System.Windows.Forms.Button();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnDarDeBaja = new System.Windows.Forms.Button();
            this.BtnBuscarVehiculo = new System.Windows.Forms.Button();
            this.TxtPatenteBuscar = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.DGVehiculos = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(188)))), ((int)(((byte)(229)))));
            this.panel1.Controls.Add(this.DGVehiculos);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.TxtPatenteBuscar);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.BtnSalir);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 551);
            this.panel1.TabIndex = 0;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalir.AutoSize = true;
            this.BtnSalir.BackColor = System.Drawing.Color.White;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.BtnSalir.ForeColor = System.Drawing.Color.Maroon;
            this.BtnSalir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnSalir.Location = new System.Drawing.Point(754, 0);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(26, 25);
            this.BtnSalir.TabIndex = 4;
            this.BtnSalir.Text = "X";
            this.BtnSalir.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.textBox7);
            this.panel2.Controls.Add(this.textBox6);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.TxtChasis);
            this.panel2.Controls.Add(this.TxtMotor);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.TxtModelo);
            this.panel2.Controls.Add(this.TxtColor);
            this.panel2.Controls.Add(this.TxtMarca);
            this.panel2.Controls.Add(this.TxtPatente);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(32, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(722, 147);
            this.panel2.TabIndex = 15;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(522, 84);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(118, 20);
            this.textBox7.TabIndex = 32;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(522, 56);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(118, 20);
            this.textBox6.TabIndex = 31;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(522, 30);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(118, 20);
            this.textBox5.TabIndex = 30;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(307, 100);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(137, 20);
            this.textBox4.TabIndex = 29;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(307, 74);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(137, 20);
            this.textBox3.TabIndex = 28;
            // 
            // TxtChasis
            // 
            this.TxtChasis.Location = new System.Drawing.Point(307, 48);
            this.TxtChasis.Multiline = true;
            this.TxtChasis.Name = "TxtChasis";
            this.TxtChasis.Size = new System.Drawing.Size(137, 20);
            this.TxtChasis.TabIndex = 27;
            // 
            // TxtMotor
            // 
            this.TxtMotor.Location = new System.Drawing.Point(307, 18);
            this.TxtMotor.Multiline = true;
            this.TxtMotor.Name = "TxtMotor";
            this.TxtMotor.Size = new System.Drawing.Size(137, 20);
            this.TxtMotor.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label12.Location = new System.Drawing.Point(450, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 20);
            this.label12.TabIndex = 25;
            this.label12.Text = "Cliente:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label11.Location = new System.Drawing.Point(450, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "Rut:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label10.Location = new System.Drawing.Point(450, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "Codigo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label9.Location = new System.Drawing.Point(234, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Año:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label8.Location = new System.Drawing.Point(234, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Metraje:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label7.Location = new System.Drawing.Point(234, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Chasis:";
            // 
            // TxtModelo
            // 
            this.TxtModelo.Location = new System.Drawing.Point(91, 97);
            this.TxtModelo.Name = "TxtModelo";
            this.TxtModelo.Size = new System.Drawing.Size(137, 20);
            this.TxtModelo.TabIndex = 18;
            // 
            // TxtColor
            // 
            this.TxtColor.Location = new System.Drawing.Point(91, 71);
            this.TxtColor.Name = "TxtColor";
            this.TxtColor.Size = new System.Drawing.Size(137, 20);
            this.TxtColor.TabIndex = 17;
            // 
            // TxtMarca
            // 
            this.TxtMarca.Location = new System.Drawing.Point(91, 47);
            this.TxtMarca.Name = "TxtMarca";
            this.TxtMarca.Size = new System.Drawing.Size(137, 20);
            this.TxtMarca.TabIndex = 16;
            // 
            // TxtPatente
            // 
            this.TxtPatente.Location = new System.Drawing.Point(91, 16);
            this.TxtPatente.Multiline = true;
            this.TxtPatente.Name = "TxtPatente";
            this.TxtPatente.Size = new System.Drawing.Size(137, 20);
            this.TxtPatente.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Patente:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label6.Location = new System.Drawing.Point(234, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Motor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Marca:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(14, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Modelo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(13, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Color:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Rockwell", 17F);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(215, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(325, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ingreso De Nuevos Vehiculos";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.BtnBuscarVehiculo);
            this.panel3.Controls.Add(this.BtnDarDeBaja);
            this.panel3.Controls.Add(this.BtnModificar);
            this.panel3.Controls.Add(this.BtnRegistrar);
            this.panel3.Controls.Add(this.BtnNuevoVehiculo);
            this.panel3.Location = new System.Drawing.Point(113, 213);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(561, 73);
            this.panel3.TabIndex = 16;
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
            // BtnRegistrar
            // 
            this.BtnRegistrar.Location = new System.Drawing.Point(119, 13);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(94, 44);
            this.BtnRegistrar.TabIndex = 1;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.UseVisualStyleBackColor = true;
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
            // BtnDarDeBaja
            // 
            this.BtnDarDeBaja.Location = new System.Drawing.Point(341, 13);
            this.BtnDarDeBaja.Name = "BtnDarDeBaja";
            this.BtnDarDeBaja.Size = new System.Drawing.Size(94, 44);
            this.BtnDarDeBaja.TabIndex = 18;
            this.BtnDarDeBaja.Text = "Dar de baja";
            this.BtnDarDeBaja.UseVisualStyleBackColor = true;
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
            // TxtPatenteBuscar
            // 
            this.TxtPatenteBuscar.Location = new System.Drawing.Point(127, 318);
            this.TxtPatenteBuscar.Multiline = true;
            this.TxtPatenteBuscar.Name = "TxtPatenteBuscar";
            this.TxtPatenteBuscar.Size = new System.Drawing.Size(514, 20);
            this.TxtPatenteBuscar.TabIndex = 33;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label14.Location = new System.Drawing.Point(48, 318);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 20);
            this.label14.TabIndex = 33;
            this.label14.Text = "Patente:";
            // 
            // DGVehiculos
            // 
            this.DGVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVehiculos.Location = new System.Drawing.Point(32, 358);
            this.DGVehiculos.Name = "DGVehiculos";
            this.DGVehiculos.Size = new System.Drawing.Size(722, 175);
            this.DGVehiculos.TabIndex = 34;
            // 
            // IngresoVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(804, 575);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IngresoVehiculos";
            this.Text = "IngresoVehiculos";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.IngresoVehiculos_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVehiculos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TxtModelo;
        private System.Windows.Forms.TextBox TxtColor;
        private System.Windows.Forms.TextBox TxtMarca;
        private System.Windows.Forms.TextBox TxtPatente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label BtnSalir;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox TxtChasis;
        private System.Windows.Forms.TextBox TxtMotor;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnNuevoVehiculo;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.Button BtnDarDeBaja;
        private System.Windows.Forms.Button BtnBuscarVehiculo;
        private System.Windows.Forms.TextBox TxtPatenteBuscar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView DGVehiculos;
    }
}