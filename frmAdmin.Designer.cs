namespace Gestión_Empleados
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.cmdCerrar = new System.Windows.Forms.PictureBox();
            this.cmdMinimiz = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.cmdMinimizar = new System.Windows.Forms.PictureBox();
            this.cmdPrograma = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdResetear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cmdCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdMinimiz)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdPrograma)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Image = ((System.Drawing.Image)(resources.GetObject("cmdCerrar.Image")));
            this.cmdCerrar.Location = new System.Drawing.Point(486, 2);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(20, 20);
            this.cmdCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cmdCerrar.TabIndex = 29;
            this.cmdCerrar.TabStop = false;
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // cmdMinimiz
            // 
            this.cmdMinimiz.Image = ((System.Drawing.Image)(resources.GetObject("cmdMinimiz.Image")));
            this.cmdMinimiz.Location = new System.Drawing.Point(460, 2);
            this.cmdMinimiz.Name = "cmdMinimiz";
            this.cmdMinimiz.Size = new System.Drawing.Size(23, 22);
            this.cmdMinimiz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cmdMinimiz.TabIndex = 29;
            this.cmdMinimiz.TabStop = false;
            this.cmdMinimiz.Click += new System.EventHandler(this.cmdMinimiz_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.cmdCerrar);
            this.panel1.Controls.Add(this.cmdMinimiz);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.cmdMinimizar);
            this.panel1.Location = new System.Drawing.Point(-28, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 25);
            this.panel1.TabIndex = 29;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(639, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 22);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(701, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 22);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // cmdMinimizar
            // 
            this.cmdMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("cmdMinimizar.Image")));
            this.cmdMinimizar.Location = new System.Drawing.Point(962, 3);
            this.cmdMinimizar.Name = "cmdMinimizar";
            this.cmdMinimizar.Size = new System.Drawing.Size(30, 22);
            this.cmdMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cmdMinimizar.TabIndex = 1;
            this.cmdMinimizar.TabStop = false;
            // 
            // cmdPrograma
            // 
            this.cmdPrograma.Image = ((System.Drawing.Image)(resources.GetObject("cmdPrograma.Image")));
            this.cmdPrograma.Location = new System.Drawing.Point(436, 32);
            this.cmdPrograma.Name = "cmdPrograma";
            this.cmdPrograma.Size = new System.Drawing.Size(42, 41);
            this.cmdPrograma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cmdPrograma.TabIndex = 30;
            this.cmdPrograma.TabStop = false;
            this.cmdPrograma.Click += new System.EventHandler(this.cmdPrograma_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(370, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "PROGRAMA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "IR AL";
            // 
            // cmdResetear
            // 
            this.cmdResetear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdResetear.Location = new System.Drawing.Point(106, 108);
            this.cmdResetear.Name = "cmdResetear";
            this.cmdResetear.Size = new System.Drawing.Size(273, 67);
            this.cmdResetear.TabIndex = 33;
            this.cmdResetear.Text = "RESETEAR PROGRAMA";
            this.cmdResetear.UseVisualStyleBackColor = true;
            this.cmdResetear.Click += new System.EventHandler(this.cmdResetear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(344, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "powered by: BORDIGA";
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmdResetear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdPrograma);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdmin";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmdCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdMinimiz)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdPrograma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox cmdCerrar;
        private System.Windows.Forms.PictureBox cmdMinimiz;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox cmdMinimizar;
        private System.Windows.Forms.PictureBox cmdPrograma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdResetear;
        private System.Windows.Forms.Label label3;
    }
}