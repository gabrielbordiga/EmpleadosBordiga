namespace Gestión_Empleados
{
    partial class frmTodosLosRetiros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTodosLosRetiros));
            this.cmdVolver = new System.Windows.Forms.PictureBox();
            this.lsbTodosRetiros = new System.Windows.Forms.ListBox();
            this.cmdBorrarTodo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cmdVolver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdBorrarTodo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdVolver
            // 
            this.cmdVolver.Image = ((System.Drawing.Image)(resources.GetObject("cmdVolver.Image")));
            this.cmdVolver.Location = new System.Drawing.Point(547, 393);
            this.cmdVolver.Name = "cmdVolver";
            this.cmdVolver.Size = new System.Drawing.Size(45, 45);
            this.cmdVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cmdVolver.TabIndex = 11;
            this.cmdVolver.TabStop = false;
            this.cmdVolver.Click += new System.EventHandler(this.cmdVolver_Click);
            // 
            // lsbTodosRetiros
            // 
            this.lsbTodosRetiros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbTodosRetiros.FormattingEnabled = true;
            this.lsbTodosRetiros.ItemHeight = 20;
            this.lsbTodosRetiros.Location = new System.Drawing.Point(12, 12);
            this.lsbTodosRetiros.Name = "lsbTodosRetiros";
            this.lsbTodosRetiros.Size = new System.Drawing.Size(579, 364);
            this.lsbTodosRetiros.TabIndex = 19;
            this.lsbTodosRetiros.SelectedIndexChanged += new System.EventHandler(this.lsbTodosRetiros_SelectedIndexChanged);
            // 
            // cmdBorrarTodo
            // 
            this.cmdBorrarTodo.Image = ((System.Drawing.Image)(resources.GetObject("cmdBorrarTodo.Image")));
            this.cmdBorrarTodo.Location = new System.Drawing.Point(12, 393);
            this.cmdBorrarTodo.Name = "cmdBorrarTodo";
            this.cmdBorrarTodo.Size = new System.Drawing.Size(47, 47);
            this.cmdBorrarTodo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cmdBorrarTodo.TabIndex = 20;
            this.cmdBorrarTodo.TabStop = false;
            this.cmdBorrarTodo.Click += new System.EventHandler(this.cmdBorrarTodo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(65, 393);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(115, 429);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 9);
            this.label5.TabIndex = 22;
            this.label5.Text = "ARCHIVO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(115, 420);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 9);
            this.label4.TabIndex = 23;
            this.label4.Text = "VER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 9);
            this.label3.TabIndex = 24;
            this.label3.Text = "ARCHIVAR";
            // 
            // frmTodosLosRetiros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmdBorrarTodo);
            this.Controls.Add(this.lsbTodosRetiros);
            this.Controls.Add(this.cmdVolver);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTodosLosRetiros";
            this.Text = "TODOS LOS RETIROS";
            this.Load += new System.EventHandler(this.frmTodosLosRetiros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmdVolver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdBorrarTodo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox cmdVolver;
        private System.Windows.Forms.ListBox lsbTodosRetiros;
        private System.Windows.Forms.PictureBox cmdBorrarTodo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}