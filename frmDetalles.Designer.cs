namespace Gestión_Empleados
{
    partial class frmDetalles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetalles));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboEmpleado = new System.Windows.Forms.ComboBox();
            this.cmdcargar = new System.Windows.Forms.PictureBox();
            this.listbox = new System.Windows.Forms.ListBox();
            this.cmdArchivar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdcargar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdArchivar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1191, 666);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Empleado:";
            // 
            // cboEmpleado
            // 
            this.cboEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEmpleado.FormattingEnabled = true;
            this.cboEmpleado.Location = new System.Drawing.Point(17, 37);
            this.cboEmpleado.Name = "cboEmpleado";
            this.cboEmpleado.Size = new System.Drawing.Size(272, 39);
            this.cboEmpleado.TabIndex = 12;
            // 
            // cmdcargar
            // 
            this.cmdcargar.Image = ((System.Drawing.Image)(resources.GetObject("cmdcargar.Image")));
            this.cmdcargar.Location = new System.Drawing.Point(295, 32);
            this.cmdcargar.Name = "cmdcargar";
            this.cmdcargar.Size = new System.Drawing.Size(45, 45);
            this.cmdcargar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cmdcargar.TabIndex = 15;
            this.cmdcargar.TabStop = false;
            this.cmdcargar.Click += new System.EventHandler(this.cmdcargar_Click);
            // 
            // listbox
            // 
            this.listbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbox.FormattingEnabled = true;
            this.listbox.ItemHeight = 24;
            this.listbox.Location = new System.Drawing.Point(17, 83);
            this.listbox.Name = "listbox";
            this.listbox.Size = new System.Drawing.Size(1168, 628);
            this.listbox.TabIndex = 16;
            this.listbox.SelectedIndexChanged += new System.EventHandler(this.listbox_SelectedIndexChanged);
            // 
            // cmdArchivar
            // 
            this.cmdArchivar.Image = ((System.Drawing.Image)(resources.GetObject("cmdArchivar.Image")));
            this.cmdArchivar.Location = new System.Drawing.Point(1185, 83);
            this.cmdArchivar.Name = "cmdArchivar";
            this.cmdArchivar.Size = new System.Drawing.Size(55, 55);
            this.cmdArchivar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cmdArchivar.TabIndex = 17;
            this.cmdArchivar.TabStop = false;
            this.cmdArchivar.Click += new System.EventHandler(this.cmdArchivar_Click);
            // 
            // frmDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 719);
            this.Controls.Add(this.cmdArchivar);
            this.Controls.Add(this.listbox);
            this.Controls.Add(this.cmdcargar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboEmpleado);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDetalles";
            this.Text = "DETALLES";
            this.Load += new System.EventHandler(this.frmDetalles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdcargar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdArchivar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboEmpleado;
        private System.Windows.Forms.PictureBox cmdcargar;
        private System.Windows.Forms.ListBox listbox;
        private System.Windows.Forms.PictureBox cmdArchivar;
    }
}