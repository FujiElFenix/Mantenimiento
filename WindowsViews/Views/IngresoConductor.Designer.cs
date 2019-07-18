namespace WindowsViews.Views
{
    partial class IngresoConductor_
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtRutCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnBuscarConductor = new System.Windows.Forms.Button();
            this.BtnDarDeBaja = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.DGVConductores = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.TxtRut = new System.Windows.Forms.TextBox();
            this.dBMantencionDataSet2 = new WindowsViews.DBMantencionDataSet2();
            this.conductorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.conductorTableAdapter = new WindowsViews.DBMantencionDataSet2TableAdapters.ConductorTableAdapter();
            this.rutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVConductores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBMantencionDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conductorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(188)))), ((int)(((byte)(229)))));
            this.panel1.Controls.Add(this.DGVConductores);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.TxtRut);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 551);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Rockwell", 17F);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(224, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(356, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ingreso De Nuevos Conductores";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.TxtMail);
            this.panel2.Controls.Add(this.TxtTelefono);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.TxtDireccion);
            this.panel2.Controls.Add(this.TxtNombre);
            this.panel2.Controls.Add(this.TxtRutCliente);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(29, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(722, 113);
            this.panel2.TabIndex = 17;
            // 
            // TxtMail
            // 
            this.TxtMail.Location = new System.Drawing.Point(557, 46);
            this.TxtMail.Multiline = true;
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(137, 20);
            this.TxtMail.TabIndex = 27;
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(557, 16);
            this.TxtTelefono.Multiline = true;
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(137, 20);
            this.TxtTelefono.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label7.Location = new System.Drawing.Point(410, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Mail:";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(137, 71);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(137, 20);
            this.TxtDireccion.TabIndex = 17;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(137, 47);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(137, 20);
            this.TxtNombre.TabIndex = 16;
            // 
            // TxtRutCliente
            // 
            this.TxtRutCliente.Location = new System.Drawing.Point(137, 16);
            this.TxtRutCliente.Multiline = true;
            this.TxtRutCliente.Name = "TxtRutCliente";
            this.TxtRutCliente.Size = new System.Drawing.Size(137, 20);
            this.TxtRutCliente.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(22, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Rut:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label6.Location = new System.Drawing.Point(410, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Telefono:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(21, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(21, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Direccion:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.BtnBuscarConductor);
            this.panel3.Controls.Add(this.BtnDarDeBaja);
            this.panel3.Controls.Add(this.BtnModificar);
            this.panel3.Controls.Add(this.BtnRegistrar);
            this.panel3.Controls.Add(this.BtnLimpiar);
            this.panel3.Location = new System.Drawing.Point(105, 180);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(561, 73);
            this.panel3.TabIndex = 30;
            // 
            // BtnBuscarConductor
            // 
            this.BtnBuscarConductor.Location = new System.Drawing.Point(451, 13);
            this.BtnBuscarConductor.Name = "BtnBuscarConductor";
            this.BtnBuscarConductor.Size = new System.Drawing.Size(94, 44);
            this.BtnBuscarConductor.TabIndex = 19;
            this.BtnBuscarConductor.Text = "Buscar Conductor";
            this.BtnBuscarConductor.UseVisualStyleBackColor = true;
            this.BtnBuscarConductor.Click += new System.EventHandler(this.BtnBuscarConductor_Click);
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
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Location = new System.Drawing.Point(119, 13);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(94, 44);
            this.BtnRegistrar.TabIndex = 1;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(12, 13);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(94, 44);
            this.BtnLimpiar.TabIndex = 0;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // DGVConductores
            // 
            this.DGVConductores.AutoGenerateColumns = false;
            this.DGVConductores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVConductores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVConductores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rutDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.DGVConductores.DataSource = this.conductorBindingSource;
            this.DGVConductores.Location = new System.Drawing.Point(89, 316);
            this.DGVConductores.Name = "DGVConductores";
            this.DGVConductores.Size = new System.Drawing.Size(601, 204);
            this.DGVConductores.TabIndex = 39;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label14.Location = new System.Drawing.Point(85, 276);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 20);
            this.label14.TabIndex = 37;
            this.label14.Text = "Rut:";
            // 
            // TxtRut
            // 
            this.TxtRut.Location = new System.Drawing.Point(152, 276);
            this.TxtRut.Multiline = true;
            this.TxtRut.Name = "TxtRut";
            this.TxtRut.Size = new System.Drawing.Size(514, 20);
            this.TxtRut.TabIndex = 38;
            // 
            // dBMantencionDataSet2
            // 
            this.dBMantencionDataSet2.DataSetName = "DBMantencionDataSet2";
            this.dBMantencionDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // conductorBindingSource
            // 
            this.conductorBindingSource.DataMember = "Conductor";
            this.conductorBindingSource.DataSource = this.dBMantencionDataSet2;
            // 
            // conductorTableAdapter
            // 
            this.conductorTableAdapter.ClearBeforeFill = true;
            // 
            // rutDataGridViewTextBoxColumn
            // 
            this.rutDataGridViewTextBoxColumn.DataPropertyName = "Rut";
            this.rutDataGridViewTextBoxColumn.HeaderText = "Rut";
            this.rutDataGridViewTextBoxColumn.Name = "rutDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // IngresoConductor_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(804, 575);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IngresoConductor_";
            this.Text = "IngresoConductor_";
            this.Load += new System.EventHandler(this.IngresoConductor__Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVConductores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBMantencionDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conductorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtRutCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnBuscarConductor;
        private System.Windows.Forms.Button BtnDarDeBaja;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.DataGridView DGVConductores;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TxtRut;
        private DBMantencionDataSet2 dBMantencionDataSet2;
        private System.Windows.Forms.BindingSource conductorBindingSource;
        private DBMantencionDataSet2TableAdapters.ConductorTableAdapter conductorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    }
}