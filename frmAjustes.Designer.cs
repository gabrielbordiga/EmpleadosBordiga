namespace Gestión_Empleados
{
    partial class frmAjustes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAjustes));
            this.cmdVolver = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdCerrar = new System.Windows.Forms.PictureBox();
            this.cmdMinimizar = new System.Windows.Forms.PictureBox();
            this.gpbCantidadRedondeo = new System.Windows.Forms.GroupBox();
            this.rd1 = new System.Windows.Forms.RadioButton();
            this.rd2 = new System.Windows.Forms.RadioButton();
            this.rd3 = new System.Windows.Forms.RadioButton();
            this.rd4 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gpbEjemplo = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSinRedondeo = new System.Windows.Forms.Label();
            this.lblConRedondeo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rdArriba = new System.Windows.Forms.RadioButton();
            this.rdAbajo = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.cmdVolver)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmdCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdMinimizar)).BeginInit();
            this.gpbCantidadRedondeo.SuspendLayout();
            this.gpbEjemplo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdVolver
            // 
            this.cmdVolver.Image = ((System.Drawing.Image)(resources.GetObject("cmdVolver.Image")));
            this.cmdVolver.Location = new System.Drawing.Point(465, 270);
            this.cmdVolver.Name = "cmdVolver";
            this.cmdVolver.Size = new System.Drawing.Size(45, 45);
            this.cmdVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cmdVolver.TabIndex = 12;
            this.cmdVolver.TabStop = false;
            this.cmdVolver.Click += new System.EventHandler(this.cmdVolver_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.cmdCerrar);
            this.panel1.Controls.Add(this.cmdMinimizar);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 25);
            this.panel1.TabIndex = 13;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Image = ((System.Drawing.Image)(resources.GetObject("cmdCerrar.Image")));
            this.cmdCerrar.Location = new System.Drawing.Point(490, 3);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(20, 20);
            this.cmdCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cmdCerrar.TabIndex = 30;
            this.cmdCerrar.TabStop = false;
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // cmdMinimizar
            // 
            this.cmdMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("cmdMinimizar.Image")));
            this.cmdMinimizar.Location = new System.Drawing.Point(457, 3);
            this.cmdMinimizar.Name = "cmdMinimizar";
            this.cmdMinimizar.Size = new System.Drawing.Size(30, 22);
            this.cmdMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cmdMinimizar.TabIndex = 1;
            this.cmdMinimizar.TabStop = false;
            this.cmdMinimizar.Click += new System.EventHandler(this.cmdMinimizar_Click);
            // 
            // gpbCantidadRedondeo
            // 
            this.gpbCantidadRedondeo.Controls.Add(this.groupBox1);
            this.gpbCantidadRedondeo.Controls.Add(this.gpbEjemplo);
            this.gpbCantidadRedondeo.Controls.Add(this.label1);
            this.gpbCantidadRedondeo.Controls.Add(this.rd4);
            this.gpbCantidadRedondeo.Controls.Add(this.rd3);
            this.gpbCantidadRedondeo.Controls.Add(this.rd2);
            this.gpbCantidadRedondeo.Controls.Add(this.rd1);
            this.gpbCantidadRedondeo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCantidadRedondeo.Location = new System.Drawing.Point(14, 40);
            this.gpbCantidadRedondeo.Name = "gpbCantidadRedondeo";
            this.gpbCantidadRedondeo.Size = new System.Drawing.Size(492, 220);
            this.gpbCantidadRedondeo.TabIndex = 14;
            this.gpbCantidadRedondeo.TabStop = false;
            this.gpbCantidadRedondeo.Text = "Cantidad de Redondeo";
            // 
            // rd1
            // 
            this.rd1.AutoSize = true;
            this.rd1.Location = new System.Drawing.Point(32, 79);
            this.rd1.Name = "rd1";
            this.rd1.Size = new System.Drawing.Size(36, 24);
            this.rd1.TabIndex = 0;
            this.rd1.TabStop = true;
            this.rd1.Text = "0";
            this.rd1.UseVisualStyleBackColor = true;
            this.rd1.CheckedChanged += new System.EventHandler(this.rd1_CheckedChanged);
            // 
            // rd2
            // 
            this.rd2.AutoSize = true;
            this.rd2.Location = new System.Drawing.Point(32, 109);
            this.rd2.Name = "rd2";
            this.rd2.Size = new System.Drawing.Size(45, 24);
            this.rd2.TabIndex = 0;
            this.rd2.TabStop = true;
            this.rd2.Text = "00";
            this.rd2.UseVisualStyleBackColor = true;
            this.rd2.CheckedChanged += new System.EventHandler(this.rd2_CheckedChanged);
            // 
            // rd3
            // 
            this.rd3.AutoSize = true;
            this.rd3.Location = new System.Drawing.Point(32, 139);
            this.rd3.Name = "rd3";
            this.rd3.Size = new System.Drawing.Size(54, 24);
            this.rd3.TabIndex = 0;
            this.rd3.TabStop = true;
            this.rd3.Text = "000";
            this.rd3.UseVisualStyleBackColor = true;
            this.rd3.CheckedChanged += new System.EventHandler(this.rd3_CheckedChanged);
            // 
            // rd4
            // 
            this.rd4.AutoSize = true;
            this.rd4.Location = new System.Drawing.Point(32, 169);
            this.rd4.Name = "rd4";
            this.rd4.Size = new System.Drawing.Size(63, 24);
            this.rd4.TabIndex = 0;
            this.rd4.TabStop = true;
            this.rd4.Text = "0000";
            this.rd4.UseVisualStyleBackColor = true;
            this.rd4.CheckedChanged += new System.EventHandler(this.rd4_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Esta cantidad de redondeo afecta al valor total de la suma de una hora extra al v" +
    "alor total al regitrar los días.";
            // 
            // gpbEjemplo
            // 
            this.gpbEjemplo.Controls.Add(this.label4);
            this.gpbEjemplo.Controls.Add(this.lblConRedondeo);
            this.gpbEjemplo.Controls.Add(this.lblSinRedondeo);
            this.gpbEjemplo.Controls.Add(this.label3);
            this.gpbEjemplo.Controls.Add(this.label2);
            this.gpbEjemplo.Location = new System.Drawing.Point(234, 79);
            this.gpbEjemplo.Name = "gpbEjemplo";
            this.gpbEjemplo.Size = new System.Drawing.Size(238, 114);
            this.gpbEjemplo.TabIndex = 2;
            this.gpbEjemplo.TabStop = false;
            this.gpbEjemplo.Text = "Ejemplo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Antes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Después";
            // 
            // lblSinRedondeo
            // 
            this.lblSinRedondeo.AutoSize = true;
            this.lblSinRedondeo.Location = new System.Drawing.Point(143, 35);
            this.lblSinRedondeo.Name = "lblSinRedondeo";
            this.lblSinRedondeo.Size = new System.Drawing.Size(54, 20);
            this.lblSinRedondeo.TabIndex = 1;
            this.lblSinRedondeo.Text = "24750";
            // 
            // lblConRedondeo
            // 
            this.lblConRedondeo.AutoSize = true;
            this.lblConRedondeo.Location = new System.Drawing.Point(143, 78);
            this.lblConRedondeo.Name = "lblConRedondeo";
            this.lblConRedondeo.Size = new System.Drawing.Size(54, 20);
            this.lblConRedondeo.TabIndex = 1;
            this.lblConRedondeo.Text = "24750";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "--------------------------------------------";
            // 
            // rdArriba
            // 
            this.rdArriba.AutoSize = true;
            this.rdArriba.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdArriba.Location = new System.Drawing.Point(19, 31);
            this.rdArriba.Name = "rdArriba";
            this.rdArriba.Size = new System.Drawing.Size(69, 24);
            this.rdArriba.TabIndex = 3;
            this.rdArriba.TabStop = true;
            this.rdArriba.Text = "Arriba";
            this.rdArriba.UseVisualStyleBackColor = true;
            this.rdArriba.CheckedChanged += new System.EventHandler(this.rdArriba_CheckedChanged);
            // 
            // rdAbajo
            // 
            this.rdAbajo.AutoSize = true;
            this.rdAbajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdAbajo.Location = new System.Drawing.Point(19, 70);
            this.rdAbajo.Name = "rdAbajo";
            this.rdAbajo.Size = new System.Drawing.Size(68, 24);
            this.rdAbajo.TabIndex = 3;
            this.rdAbajo.TabStop = true;
            this.rdAbajo.Text = "Abajo";
            this.rdAbajo.UseVisualStyleBackColor = true;
            this.rdAbajo.CheckedChanged += new System.EventHandler(this.rdAbajo_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdArriba);
            this.groupBox1.Controls.Add(this.rdAbajo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(103, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(112, 115);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Redondear Para:";
            // 
            // frmAjustes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 327);
            this.Controls.Add(this.gpbCantidadRedondeo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmdVolver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAjustes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAjustes";
            this.Load += new System.EventHandler(this.frmAjustes_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmAjustes_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.cmdVolver)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmdCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdMinimizar)).EndInit();
            this.gpbCantidadRedondeo.ResumeLayout(false);
            this.gpbCantidadRedondeo.PerformLayout();
            this.gpbEjemplo.ResumeLayout(false);
            this.gpbEjemplo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox cmdVolver;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox cmdCerrar;
        private System.Windows.Forms.PictureBox cmdMinimizar;
        private System.Windows.Forms.GroupBox gpbCantidadRedondeo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rd4;
        private System.Windows.Forms.RadioButton rd3;
        private System.Windows.Forms.RadioButton rd2;
        private System.Windows.Forms.RadioButton rd1;
        private System.Windows.Forms.GroupBox gpbEjemplo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblConRedondeo;
        private System.Windows.Forms.Label lblSinRedondeo;
        private System.Windows.Forms.RadioButton rdAbajo;
        private System.Windows.Forms.RadioButton rdArriba;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}