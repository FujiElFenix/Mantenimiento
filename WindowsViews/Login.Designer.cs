namespace WindowsViews
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Label();
            this.BtnIngresarMaquinas = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(332, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // BtnSalir
            // 
            this.BtnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalir.AutoSize = true;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.BtnSalir.ForeColor = System.Drawing.Color.Maroon;
            this.BtnSalir.Location = new System.Drawing.Point(740, 9);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(26, 25);
            this.BtnSalir.TabIndex = 3;
            this.BtnSalir.Text = "X";
            this.BtnSalir.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnIngresarMaquinas
            // 
            this.BtnIngresarMaquinas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BtnIngresarMaquinas.FlatAppearance.BorderSize = 0;
            this.BtnIngresarMaquinas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtnIngresarMaquinas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIngresarMaquinas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.BtnIngresarMaquinas.ForeColor = System.Drawing.Color.White;
            this.BtnIngresarMaquinas.Image = ((System.Drawing.Image)(resources.GetObject("BtnIngresarMaquinas.Image")));
            this.BtnIngresarMaquinas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnIngresarMaquinas.Location = new System.Drawing.Point(213, 375);
            this.BtnIngresarMaquinas.Name = "BtnIngresarMaquinas";
            this.BtnIngresarMaquinas.Size = new System.Drawing.Size(352, 40);
            this.BtnIngresarMaquinas.TabIndex = 2;
            this.BtnIngresarMaquinas.Text = "Ingresar Modulo Maquinas";
            this.BtnIngresarMaquinas.UseVisualStyleBackColor = false;
            this.BtnIngresarMaquinas.Click += new System.EventHandler(this.BtnGestionMaquinas_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(228, 180);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(309, 31);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Username";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.textBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox2.Location = new System.Drawing.Point(228, 273);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(309, 31);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Password";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(778, 669);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnIngresarMaquinas);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Opacity = 0.1D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnIngresarMaquinas;
        private System.Windows.Forms.Label BtnSalir;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}