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
            this.txtPrecio.Location = new System.Drawing.Point(71, 80);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecio.MaxLength = 10;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(283, 55);
            this.txtPrecio.TabIndex = 1;
            this.txtPrecio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrecio_KeyDown);
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 58);
            this.label1.TabIndex = 2;
            this.label1.Text = "PRECIO POR DÍA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 58);
            this.label2.TabIndex = 2;
            this.label2.Text = "$";
            // 
            // cmdCargar2
            // 
            this.cmdCargar2.Image = ((System.Drawing.Image)(resources.GetObject("cmdCargar2.Image")));
            this.cmdCargar2.Location = new System.Drawing.Point(363, 80);
            this.cmdCargar2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdCargar2.Name = "cmdCargar2";
            this.cmdCargar2.Size = new System.Drawing.Size(60, 55);
            this.cmdCargar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cmdCargar2.TabIndex = 13;
            this.cmdCargar2.TabStop = false;
            this.cmdCargar2.Click += new System.EventHandler(this.cmdCargar2_Click);
            // 
            // cmdVolver2
            // 
            this.cmdVolver2.Image = ((System.Drawing.Image)(resources.GetObject("cmdVolver2.Image")));
            this.cmdVolver2.Location = new System.Drawing.Point(449, 139);
            this.cmdVolver2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdVolver2.Name = "cmdVolver2";
            this.cmdVolver2.Size = new System.Drawing.Size(60, 55);
            this.cmdVolver2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cmdVolver2.TabIndex = 14;
            this.cmdVolver2.TabStop = false;
            this.cmdVolver2.Click += new System.EventHandler(this.cmdVolver2_Click);
            // 
            // frmPrecioPorDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 202);
            this.Controls.Add(this.cmdVolver2);
            this.Controls.Add(this.cmdCargar2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrecio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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