namespace Gestión_Empleados
{
    partial class frmRegistrarDias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarDias));
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboEmpleado = new System.Windows.Forms.ComboBox();
            this.UnDia = new System.Windows.Forms.RadioButton();
            this.MedioDia = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkMantenerDetalle = new System.Windows.Forms.CheckBox();
            this.cmdVolver2 = new System.Windows.Forms.PictureBox();
            this.cmdCargar2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cmdVolver2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdCargar2)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFecha
            // 
            this.dtpFecha.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(230, 32);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(126, 30);
            this.dtpFecha.TabIndex = 1;
            this.dtpFecha.Value = new System.DateTime(2023, 8, 29, 21, 38, 53, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccionar Día:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seleccionar Empleado:";
            // 
            // cboEmpleado
            // 
            this.cboEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEmpleado.FormattingEnabled = true;
            this.cboEmpleado.Location = new System.Drawing.Point(310, 87);
            this.cboEmpleado.Name = "cboEmpleado";
            this.cboEmpleado.Size = new System.Drawing.Size(246, 33);
            this.cboEmpleado.TabIndex = 3;
            this.cboEmpleado.SelectedIndexChanged += new System.EventHandler(this.cboEmpleado_SelectedIndexChanged);
            // 
            // UnDia
            // 
            this.UnDia.Appearance = System.Windows.Forms.Appearance.Button;
            this.UnDia.AutoSize = true;
            this.UnDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnDia.Location = new System.Drawing.Point(686, 56);
            this.UnDia.Name = "UnDia";
            this.UnDia.Size = new System.Drawing.Size(129, 56);
            this.UnDia.TabIndex = 4;
            this.UnDia.TabStop = true;
            this.UnDia.Text = "1 DIA";
            this.UnDia.UseVisualStyleBackColor = true;
            this.UnDia.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // MedioDia
            // 
            this.MedioDia.Appearance = System.Windows.Forms.Appearance.Button;
            this.MedioDia.AutoSize = true;
            this.MedioDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedioDia.Location = new System.Drawing.Point(840, 56);
            this.MedioDia.Name = "MedioDia";
            this.MedioDia.Size = new System.Drawing.Size(162, 56);
            this.MedioDia.TabIndex = 4;
            this.MedioDia.TabStop = true;
            this.MedioDia.Text = "1/2 DIA";
            this.MedioDia.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Detalle:";
            // 
            // txtDetalle
            // 
            this.txtDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetalle.Location = new System.Drawing.Point(125, 155);
            this.txtDetalle.MaxLength = 92;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(853, 30);
            this.txtDetalle.TabIndex = 5;
            this.txtDetalle.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(35, 227);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(99, 30);
            this.txtPrecio.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "$";
            // 
            // chkMantenerDetalle
            // 
            this.chkMantenerDetalle.AutoSize = true;
            this.chkMantenerDetalle.Location = new System.Drawing.Point(125, 186);
            this.chkMantenerDetalle.Name = "chkMantenerDetalle";
            this.chkMantenerDetalle.Size = new System.Drawing.Size(107, 17);
            this.chkMantenerDetalle.TabIndex = 10;
            this.chkMantenerDetalle.Text = "Mantener Detalle";
            this.chkMantenerDetalle.UseVisualStyleBackColor = true;
            // 
            // cmdVolver2
            // 
            this.cmdVolver2.Image = ((System.Drawing.Image)(resources.GetObject("cmdVolver2.Image")));
            this.cmdVolver2.Location = new System.Drawing.Point(933, 215);
            this.cmdVolver2.Name = "cmdVolver2";
            this.cmdVolver2.Size = new System.Drawing.Size(45, 45);
            this.cmdVolver2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cmdVolver2.TabIndex = 11;
            this.cmdVolver2.TabStop = false;
            this.cmdVolver2.Click += new System.EventHandler(this.cmdVolver2_Click);
            // 
            // cmdCargar2
            // 
            this.cmdCargar2.Image = ((System.Drawing.Image)(resources.GetObject("cmdCargar2.Image")));
            this.cmdCargar2.Location = new System.Drawing.Point(998, 215);
            this.cmdCargar2.Name = "cmdCargar2";
            this.cmdCargar2.Size = new System.Drawing.Size(45, 45);
            this.cmdCargar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cmdCargar2.TabIndex = 12;
            this.cmdCargar2.TabStop = false;
            this.cmdCargar2.Click += new System.EventHandler(this.cmdCargar2_Click);
            // 
            // frmRegistrarDias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 272);
            this.Controls.Add(this.cmdCargar2);
            this.Controls.Add(this.cmdVolver2);
            this.Controls.Add(this.chkMantenerDetalle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.MedioDia);
            this.Controls.Add(this.UnDia);
            this.Controls.Add(this.cboEmpleado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFecha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegistrarDias";
            this.Text = "REGISTRAR DÍAS";
            this.Load += new System.EventHandler(this.frmRegistrarDias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmdVolver2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdCargar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboEmpleado;
        private System.Windows.Forms.RadioButton UnDia;
        private System.Windows.Forms.RadioButton MedioDia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkMantenerDetalle;
        private System.Windows.Forms.PictureBox cmdVolver2;
        private System.Windows.Forms.PictureBox cmdCargar2;
    }
}