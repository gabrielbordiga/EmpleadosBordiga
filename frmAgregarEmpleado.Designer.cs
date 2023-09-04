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
            this.cmdVolver = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cmdCargare = new System.Windows.Forms.PictureBox();
            this.cmdBorrar = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cmdVolver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdCargare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdBorrar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpleado.Location = new System.Drawing.Point(11, 32);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(454, 38);
            this.txtEmpleado.TabIndex = 1;
            this.txtEmpleado.TextChanged += new System.EventHandler(this.txtEmpleado_TextChanged);
            this.txtEmpleado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmpleado_KeyDown);
            this.txtEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmpleado_KeyPress);
            // 
            // cmdVolver
            // 
            this.cmdVolver.Image = ((System.Drawing.Image)(resources.GetObject("cmdVolver.Image")));
            this.cmdVolver.Location = new System.Drawing.Point(471, 252);
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
            this.listBox1.Location = new System.Drawing.Point(12, 76);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(452, 221);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // cmdCargare
            // 
            this.cmdCargare.Image = ((System.Drawing.Image)(resources.GetObject("cmdCargare.Image")));
            this.cmdCargare.Location = new System.Drawing.Point(471, 30);
            this.cmdCargare.Name = "cmdCargare";
            this.cmdCargare.Size = new System.Drawing.Size(40, 40);
            this.cmdCargare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cmdCargare.TabIndex = 8;
            this.cmdCargare.TabStop = false;
            this.cmdCargare.Click += new System.EventHandler(this.cmdCargare_Click);
            // 
            // cmdBorrar
            // 
            this.cmdBorrar.Image = ((System.Drawing.Image)(resources.GetObject("cmdBorrar.Image")));
            this.cmdBorrar.Location = new System.Drawing.Point(468, 85);
            this.cmdBorrar.Name = "cmdBorrar";
            this.cmdBorrar.Size = new System.Drawing.Size(44, 44);
            this.cmdBorrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cmdBorrar.TabIndex = 12;
            this.cmdBorrar.TabStop = false;
            this.cmdBorrar.Click += new System.EventHandler(this.cmdBorrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(473, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 9);
            this.label3.TabIndex = 21;
            this.label3.Text = "AÑADIR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(470, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 9);
            this.label2.TabIndex = 21;
            this.label2.Text = "ELIMINAR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "NOMBRE Y APELLIDO:";
            // 
            // frmAgregarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 309);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmdBorrar);
            this.Controls.Add(this.cmdCargare);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cmdVolver);
            this.Controls.Add(this.txtEmpleado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAgregarEmpleado";
            this.Text = "AGREGAR EMPLEADO";
            this.Load += new System.EventHandler(this.frmAgregarEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmdVolver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdCargare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdBorrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.PictureBox cmdVolver;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox cmdCargare;
        private System.Windows.Forms.PictureBox cmdBorrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}