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
            this.cmdVolver = new System.Windows.Forms.Button();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.cmdBorrarTodo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdVolver
            // 
            this.cmdVolver.Location = new System.Drawing.Point(442, 176);
            this.cmdVolver.Name = "cmdVolver";
            this.cmdVolver.Size = new System.Drawing.Size(81, 44);
            this.cmdVolver.TabIndex = 0;
            this.cmdVolver.Text = "VOLVER";
            this.cmdVolver.UseVisualStyleBackColor = true;
            this.cmdVolver.Click += new System.EventHandler(this.cmdVolver_Click);
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpleado.Location = new System.Drawing.Point(60, 101);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(453, 38);
            this.txtEmpleado.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "AGREGAR";
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Location = new System.Drawing.Point(529, 176);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(81, 43);
            this.cmdGuardar.TabIndex = 3;
            this.cmdGuardar.Text = "CARGAR";
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // cmdBorrarTodo
            // 
            this.cmdBorrarTodo.Location = new System.Drawing.Point(12, 176);
            this.cmdBorrarTodo.Name = "cmdBorrarTodo";
            this.cmdBorrarTodo.Size = new System.Drawing.Size(104, 43);
            this.cmdBorrarTodo.TabIndex = 3;
            this.cmdBorrarTodo.Text = "BORRAR TODO";
            this.cmdBorrarTodo.UseVisualStyleBackColor = true;
            this.cmdBorrarTodo.Click += new System.EventHandler(this.cmdBorrarTodo_Click);
            // 
            // frmAgregarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 232);
            this.Controls.Add(this.cmdBorrarTodo);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmpleado);
            this.Controls.Add(this.cmdVolver);
            this.Name = "frmAgregarEmpleado";
            this.Text = "AGREGAR EMPLEADO";
            this.Load += new System.EventHandler(this.frmAgregarEmpleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdVolver;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.Button cmdBorrarTodo;
    }
}