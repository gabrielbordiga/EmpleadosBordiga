namespace Gestión_Empleados
{
    partial class frmAgregarEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarEmpleado));
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdVolver = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cmdCargare = new System.Windows.Forms.PictureBox();
            this.cmdRefresh = new System.Windows.Forms.PictureBox();
            this.cmdBorrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cmdVolver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdCargare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdBorrar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpleado.Location = new System.Drawing.Point(12, 58);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(453, 38);
            this.txtEmpleado.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "AGREGAR";
            // 
            // cmdVolver
            // 
            this.cmdVolver.Image = ((System.Drawing.Image)(resources.GetObject("cmdVolver.Image")));
            this.cmdVolver.Location = new System.Drawing.Point(471, 309);
            this.cmdVolver.Name = "cmdVolver";
            this.cmdVolver.Size = new System.Drawing.Size(45, 45);
            this.cmdVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cmdVolver.TabIndex = 6;
            this.cmdVolver.TabStop = false;
            this.cmdVolver.Click += new System.EventHandler(this.cmdVolver_Click_1);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 31;
            this.listBox1.Location = new System.Drawing.Point(13, 102);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(452, 252);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // cmdCargare
            // 
            this.cmdCargare.Image = ((System.Drawing.Image)(resources.GetObject("cmdCargare.Image")));
            this.cmdCargare.Location = new System.Drawing.Point(473, 56);
            this.cmdCargare.Name = "cmdCargare";
            this.cmdCargare.Size = new System.Drawing.Size(40, 40);
            this.cmdCargare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cmdCargare.TabIndex = 8;
            this.cmdCargare.TabStop = false;
            this.cmdCargare.Click += new System.EventHandler(this.cmdCargare_Click);
            // 
            // cmdRefresh
            // 
            this.cmdRefresh.Image = ((System.Drawing.Image)(resources.GetObject("cmdRefresh.Image")));
            this.cmdRefresh.Location = new System.Drawing.Point(471, 102);
            this.cmdRefresh.Name = "cmdRefresh";
            this.cmdRefresh.Size = new System.Drawing.Size(45, 45);
            this.cmdRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cmdRefresh.TabIndex = 9;
            this.cmdRefresh.TabStop = false;
            this.cmdRefresh.Click += new System.EventHandler(this.cmdRefresh_Click);
            // 
            // cmdBorrar
            // 
            this.cmdBorrar.Image = ((System.Drawing.Image)(resources.GetObject("cmdBorrar.Image")));
            this.cmdBorrar.Location = new System.Drawing.Point(471, 150);
            this.cmdBorrar.Name = "cmdBorrar";
            this.cmdBorrar.Size = new System.Drawing.Size(45, 45);
            this.cmdBorrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cmdBorrar.TabIndex = 12;
            this.cmdBorrar.TabStop = false;
            this.cmdBorrar.Click += new System.EventHandler(this.cmdBorrar_Click);
            // 
            // frmAgregarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 370);
            this.Controls.Add(this.cmdBorrar);
            this.Controls.Add(this.cmdRefresh);
            this.Controls.Add(this.cmdCargare);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cmdVolver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmpleado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAgregarEmpleado";
            this.Text = "AGREGAR EMPLEADO";
            this.Load += new System.EventHandler(this.frmAgregarEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmdVolver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdCargare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdBorrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox cmdVolver;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox cmdCargare;
        private System.Windows.Forms.PictureBox cmdRefresh;
        private System.Windows.Forms.PictureBox cmdBorrar;
    }
}