namespace WindowsViews.Views
{
    partial class MantencionMaquinarias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantencionMaquinarias));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DgvListadoMaquinaria = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMaquina = new System.Windows.Forms.TextBox();
            this.TxtActividadAsociada = new System.Windows.Forms.TextBox();
            this.TxtConsumoLubricante = new System.Windows.Forms.TextBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.TxtDiasFaltantes = new System.Windows.Forms.TextBox();
            this.CboFrecuencia = new System.Windows.Forms.ComboBox();
            this.DatePickerFechaProximaMantencion = new System.Windows.Forms.DateTimePicker();
            this.DatePickerFechaUltimaMantencion = new System.Windows.Forms.DateTimePicker();
            this.RbInterna = new System.Windows.Forms.RadioButton();
            this.RbExterna = new System.Windows.Forms.RadioButton();
            this.BtnSalir = new System.Windows.Forms.Label();
            this.BtnAgregarMantencion = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificarDetalleMaquina = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnNuevaMaquina = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoMaquinaria)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(188)))), ((int)(((byte)(229)))));
            this.panel1.Controls.Add(this.BtnSalir);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 550);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Rockwell", 17F);
            this.label5.Location = new System.Drawing.Point(245, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(261, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mantencion Maquinaria";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.BtnModificar);
            this.panel2.Controls.Add(this.BtnNuevaMaquina);
            this.panel2.Controls.Add(this.BtnBuscar);
            this.panel2.Controls.Add(this.DgvListadoMaquinaria);
            this.panel2.Location = new System.Drawing.Point(19, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(349, 287);
            this.panel2.TabIndex = 5;
            // 
            // DgvListadoMaquinaria
            // 
            this.DgvListadoMaquinaria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListadoMaquinaria.Location = new System.Drawing.Point(3, 39);
            this.DgvListadoMaquinaria.Name = "DgvListadoMaquinaria";
            this.DgvListadoMaquinaria.Size = new System.Drawing.Size(343, 194);
            this.DgvListadoMaquinaria.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Rockwell", 17F);
            this.label1.Location = new System.Drawing.Point(75, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Listado Maquinaria";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BtnEliminar);
            this.panel3.Controls.Add(this.BtnModificarDetalleMaquina);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(399, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(361, 287);
            this.panel3.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Rockwell", 17F);
            this.label2.Location = new System.Drawing.Point(98, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Detalle Maquina";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(355, 194);
            this.dataGridView1.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.RbExterna);
            this.panel4.Controls.Add(this.BtnAgregarMantencion);
            this.panel4.Controls.Add(this.RbInterna);
            this.panel4.Controls.Add(this.DatePickerFechaUltimaMantencion);
            this.panel4.Controls.Add(this.DatePickerFechaProximaMantencion);
            this.panel4.Controls.Add(this.CboFrecuencia);
            this.panel4.Controls.Add(this.TxtDiasFaltantes);
            this.panel4.Controls.Add(this.TxtDescripcion);
            this.panel4.Controls.Add(this.TxtConsumoLubricante);
            this.panel4.Controls.Add(this.TxtActividadAsociada);
            this.panel4.Controls.Add(this.txtMaquina);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(19, 350);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(741, 184);
            this.panel4.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Rockwell", 17F);
            this.label3.Location = new System.Drawing.Point(8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(421, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Agregar Mantencion a las maquinarias";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Maquina:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(326, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Descripcion: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Actividad Asociada:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Consumio Lubricante";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Frecuencia Recomendada:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(326, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Fecha Ultima mantencion:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(326, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Fecha Proxima Mantencion: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(326, 107);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Dias Faltantes:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(326, 133);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Actividad";
            // 
            // txtMaquina
            // 
            this.txtMaquina.Location = new System.Drawing.Point(159, 38);
            this.txtMaquina.Name = "txtMaquina";
            this.txtMaquina.Size = new System.Drawing.Size(161, 20);
            this.txtMaquina.TabIndex = 17;
            // 
            // TxtActividadAsociada
            // 
            this.TxtActividadAsociada.Location = new System.Drawing.Point(159, 62);
            this.TxtActividadAsociada.Name = "TxtActividadAsociada";
            this.TxtActividadAsociada.Size = new System.Drawing.Size(161, 20);
            this.TxtActividadAsociada.TabIndex = 18;
            // 
            // TxtConsumoLubricante
            // 
            this.TxtConsumoLubricante.Location = new System.Drawing.Point(159, 90);
            this.TxtConsumoLubricante.Name = "TxtConsumoLubricante";
            this.TxtConsumoLubricante.Size = new System.Drawing.Size(161, 20);
            this.TxtConsumoLubricante.TabIndex = 19;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(462, 38);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(161, 20);
            this.TxtDescripcion.TabIndex = 21;
            // 
            // TxtDiasFaltantes
            // 
            this.TxtDiasFaltantes.Location = new System.Drawing.Point(462, 107);
            this.TxtDiasFaltantes.Name = "TxtDiasFaltantes";
            this.TxtDiasFaltantes.Size = new System.Drawing.Size(161, 20);
            this.TxtDiasFaltantes.TabIndex = 24;
            // 
            // CboFrecuencia
            // 
            this.CboFrecuencia.FormattingEnabled = true;
            this.CboFrecuencia.Location = new System.Drawing.Point(159, 117);
            this.CboFrecuencia.Name = "CboFrecuencia";
            this.CboFrecuencia.Size = new System.Drawing.Size(161, 21);
            this.CboFrecuencia.TabIndex = 26;
            // 
            // DatePickerFechaProximaMantencion
            // 
            this.DatePickerFechaProximaMantencion.Location = new System.Drawing.Point(462, 84);
            this.DatePickerFechaProximaMantencion.Name = "DatePickerFechaProximaMantencion";
            this.DatePickerFechaProximaMantencion.Size = new System.Drawing.Size(161, 20);
            this.DatePickerFechaProximaMantencion.TabIndex = 27;
            // 
            // DatePickerFechaUltimaMantencion
            // 
            this.DatePickerFechaUltimaMantencion.Location = new System.Drawing.Point(462, 62);
            this.DatePickerFechaUltimaMantencion.Name = "DatePickerFechaUltimaMantencion";
            this.DatePickerFechaUltimaMantencion.Size = new System.Drawing.Size(161, 20);
            this.DatePickerFechaUltimaMantencion.TabIndex = 28;
            // 
            // RbInterna
            // 
            this.RbInterna.AutoSize = true;
            this.RbInterna.Location = new System.Drawing.Point(462, 133);
            this.RbInterna.Name = "RbInterna";
            this.RbInterna.Size = new System.Drawing.Size(58, 17);
            this.RbInterna.TabIndex = 29;
            this.RbInterna.TabStop = true;
            this.RbInterna.Text = "Interna";
            this.RbInterna.UseVisualStyleBackColor = true;
            // 
            // RbExterna
            // 
            this.RbExterna.AutoSize = true;
            this.RbExterna.Location = new System.Drawing.Point(548, 133);
            this.RbExterna.Name = "RbExterna";
            this.RbExterna.Size = new System.Drawing.Size(61, 17);
            this.RbExterna.TabIndex = 30;
            this.RbExterna.TabStop = true;
            this.RbExterna.Text = "Externa";
            this.RbExterna.UseVisualStyleBackColor = true;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalir.AutoSize = true;
            this.BtnSalir.BackColor = System.Drawing.Color.White;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.BtnSalir.ForeColor = System.Drawing.Color.Maroon;
            this.BtnSalir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnSalir.Location = new System.Drawing.Point(753, 0);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(26, 25);
            this.BtnSalir.TabIndex = 31;
            this.BtnSalir.Text = "X";
            this.BtnSalir.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnAgregarMantencion
            // 
            this.BtnAgregarMantencion.Image = ((System.Drawing.Image)(resources.GetObject("BtnAgregarMantencion.Image")));
            this.BtnAgregarMantencion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgregarMantencion.Location = new System.Drawing.Point(3, 133);
            this.BtnAgregarMantencion.Name = "BtnAgregarMantencion";
            this.BtnAgregarMantencion.Size = new System.Drawing.Size(94, 48);
            this.BtnAgregarMantencion.TabIndex = 7;
            this.BtnAgregarMantencion.Text = "Agregar";
            this.BtnAgregarMantencion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAgregarMantencion.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminar.Image")));
            this.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEliminar.Location = new System.Drawing.Point(243, 239);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(85, 40);
            this.BtnEliminar.TabIndex = 9;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnModificarDetalleMaquina
            // 
            this.BtnModificarDetalleMaquina.Image = ((System.Drawing.Image)(resources.GetObject("BtnModificarDetalleMaquina.Image")));
            this.BtnModificarDetalleMaquina.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnModificarDetalleMaquina.Location = new System.Drawing.Point(46, 239);
            this.BtnModificarDetalleMaquina.Name = "BtnModificarDetalleMaquina";
            this.BtnModificarDetalleMaquina.Size = new System.Drawing.Size(94, 40);
            this.BtnModificarDetalleMaquina.TabIndex = 8;
            this.BtnModificarDetalleMaquina.Text = "Modificar";
            this.BtnModificarDetalleMaquina.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnModificarDetalleMaquina.UseVisualStyleBackColor = true;
            // 
            // BtnModificar
            // 
            this.BtnModificar.Image = ((System.Drawing.Image)(resources.GetObject("BtnModificar.Image")));
            this.BtnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnModificar.Location = new System.Drawing.Point(257, 239);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(89, 40);
            this.BtnModificar.TabIndex = 3;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnModificar.UseVisualStyleBackColor = true;
            // 
            // BtnNuevaMaquina
            // 
            this.BtnNuevaMaquina.Image = ((System.Drawing.Image)(resources.GetObject("BtnNuevaMaquina.Image")));
            this.BtnNuevaMaquina.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNuevaMaquina.Location = new System.Drawing.Point(115, 239);
            this.BtnNuevaMaquina.Name = "BtnNuevaMaquina";
            this.BtnNuevaMaquina.Size = new System.Drawing.Size(100, 40);
            this.BtnNuevaMaquina.TabIndex = 2;
            this.BtnNuevaMaquina.Text = "Nueva maquinaria";
            this.BtnNuevaMaquina.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNuevaMaquina.UseVisualStyleBackColor = true;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscar.Location = new System.Drawing.Point(3, 239);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(81, 40);
            this.BtnBuscar.TabIndex = 1;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // MantencionMaquinarias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(804, 575);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MantencionMaquinarias";
            this.Text = "MantencionMaquinarias";
            this.Load += new System.EventHandler(this.MantencionMaquinarias_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MantencionMaquinarias_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoMaquinaria)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DgvListadoMaquinaria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnNuevaMaquina;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnModificarDetalleMaquina;
        private System.Windows.Forms.Button BtnAgregarMantencion;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtDiasFaltantes;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.TextBox TxtConsumoLubricante;
        private System.Windows.Forms.TextBox TxtActividadAsociada;
        private System.Windows.Forms.TextBox txtMaquina;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox CboFrecuencia;
        private System.Windows.Forms.RadioButton RbExterna;
        private System.Windows.Forms.RadioButton RbInterna;
        private System.Windows.Forms.DateTimePicker DatePickerFechaUltimaMantencion;
        private System.Windows.Forms.DateTimePicker DatePickerFechaProximaMantencion;
        private System.Windows.Forms.Label BtnSalir;
    }
}