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
            ((System.ComponentModel.ISupportInitialize)(this.cmdVolver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdBorrarTodo)).BeginInit();
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
            // frmTodosLosRetiros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 450);
            this.Controls.Add(this.cmdBorrarTodo);
            this.Controls.Add(this.lsbTodosRetiros);
            this.Controls.Add(this.cmdVolver);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTodosLosRetiros";
            this.Text = "TODOS LOS RETIROS";
            this.Load += new System.EventHandler(this.frmTodosLosRetiros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmdVolver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdBorrarTodo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox cmdVolver;
        private System.Windows.Forms.ListBox lsbTodosRetiros;
        private System.Windows.Forms.PictureBox cmdBorrarTodo;
    }
}