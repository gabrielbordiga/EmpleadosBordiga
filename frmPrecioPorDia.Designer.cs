namespace Gestión_Empleados
{
    partial class frmPrecioPorDia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrecioPorDia));
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdCargar2 = new System.Windows.Forms.PictureBox();
            this.cmdVolver2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cmdCargar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdVolver2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(53, 65);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(213, 45);
            this.txtPrecio.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "PRECIO POR DÍA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "$";
            // 
            // cmdCargar2
            // 
            this.cmdCargar2.Image = ((System.Drawing.Image)(resources.GetObject("cmdCargar2.Image")));
            this.cmdCargar2.Location = new System.Drawing.Point(272, 65);
            this.cmdCargar2.Name = "cmdCargar2";
            this.cmdCargar2.Size = new System.Drawing.Size(45, 45);
            this.cmdCargar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cmdCargar2.TabIndex = 13;
            this.cmdCargar2.TabStop = false;
            this.cmdCargar2.Click += new System.EventHandler(this.cmdCargar2_Click);
            // 
            // cmdVolver2
            // 
            this.cmdVolver2.Image = ((System.Drawing.Image)(resources.GetObject("cmdVolver2.Image")));
            this.cmdVolver2.Location = new System.Drawing.Point(337, 113);
            this.cmdVolver2.Name = "cmdVolver2";
            this.cmdVolver2.Size = new System.Drawing.Size(45, 45);
            this.cmdVolver2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cmdVolver2.TabIndex = 14;
            this.cmdVolver2.TabStop = false;
            this.cmdVolver2.Click += new System.EventHandler(this.cmdVolver2_Click);
            // 
            // frmPrecioPorDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 164);
            this.Controls.Add(this.cmdVolver2);
            this.Controls.Add(this.cmdCargar2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrecio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrecioPorDia";
            this.Text = "PRECIO POR DÍA";
            ((System.ComponentModel.ISupportInitialize)(this.cmdCargar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdVolver2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox cmdCargar2;
        private System.Windows.Forms.PictureBox cmdVolver2;
    }
}